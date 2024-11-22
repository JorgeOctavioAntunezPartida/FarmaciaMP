using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static FarmaciaMP.pantalla_inicio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.Collections;

namespace FarmaciaMP
{
    public partial class frm_propietario : Form
    {
        public frm_propietario()
        {
            InitializeComponent();
        }

        SqlConnection Conex = new SqlConnection(ConexionSQL.conexioSql);

        #region Boton Guardar
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            char gender;
            string cleanNumber;

            if (isValidRegister())
            {
                gender = cbx_ownerGender.SelectedIndex == 0 ? 'H' : 'M';
                cleanNumber = Regex.Replace(txt_ownerPhoneNumber.Text, @"\s+", "");

                Conex.Open();

                string consulta = "INSERT INTO ownerTable (ownerName, ownerLastName, ownerGender, ownerPhoneNumber, ownerGmail)" +
                      " VALUES (@Name, @LastName, @Gender, @PhoneNumber, @Gmail);";

                using (SqlCommand comando = new SqlCommand(consulta, Conex))
                {
                    comando.Parameters.AddWithValue("@Name", txt_ownerName.Text);
                    comando.Parameters.AddWithValue("@LastName", txt_ownerLastName.Text);
                    comando.Parameters.AddWithValue("@Gender", gender);
                    comando.Parameters.AddWithValue("@PhoneNumber", cleanNumber);
                    comando.Parameters.AddWithValue("@Gmail", txt_ownerGmail.Text);

                    // Ejecutar la consulta
                    comando.ExecuteNonQuery();
                }

                MessageBox.Show("Nuevo propietario agregado: " + txt_ownerName.Text, "Registro almacenado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Conex.Close();

                ClearRegister(); // Limpia las cajas de texto
            }
        }
        #endregion

