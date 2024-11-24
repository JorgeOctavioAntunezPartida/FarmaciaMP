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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace FarmaciaMP
{
    public partial class frm_propietario : Form
    {
        public frm_propietario()
        {
            InitializeComponent();
        }

        SqlConnection Conex = new SqlConnection(ConexionSQL.conexioSql);
        int updateId = 0;

        #region Boton Guardar
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string consulta;
            string mssj;

            if (btn_modificar.Text == "Modificar") // Cargar un nuevo registro
            {
                consulta = "INSERT INTO ownerTable (ownerName, ownerLastName, ownerGender, ownerPhoneNumber, ownerGmail)" +
                      " VALUES (@Name, @LastName, @Gender, @PhoneNumber, @Gmail);";
                mssj = "Nuevo propietario agregado: ";
            }
            else                                   // Actualizar un registro
            {
                consulta = "UPDATE ownerTable SET ownerName = @Name, ownerLastName = @LastName, ownerGender = @Gender, ownerPhoneNumber = @PhoneNumber, ownerGmail = @Gmail" +
                    " WHERE ownerId = " + updateId.ToString();
                mssj = "Actualización de propietario: ";
            }

            char gender;
            string cleanNumber;

            if (isValidRegister())
            {
                gender = cbx_ownerGender.SelectedIndex == 0 ? 'H' : 'M';
                cleanNumber = Regex.Replace(txt_ownerPhoneNumber.Text, @"\s+", "");

                Conex.Open();

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

                MessageBox.Show(mssj + txt_ownerName.Text, "Actualización de tabla", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Conex.Close();

                ClearRegister(); // Limpia las cajas de texto
                btn_eliminar.Enabled = true;
                btn_modificar.Enabled = true;

                btn_modificar.Text = "Modificar";
                btn_modificar.BackColor = Color.White;
                btn_modificar.ForeColor = Color.FromArgb(255, 128, 0);
                btn_modificar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            }
        }
        #endregion

        #region Boton Eliminar
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (btn_eliminar.Text == "Eliminar")
            {
                ClearRegister(); // Limpia las cajas de texto

                gbx_table.Visible = true;
                btn_guardar.Enabled = false;
                btn_modificar.Enabled = false;
                btn_eliminar.Text = "Cancelar";

                btn_eliminar.BackColor = Color.Gray;
                btn_eliminar.ForeColor = Color.White;
                btn_eliminar.FlatAppearance.BorderColor = Color.White;

                btn_deleteUpdate.Text = "Eliminar";
                btn_deleteUpdate.BackColor = Color.Red;

                ViewTable();
            }
            else
            {
                btn_eliminar.Text = "Eliminar";
                gbx_table.Visible = false;
                btn_guardar.Enabled = true;
                btn_modificar.Enabled = true;

                btn_eliminar.BackColor = Color.White;
                btn_eliminar.ForeColor = Color.FromArgb(255, 128, 0);
                btn_eliminar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            }
        }
        #endregion

        #region Boton Modificar
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (btn_modificar.Text == "Modificar")
            {
                ClearRegister(); // Limpia las cajas de texto

                gbx_table.Visible = true;
                btn_guardar.Enabled = false;
                btn_eliminar.Enabled = false;
                btn_modificar.Text = "Cancelar";

                btn_modificar.BackColor = Color.Gray;
                btn_modificar.ForeColor = Color.White;
                btn_modificar.FlatAppearance.BorderColor = Color.White;

                btn_deleteUpdate.Text = "Modificar";
                btn_deleteUpdate.BackColor = Color.Orange;

                ViewTable();
            }
            else
            {
                ClearRegister(); // Limpia las cajas de texto

                btn_modificar.Text = "Modificar";
                gbx_table.Visible = false;
                btn_guardar.Enabled = true;
                btn_eliminar.Enabled = true;

                btn_modificar.BackColor = Color.White;
                btn_modificar.ForeColor = Color.FromArgb(255, 128, 0);
                btn_modificar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            }
        }
        #endregion

        #region Boton DeleteUpdate
        private void btn_deleteUpdate_Click(object sender, EventArgs e)
        {
            if (btn_deleteUpdate.Text == "Eliminar")
            {
                ExecuteDelete();
                ViewTable();
            }

            if (btn_deleteUpdate.Text == "Modificar")
            {
                ExecuteUpdate();
            }
        }
        #endregion

        #region Funciones Adicionales
        public void ExecuteDelete()
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
                    DialogResult result = MessageBox.Show($"Está seguro que desea eliminar al\npropietario  {propietario} con Id: {ownerId}", "Actualización de tabla", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        Conex.Open();
                        SqlCommand Instruc = new SqlCommand("DELETE FROM ownerTable WHERE ownerId = " + ownerId, Conex);
                        Instruc.ExecuteNonQuery();
                        Conex.Close();
                        MessageBox.Show("El propietario ha sido eliminado.", "Actualización de tabla", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona a un propietario.", "Actualización de tabla", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ExecuteUpdate()
        {
            if (dgv_ownerTable.SelectedCells.Count > 0)
            {
                // Obtener la celda seleccionada
                DataGridViewCell selectedCell = dgv_ownerTable.SelectedCells[0];

                // Obtener la fila correspondiente a la celda seleccionada
                DataGridViewRow selectedRow = selectedCell.OwningRow;

                if (selectedRow.Cells["ID"].Value != null)
                {
                    // Acceder a los valores de las celdas de la fila seleccionada
                    var ownerId = selectedRow.Cells["ID"].Value.ToString();
                    updateId = int.Parse(ownerId);

                    gbx_table.Visible = false;
                    btn_guardar.Enabled = true;

                    Conex.Open();

                    string consulta = "SELECT * FROM ownerTable WHERE ownerId = @ownerId";

                    using (SqlCommand comando = new SqlCommand(consulta, Conex))
                    {
                        // Parámetro para la consulta
                        comando.Parameters.AddWithValue("@ownerId", ownerId);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read()) // Lee el registro (si existe)
                            {
                                // Obtén los valores de las columnas
                                string ownerName = reader.GetString(1);
                                string ownerLastName = reader.GetString(2);
                                char ownerGender = reader.GetString(3)[0];
                                string ownerPhoneNumber = reader.IsDBNull(4) ? null : reader.GetString(4);
                                string ownerGmail = reader.IsDBNull(5) ? null : reader.GetString(5);

                                txt_ownerName.Text = ownerName;
                                txt_ownerLastName.Text = ownerLastName;
                                cbx_ownerGender.SelectedIndex = ownerGender == 'H' ? 0 : 1;
                                txt_ownerPhoneNumber.Text = ownerPhoneNumber;
                                txt_ownerGmail.Text = ownerGmail;
                            }
                            else
                            {
                                MessageBox.Show("No se encontró ningún registro con ese ID.", "Actualización de tabla", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    Conex.Close();
                }
            }
            else
            {
                MessageBox.Show("Selecciona a un propietario.", "Actualización de tabla", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ViewTable()
        {
            // Crear una conexión con la base de datos
            using (SqlConnection connection = new SqlConnection(ConexionSQL.conexioSql))
            {
                try
                {
                    // Abrir la conexión
                    connection.Open();

                    // Crear un adaptador de datos SQL para ejecutar la consulta
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT ownerId AS ID, CONCAT(ownerName, ' ', ownerLastName) AS Propietario FROM ownerTable;", connection);

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