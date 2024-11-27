using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FarmaciaMP.pantalla_inicio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FarmaciaMP
{
    public partial class frm_medicamento : Form
    {
        public frm_medicamento()
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
                consulta = "INSERT INTO medicineTable (medicineName) VALUES (@Name);";
                mssj = "Nuevo medicamento agregado: ";
            }
            else                                   // Actualizar un registro
            {
                consulta = "UPDATE medicineTable SET medicineName = @Name WHERE medicineId = " + updateId.ToString();
                mssj = "Actualización de medicamento: ";
            }

            if (isValidRegister())
            {
                Conex.Open();

                using (SqlCommand comando = new SqlCommand(consulta, Conex))
                {
                    comando.Parameters.AddWithValue("@Name", txt_medicineName.Text);

                    // Ejecutar la consulta
                    comando.ExecuteNonQuery();
                }

                MessageBox.Show(mssj + txt_medicineName.Text, "Actualización de tabla", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            if (dgv_medicineTable.SelectedCells.Count > 0)
            {
                // Obtener la celda seleccionada
                DataGridViewCell selectedCell = dgv_medicineTable.SelectedCells[0];

                // Obtener la fila correspondiente a la celda seleccionada
                DataGridViewRow selectedRow = selectedCell.OwningRow;

                if (selectedRow.Cells["ID"].Value != null && selectedRow.Cells["Medicamento"].Value != null)
                {
                    // Acceder a los valores de las celdas de la fila seleccionada
                    var medicineId = selectedRow.Cells["ID"].Value.ToString();
                    var medicamento = selectedRow.Cells["Medicamento"].Value.ToString();

                    // Mostrar los valores
                    DialogResult result = MessageBox.Show($"Está seguro que desea eliminar el\nmedicamento  {medicamento} con Id: {medicineId}", "Actualización de tabla", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        Conex.Open();
                        SqlCommand Instruc = new SqlCommand("DELETE FROM medicineTable WHERE medicineId = " + medicineId, Conex);
                        Instruc.ExecuteNonQuery();
                        Conex.Close();
                        MessageBox.Show("El medicamento ha sido eliminado.", "Actualización de tabla", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un medicamento.", "Actualización de tabla", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ExecuteUpdate()
        {
            if (dgv_medicineTable.SelectedCells.Count > 0)
            {
                // Obtener la celda seleccionada
                DataGridViewCell selectedCell = dgv_medicineTable.SelectedCells[0];

                // Obtener la fila correspondiente a la celda seleccionada
                DataGridViewRow selectedRow = selectedCell.OwningRow;

                if (selectedRow.Cells["ID"].Value != null)
                {
                    // Acceder a los valores de las celdas de la fila seleccionada
                    var medicineId = selectedRow.Cells["ID"].Value.ToString();
                    updateId = int.Parse(medicineId);

                    gbx_table.Visible = false;
                    btn_guardar.Enabled = true;

                    Conex.Open();

                    string consulta = "SELECT * FROM medicineTable WHERE medicineId = @medicineId";

                    using (SqlCommand comando = new SqlCommand(consulta, Conex))
                    {
                        // Parámetro para la consulta
                        comando.Parameters.AddWithValue("@medicineId", medicineId);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read()) // Lee el registro (si existe)
                            {
                                // Obtén los valores de las columnas
                                string medicineName = reader.GetString(1);

                                txt_medicineName.Text = medicineName;
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
                MessageBox.Show("Selecciona un medicamento.", "Actualización de tabla", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT medicineId AS ID, medicineName AS Medicamento FROM medicineTable;", connection);

                    // Crear una tabla de datos para almacenar los resultados
                    DataTable dataTable = new DataTable();

                    // Llenar la tabla con los resultados de la consulta
                    dataAdapter.Fill(dataTable);

                    // Establecer el origen de datos del DataGridView a la tabla de datos
                    dgv_medicineTable.DataSource = dataTable;

                    dgv_medicineTable.Columns["ID"].Width = 50;
                    dgv_medicineTable.Columns["Medicamento"].Width = 200;
                    dgv_medicineTable.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 12);
                    dgv_medicineTable.DefaultCellStyle.Font = new Font("Verdana", 12);
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
            txt_medicineName.Clear();
        }
        #endregion

        #region Validación
        public bool isValidRegister()
        {
            if (string.IsNullOrWhiteSpace(txt_medicineName.Text))
            {
                MessageBox.Show("El nombre del medicamento no debe de estar vacía.", "Error al crear el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region Control de Ventanas
        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Form inicio = new pantalla_inicio();
            inicio.Show();
            this.Close();
        }

        private void btn_propietario_Click(object sender, EventArgs e)
        {
            Form propietario = new frm_propietario();
            propietario.Show();
            this.Close();
        }

        private void btn_farmacia_Click(object sender, EventArgs e)
        {
            Form farmacia = new frm_farmacia();
            farmacia.Show();
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