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

namespace FarmaciaMP
{
    public partial class frm_ciudad : Form
    {
        public frm_ciudad()
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
                consulta = "INSERT INTO locationTable (locationAddress, locationCity, locationState)" +
                      " VALUES (@locationAddress, @locationCity, @locationState);";
                mssj = "Nueva ubicación agregado: ";
            }
            else                                   // Actualizar un registro
            {
                consulta = "UPDATE locationTable SET locationAddress = @locationAddress, locationCity = @locationCity, locationState = @locationState" +
                    " WHERE locationId = " + updateId.ToString();
                mssj = "Actualización de ubicación: ";
            }

            if (isValidRegister())
            {
                Conex.Open();

                using (SqlCommand comando = new SqlCommand(consulta, Conex))
                {
                    comando.Parameters.AddWithValue("@locationAddress", txt_locationAddress.Text);
                    comando.Parameters.AddWithValue("@locationCity", txt_locationCity.Text);
                    comando.Parameters.AddWithValue("@locationState", cbx_locationState.SelectedItem.ToString());

                    // Ejecutar la consulta
                    comando.ExecuteNonQuery();
                }

                MessageBox.Show(mssj + txt_locationAddress.Text, "Actualización de tabla", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            if (dgv_locationTable.SelectedCells.Count > 0)
            {
                // Obtener la celda seleccionada
                DataGridViewCell selectedCell = dgv_locationTable.SelectedCells[0];

                // Obtener la fila correspondiente a la celda seleccionada
                DataGridViewRow selectedRow = selectedCell.OwningRow;

                if (selectedRow.Cells["ID"].Value != null && selectedRow.Cells["Ubicación"].Value != null)
                {
                    // Acceder a los valores de las celdas de la fila seleccionada
                    var locationId = selectedRow.Cells["ID"].Value.ToString();
                    var ubicacion = selectedRow.Cells["Ubicación"].Value.ToString();

                    // Mostrar los valores
                    DialogResult result = MessageBox.Show($"Está seguro que desea eliminar la\nubicación {ubicacion} con Id: {locationId}", "Actualización de tabla", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        Conex.Open();
                        SqlCommand Instruc = new SqlCommand("DELETE FROM locationTable WHERE locationId = " + locationId, Conex);
                        Instruc.ExecuteNonQuery();
                        Conex.Close();
                        MessageBox.Show("La ubicación ha sido eliminado.", "Actualización de tabla", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una ubicación.", "Actualización de tabla", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ExecuteUpdate()
        {
            if (dgv_locationTable.SelectedCells.Count > 0)
            {
                // Obtener la celda seleccionada
                DataGridViewCell selectedCell = dgv_locationTable.SelectedCells[0];

                // Obtener la fila correspondiente a la celda seleccionada
                DataGridViewRow selectedRow = selectedCell.OwningRow;

                if (selectedRow.Cells["ID"].Value != null)
                {
                    // Acceder a los valores de las celdas de la fila seleccionada
                    var locationId = selectedRow.Cells["ID"].Value.ToString();
                    updateId = int.Parse(locationId);

                    gbx_table.Visible = false;
                    btn_guardar.Enabled = true;

                    Conex.Open();

                    string consulta = "SELECT * FROM locationTable WHERE locationId = @locationId";

                    using (SqlCommand comando = new SqlCommand(consulta, Conex))
                    {
                        // Parámetro para la consulta
                        comando.Parameters.AddWithValue("@locationId", locationId);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read()) // Lee el registro (si existe)
                            {
                                // Obtén los valores de las columnas
                                string locationAddress = reader.IsDBNull(1) ? null : reader.GetString(1);
                                string locationCity = reader.IsDBNull(2) ? null : reader.GetString(2);
                                string locationState = reader.IsDBNull(3) ? null : reader.GetString(3);

                                txt_locationAddress.Text = locationAddress;
                                txt_locationCity.Text = locationCity;

                                // Busca el índice que coincide exactamente con el texto
                                int indice = cbx_locationState.FindStringExact(locationState);

                                // Verifica si se encontró un índice válido
                                if (indice != -1)
                                {
                                    cbx_locationState.SelectedIndex = indice; // Selecciona el índice encontrado
                                }
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
                MessageBox.Show("Selecciona una ubicación..", "Actualización de tabla", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ViewTable()
        {
            string query;

            // Crear una conexión con la base de datos
            using (SqlConnection connection = new SqlConnection(ConexionSQL.conexioSql))
            {
                try
                {
                    // Abrir la conexión
                    connection.Open();

                    if (cbx_filterState.SelectedIndex == -1 || cbx_filterState.SelectedIndex == 0)
                    {
                        query = "SELECT locationId AS ID, CONCAT(locationCity, '-', locationAddress) AS Ubicación FROM locationTable;";
                    }
                    else
                    {
                        query = $"SELECT locationId AS ID, CONCAT(locationCity, '-', locationAddress) AS Ubicación FROM locationTable WHERE locationState = '{cbx_filterState.Text}';";
                    }

                    // Crear un adaptador de datos SQL para ejecutar la consulta
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                    // Crear una tabla de datos para almacenar los resultados
                    DataTable dataTable = new DataTable();

                    // Llenar la tabla con los resultados de la consulta
                    dataAdapter.Fill(dataTable);

                    // Establecer el origen de datos del DataGridView a la tabla de datos
                    dgv_locationTable.DataSource = dataTable;

                    dgv_locationTable.Columns["ID"].Width = 50;
                    dgv_locationTable.Columns["Ubicación"].Width = 200;
                    dgv_locationTable.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 12);
                    dgv_locationTable.DefaultCellStyle.Font = new Font("Verdana", 12);
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
            txt_locationAddress.Clear();
            txt_locationCity.Clear();
            cbx_locationState.SelectedIndex = -1;
        }

        private void cbx_filterCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewTable();
        }
        #endregion

        #region Validacion
        public bool isValidRegister()
        {
            // Usar un StringBuilder para manejar los errores de manera más eficiente
            StringBuilder errorMessages = new StringBuilder();

            // Verificar cada campo y agregar los mensajes de error si es necesario
            if (EsTextBoxVacia(txt_locationAddress))
            {
                errorMessages.AppendLine("La dirección no estar vacía.");
            }

            if (EsTextBoxVacia(txt_locationCity))
            {
                errorMessages.AppendLine("La ciudad no estar vacía.");
            }

            if (!IsSelectState())
            {
                errorMessages.AppendLine("No has seleccionado ningún estado.");
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

        public bool EsTextBoxVacia(TextBox textBox)
        {
            // Verifica si el texto es nulo, está vacío o solo contiene espacios
            return string.IsNullOrWhiteSpace(textBox.Text);
        }

        public bool IsSelectState()
        {
            bool valid; // Hay algun Estado seleccionado?
            valid = cbx_locationState.SelectedIndex == -1 ? false : true;
            return valid;
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

        private void btn_medicamento_Click(object sender, EventArgs e)
        {
            Form medicamento = new frm_medicamento();
            medicamento.Show();
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