        #region Boton Eliminar
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (btn_eliminar.BackColor == Color.White)
            {
                gbx_table.Visible = true;
                btn_guardar.Enabled = false;
                btn_modificar.Enabled = false;
                btn_cancelar.Visible = true;

                btn_eliminar.BackColor = Color.Red;
                btn_eliminar.ForeColor = Color.White;
                btn_eliminar.FlatAppearance.BorderColor = Color.White;

                ViewTable("SELECT ownerId AS ID, CONCAT(ownerName, ' ', ownerLastName) AS Propietario FROM ownerTable;");
            }
            else
            {
                if (dgv_ownerTable.SelectedCells.Count > 0)
                {
                    // Obtener la celda seleccionada
                    DataGridViewCell selectedCell = dgv_ownerTable.SelectedCells[0];

                    // Obtener la fila correspondiente a la celda seleccionada
                    DataGridViewRow selectedRow = selectedCell.OwningRow;

                    if (selectedRow.Cells["ID"].Value != null && selectedRow.Cells["Propietario"].Value != null)
                    {
                        // Acceder a los valores de las celdas de la fila seleccionada
                        var ownerId = selectedRow.Cells["ID"].Value.ToString();
                        var propietario = selectedRow.Cells["Propietario"].Value.ToString();

                        // Mostrar los valores
                        DialogResult result = MessageBox.Show($"Está seguro que desea eliminar al\npropietario  {propietario} con Id: {ownerId}", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (result == DialogResult.Yes)
                        {
                            Conex.Open();
                            SqlCommand Instruc = new SqlCommand("DELETE FROM ownerTable WHERE ownerId = " + ownerId, Conex);
                            Instruc.ExecuteNonQuery();
                            Conex.Close();
                            MessageBox.Show("El propietario ha sido eliminado.", "Eliminar registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BackBtnEliminar();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona al propietario que desea eliminar.", "Eliminar registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BackBtnEliminar()
        {
            gbx_table.Visible = false;
            btn_guardar.Enabled = true;
            btn_modificar.Enabled = true;
            btn_cancelar.Visible = false;

            btn_eliminar.BackColor = Color.White;
            btn_eliminar.ForeColor = Color.FromArgb(255, 128, 0);
            btn_eliminar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
        }
        #endregion

        #region Boton Modificar
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (btn_eliminar.BackColor == Color.White)
            {
                gbx_table.Visible = true;
                btn_guardar.Enabled = false;
                btn_eliminar.Enabled = false;
                btn_cancelar.Visible = true;

                btn_modificar.BackColor = Color.Yellow;
                btn_modificar.ForeColor = Color.Black;
                btn_modificar.FlatAppearance.BorderColor = Color.White;

                ViewTable("SELECT ownerId AS ID, CONCAT(ownerName, ' ', ownerLastName) AS Propietario FROM ownerTable;");
            }
            else
            {

            }
        }

        private void BackBtnModificar()
        {
            gbx_table.Visible = false;
            btn_guardar.Enabled = true;
            btn_eliminar.Enabled = true;
            btn_cancelar.Visible = false;

            btn_modificar.BackColor = Color.White;
            btn_modificar.ForeColor = Color.FromArgb(255, 128, 0);
            btn_modificar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
        }
        #endregion

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (btn_eliminar.BackColor == Color.Red)
            {
                BackBtnEliminar();
            }

            if (btn_modificar.BackColor == Color.Yellow)
            {
                BackBtnModificar();
            }
        }

        #region Funciones Adicionales
        public void ViewTable(string query)
        {
            // Crear una conexión con la base de datos
            using (SqlConnection connection = new SqlConnection(ConexionSQL.conexioSql))
            {
                try
                {
                    // Abrir la conexión
                    connection.Open();

                    // Crear un adaptador de datos SQL para ejecutar la consulta
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                    // Crear una tabla de datos para almacenar los resultados
                    DataTable dataTable = new DataTable();

                    // Llenar la tabla con los resultados de la consulta
                    dataAdapter.Fill(dataTable);

                    // Establecer el origen de datos del DataGridView a la tabla de datos
                    dgv_ownerTable.DataSource = dataTable;

                    dgv_ownerTable.Columns["ID"].Width = 50;
                    dgv_ownerTable.Columns["Propietario"].Width = 200;
                    dgv_ownerTable.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 12);
                    dgv_ownerTable.DefaultCellStyle.Font = new Font("Verdana", 12);
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public void ClearRegister()
        {
            txt_ownerName.Clear();
            txt_ownerLastName.Clear();
            cbx_ownerGender.SelectedIndex = -1;
            txt_ownerPhoneNumber.Clear();
            txt_ownerGmail.Clear();
        }
        #endregion

        #region Validación
        public bool isValidRegister()
        {
            // Usar un StringBuilder para manejar los errores de manera más eficiente
            StringBuilder errorMessages = new StringBuilder();

            // Verificar cada campo y agregar los mensajes de error si es necesario
            if (!NameIsValid(txt_ownerName.Text))
            {
                errorMessages.AppendLine("El nombre no puede tener letras o estar vacío.");
            }

            if (!NameIsValid(txt_ownerLastName.Text))
            {
                errorMessages.AppendLine("El apellido no puede tener letras o estar vacío.");
            }

            if (!IsSelectGender())
            {
                errorMessages.AppendLine("No has seleccionado ningún género.");
            }

            if (!IsValidPhoneNumber(txt_ownerPhoneNumber.Text))
            {
                errorMessages.AppendLine("Un número telefónico solo puede tener caracteres numéricos.");
            }

            if (!IsValidEmail(txt_ownerGmail.Text))
            {
                errorMessages.AppendLine("El formato del correo electrónico no es válido.");
            }

            // Verificar si hay errores y mostrar el mensaje
            if (errorMessages.Length > 0)
            {
                MessageBox.Show(errorMessages.ToString(), "Error al crear el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Si no hay errores, retornar true
            return true;
        }

        public bool IsSelectGender()
        {
            bool valid; // Hay algun genero seleccionado?
            valid = cbx_ownerGender.SelectedIndex == -1 ? false : true;
            return valid;
        }

        public static bool IsValidEmail(string email)
        {
            // Expresión regular para validar el correo electrónico
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsValidPhoneNumber(string text)
        {
            // Expresión regular para solo números y espacios
            string pattern = @"^[0-9\s]+$";
            return Regex.IsMatch(text, pattern);
        }

        private bool NameIsValid(string text)
        {
            // Expresión regular para solo letras y espacios
            string pattern = @"^[a-zA-Z\s]+$";
            return Regex.IsMatch(text, pattern);
        }
        #endregion

        #region Control de Ventanas
        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Form inicio = new pantalla_inicio();
            inicio.Show();
            this.Close();
        }

        private void btn_farmacia_Click(object sender, EventArgs e)
        {
            Form farmacia = new frm_farmacia();
            farmacia.Show();
            this.Close();
        }

        private void btn_medicamento_Click(object sender, EventArgs e)
        {
            Form medicamento = new frm_medicamento();
            medicamento.Show();
            this.Close();
        }

        private void btn_ciudad_Click(object sender, EventArgs e)
        {
            Form ciudad = new frm_ciudad();
            ciudad.Show();
            this.Close();
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            Form consulta = new frm_consulta();
            consulta.Show();
            this.Close();
        }
        #endregion
    }
}