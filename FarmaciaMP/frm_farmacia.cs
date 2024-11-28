using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FarmaciaMP.pantalla_inicio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FarmaciaMP
{
    public partial class frm_farmacia : Form
    {
        public frm_farmacia()
        {
            InitializeComponent();
            LoadOwners();
            LoadLocation();
            LoadMedicine();
            LoadPharmacy();
        }

        SqlConnection Conex = new SqlConnection(ConexionSQL.conexioSql);
        int updateId = 0;

        #region Boton Guardar
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string pattern = @"^\d+";
            string consulta;
            string mssj;

            if (btn_modificar.Text == "Modificar") // Cargar un nuevo registro
            {
                consulta = "INSERT INTO pharmacyTable (pharmacyName, ownerId, locationId)" +
                      " VALUES (@pharmacyName, @ownerId, @locationId);";
                mssj = "Nueva farmacia agregada: ";
            }
            else                                   // Actualizar un registro
            {
                consulta = "UPDATE pharmacyTable SET pharmacyName = @pharmacyName WHERE pharmacyId = " + updateId.ToString();
                mssj = "Actualización de farmacia: ";
            }

            if (isValidRegister())
            {
                Conex.Open();

                // Utiliza las expresiones regulares para extraer los números de los ComboBox
                Match match1 = Regex.Match(cbx_ownerId.Text, pattern);
                Match match2 = Regex.Match(cbx_locationId.Text, pattern);

                using (SqlCommand comando = new SqlCommand(consulta, Conex))
                {
                    comando.Parameters.AddWithValue("@pharmacyName", txt_pharmacyName.Text);
                    comando.Parameters.AddWithValue("@ownerId", int.Parse(match1.Value));
                    comando.Parameters.AddWithValue("@locationId", int.Parse(match2.Value));

                    // Ejecutar la consulta
                    comando.ExecuteNonQuery();
                }

                MessageBox.Show(mssj + txt_pharmacyName.Text, "Actualización de tabla", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                btn_stock.Enabled = false;
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
                btn_stock.Enabled = true;

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
                DesactiveCbx();
                ClearRegister(); // Limpia las cajas de texto

                gbx_table.Visible = true;
                btn_guardar.Enabled = false;
                btn_eliminar.Enabled = false;
                btn_stock.Enabled = false;
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
                ActiveCbx();
                ClearRegister(); // Limpia las cajas de texto

                btn_modificar.Text = "Modificar";
                gbx_table.Visible = false;
                btn_guardar.Enabled = true;
                btn_eliminar.Enabled = true;
                btn_stock.Enabled = true;

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

        #region Boton Stock
        private void btn_stock_Click(object sender, EventArgs e)
        {
            if (gbx_stock.Visible == false)
            {
                LoadPharmacy();
                gbx_stock.Visible = true;
                btn_guardar.Enabled = false;
                btn_eliminar.Enabled = false;
                btn_modificar.Enabled = false;
            }
            else
            {
                gbx_stock.Visible = false;
                btn_guardar.Enabled = true;
                btn_eliminar.Enabled = true;
                btn_modificar.Enabled = true;
            }
        }
        #endregion

        #region Boton Cargar
        private void btn_loadStock_Click(object sender, EventArgs e)
        {
            string pattern = @"^\d+"; // Expresión regular para obtener el número antes del ':'

            if (isValidStock()) // Verifica que el stock es válido
            {
                // Definir la consulta SQL
                string consulta = "INSERT INTO inventoryTable (pharmacyId, medicineId, stock) VALUES (@pharmacyId, @medicineId, @stock)";

                // Abre la conexión a la base de datos
                Conex.Open();

                // Utiliza las expresiones regulares para extraer los números de los ComboBox
                Match match1 = Regex.Match(cbx_pharmacy.Text, pattern);
                Match match2 = Regex.Match(cbx_medicine.Text, pattern);

                // Verifica que se haya encontrado un número en ambos ComboBox
                if (match1.Success && match2.Success)
                {
                    // Valida si el valor de stock es un número
                    if (int.TryParse(txt_stock.Text, out int stock))
                    {
                        // Prepara el comando SQL con parámetros
                        using (SqlCommand comando = new SqlCommand(consulta, Conex))
                        {
                            comando.Parameters.AddWithValue("@pharmacyId", int.Parse(match1.Value));
                            comando.Parameters.AddWithValue("@medicineId", int.Parse(match2.Value));
                            comando.Parameters.AddWithValue("@stock", stock);

                            // Ejecuta la consulta
                            comando.ExecuteNonQuery();

                            // Muestra un mensaje de éxito
                            MessageBox.Show("Stock nuevo cargado", "Actualización de tabla", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        // Limpia los controles después de la operación
                        txt_stock.Clear();
                        cbx_pharmacy.SelectedIndex = -1;
                        cbx_medicine.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Por favor ingrese un valor numérico válido para el stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione una farmacia y un medicamento válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Cierra la conexión
                Conex.Close();
            }
            else
            {
                MessageBox.Show("Los datos no son válidos para cargar el stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Funciones Adicionales
        public void ExecuteDelete()
        {
            if (dgv_pharmacyTable.SelectedCells.Count > 0)
            {
                // Obtener la celda seleccionada
                DataGridViewCell selectedCell = dgv_pharmacyTable.SelectedCells[0];

                // Obtener la fila correspondiente a la celda seleccionada
                DataGridViewRow selectedRow = selectedCell.OwningRow;

                if (selectedRow.Cells["ID"].Value != null && selectedRow.Cells["Farmacia"].Value != null)
                {
                    // Acceder a los valores de las celdas de la fila seleccionada
                    var pharmacyId = selectedRow.Cells["ID"].Value.ToString();
                    var farmacia = selectedRow.Cells["Farmacia"].Value.ToString();

                    // Mostrar los valores
                    DialogResult result = MessageBox.Show($"Está seguro que desea eliminar la\nfarmacia:  {farmacia} con Id: {pharmacyId}", "Actualización de tabla", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        Conex.Open();
                        SqlCommand Instruc = new SqlCommand("DELETE FROM pharmacyTable WHERE pharmacyId = " + pharmacyId, Conex);
                        Instruc.ExecuteNonQuery();
                        Conex.Close();
                        MessageBox.Show("La farmacia ha sido eliminada.", "Actualización de tabla", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una farmacia.", "Actualización de tabla", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ExecuteUpdate()
        {
            if (dgv_pharmacyTable.SelectedCells.Count > 0)
            {
                // Obtener la celda seleccionada
                DataGridViewCell selectedCell = dgv_pharmacyTable.SelectedCells[0];

                // Obtener la fila correspondiente a la celda seleccionada
                DataGridViewRow selectedRow = selectedCell.OwningRow;

                if (selectedRow.Cells["ID"].Value != null) // Verifica que no sea nulo
                {
                    // Acceder al valor del ID de la farmacia
                    var pharmacyId = selectedRow.Cells["ID"].Value.ToString();
                    updateId = int.Parse(pharmacyId);

                    gbx_table.Visible = false;
                    btn_guardar.Enabled = true;

                    try
                    {
                        Conex.Open();

                        // Consulta para obtener los datos específicos de la farmacia seleccionada
                        string consulta = "SELECT * FROM propietarios_direcciones WHERE ID = @ID;";

                        using (SqlCommand comando = new SqlCommand(consulta, Conex))
                        {
                            // Parámetro para la consulta
                            comando.Parameters.AddWithValue("@ID", updateId);

                            using (SqlDataReader reader = comando.ExecuteReader())
                            {
                                if (reader.Read()) // Lee el registro (si existe)
                                {
                                    // Obtén los valores de las columnas de la vista
                                    string pharmacyName = reader["Farmacia"].ToString();
                                    string ownerName = reader["Propietario"].ToString();
                                    string locationName = reader["Ubicación"].ToString();

                                    // Asigna los valores a los controles
                                    txt_pharmacyName.Text = pharmacyName;

                                    // Seleccionar el propietario en el ComboBox
                                    foreach (var item in cbx_ownerId.Items)
                                    {
                                        // Obtener el texto del ítem (asume formato "ID: texto")
                                        string comboText = item.ToString();

                                        // Extraer solo el texto después de "ID: " (si existe)
                                        string actualText = comboText.Contains(":") ? comboText.Split(':')[1].Trim() : comboText;

                                        // Comparar el texto relevante con el propietario obtenido
                                        if (actualText.Equals(ownerName, StringComparison.OrdinalIgnoreCase))
                                        {
                                            cbx_ownerId.SelectedItem = item; // Seleccionar el ítem que coincide
                                            break;
                                        }
                                    }

                                    // Seleccionar la ubicación en otro ComboBox
                                    foreach (var item in cbx_locationId.Items)
                                    {
                                        // Obtener el texto del ítem (asume formato "ID: texto")
                                        string comboText = item.ToString();

                                        // Extraer solo el texto después de "ID: " (si existe)
                                        string actualText = comboText.Contains(":") ? comboText.Split(':')[1].Trim() : comboText;

                                        // Comparar el texto relevante con la ubicación obtenida
                                        if (actualText.Equals(locationName, StringComparison.OrdinalIgnoreCase))
                                        {
                                            cbx_locationId.SelectedItem = item; // Seleccionar el ítem que coincide
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró ningún registro con ese ID.", "Actualización de tabla", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al consultar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Conex.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona una fila válida.", "Actualización de tabla", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una ubicación..", "Actualización de tabla", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM propietarios_direcciones;", connection);

                    // Crear una tabla de datos para almacenar los resultados
                    DataTable dataTable = new DataTable();

                    // Llenar la tabla con los resultados de la consulta
                    dataAdapter.Fill(dataTable);

                    // Establecer el origen de datos del DataGridView a la tabla de datos
                    dgv_pharmacyTable.DataSource = dataTable;

                    dgv_pharmacyTable.Columns["ID"].Width = 40;
                    dgv_pharmacyTable.Columns["Farmacia"].Width = 120;
                    dgv_pharmacyTable.Columns["Propietario"].Width = 150;
                    dgv_pharmacyTable.Columns["Ubicación"].Width = 160;
                    dgv_pharmacyTable.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 12);
                    dgv_pharmacyTable.DefaultCellStyle.Font = new Font("Verdana", 12);
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LoadOwners()
        {
            string query = "SELECT CONCAT(ownerId, ': ', ownerName, ' ', ownerLastName) AS FullName FROM ownerTable";

            try
            {
                Conex.Open();

                using (SqlCommand command = new SqlCommand(query, Conex))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Agrega cada elemento al ComboBox
                            cbx_ownerId.Items.Add(reader["FullName"].ToString());
                        }
                    }
                }

                Conex.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadLocation()
        {
            string query = "SELECT CONCAT(locationId, ': ', locationCity, '-', locationAddress) AS FullLocation FROM locationTable";

            try
            {
                Conex.Open();

                using (SqlCommand command = new SqlCommand(query, Conex))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Agrega cada elemento al ComboBox
                            cbx_locationId.Items.Add(reader["FullLocation"].ToString());
                        }
                    }
                }

                Conex.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadMedicine()
        {
            string query = "SELECT CONCAT(medicineId, ': ', medicineName) AS Medicina FROM medicineTable";

            try
            {
                Conex.Open();

                using (SqlCommand command = new SqlCommand(query, Conex))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Agrega cada elemento al ComboBox
                            cbx_medicine.Items.Add(reader["Medicina"].ToString());
                        }
                    }
                }

                Conex.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadPharmacy()
        {
            string query = "SELECT CONCAT(pharmacyId, ': ', pharmacyName) AS Farmacia FROM pharmacyTable";

            try
            {
                Conex.Open();

                using (SqlCommand command = new SqlCommand(query, Conex))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Agrega cada elemento al ComboBox
                            cbx_pharmacy.Items.Add(reader["Farmacia"].ToString());
                        }
                    }
                }

                Conex.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void ClearRegister()
        {
            txt_pharmacyName.Clear();
            cbx_ownerId.SelectedIndex = -1;
            cbx_locationId.SelectedIndex = -1;
        }

        private void ActiveCbx()
        {
            cbx_ownerId.Enabled = true;
            cbx_locationId.Enabled = true;
        }

        private void DesactiveCbx()
        {
            cbx_ownerId.Enabled = false;
            cbx_locationId.Enabled = false;
        }
        #endregion

        #region Validación
        public bool isValidRegister()
        {
            // Usar un StringBuilder para manejar los errores de manera más eficiente
            StringBuilder errorMessages = new StringBuilder();

            // Verificar cada campo y agregar los mensajes de error si es necesario
            if (isVoidName())
            {
                errorMessages.AppendLine("El nombre de la farmacia no debe de estar vacía.");
            }

            if (!IsSelectOwner())
            {
                errorMessages.AppendLine("Selecciona un propietario.");
            }

            if (!IsSelectLocation())
            {
                errorMessages.AppendLine("Selecciona una ubicación.");
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

        public bool isValidStock()
        {
            // Usar un StringBuilder para manejar los errores de manera más eficiente
            StringBuilder errorMessages = new StringBuilder();

            // Verificar cada campo y agregar los mensajes de error si es necesario
            if (!EsNumericoYValido())
            {
                errorMessages.AppendLine("Necesitas colocar una cantidad numérica.");
            }

            if (!IsSelectPhatmacy())
            {
                errorMessages.AppendLine("Selecciona una farmacia.");
            }

            if (!IsSelectMedicine())
            {
                errorMessages.AppendLine("Selecciona un medicamento.");
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

        public bool isVoidName()
        {
            return string.IsNullOrWhiteSpace(txt_pharmacyName.Text);
        }

        public bool IsSelectOwner()
        {
            bool valid; // Hay algun propietario seleccionado?
            valid = cbx_ownerId.SelectedIndex == -1 ? false : true;
            return valid;
        }

        public bool IsSelectLocation()
        {
            bool valid; // Hay alguna ubicacion seleccionado?
            valid = cbx_locationId.SelectedIndex == -1 ? false : true;
            return valid;
        }

        public bool IsSelectPhatmacy()
        {
            bool valid; // Hay algun genero seleccionado?
            valid = cbx_pharmacy.SelectedIndex == -1 ? false : true;
            return valid;
        }

        public bool IsSelectMedicine()
        {
            bool valid; // Hay algun genero seleccionado?
            valid = cbx_medicine.SelectedIndex == -1 ? false : true;
            return valid;
        }

        private bool EsNumericoYValido()
        {
            // Verifica si el campo no está vacío ni tiene solo espacios
            if (string.IsNullOrWhiteSpace(txt_stock.Text))
            {
                MessageBox.Show("El campo no puede estar vacío ni contener solo espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Verifica si el contenido es numérico (entero o decimal)
            decimal result;
            if (!decimal.TryParse(txt_stock.Text, out result))
            {
                MessageBox.Show("El campo debe contener solo valores numéricos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        #endregion

        #region Control de Ventanas
        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Form inicio = new pantalla_inicio();
            inicio.Show();
            this.Close();
        }

<<<<<<< HEAD
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            SqlCommand AltaFarmacia = new SqlCommand("Insert into regFarmacia( idFarmacia, idProp, direFarmacia, cdFarmacia, estadoFarmacia, habFarmcia, superFarmacia) values(@idFarmacia, @idProp, @direFarmacia, @cdFarmacia, @estadoFarmacia, @habFarmacia, @superFarmacia)", Conex);

            AltaFarmacia.Parameters.AddWithValue("idFarmacia", idFarmacia.Text);
            AltaFarmacia.Parameters.AddWithValue("idProp", idProp.Text);
            AltaFarmacia.Parameters.AddWithValue("direFarmacia", direFarmacia.Text);
            AltaFarmacia.Parameters.AddWithValue("cdFarmacia", cdFarmacia.Text);
            AltaFarmacia.Parameters.AddWithValue("estadoFarmacia", estadoFarmacia.Text);
            AltaFarmacia.Parameters.AddWithValue("habFarmacia", habFarmacia.Text);
            AltaFarmacia.Parameters.AddWithValue("superFarmacia", superFarmacia.Text);

            //ABRIENDO CONEXION CON LA BASE DE DAATOS
            Conex.Open();

            //ENVIANDO INFORMACION
            AltaFarmacia.ExecuteNonQuery();

            //CERRANDO CONEXION CON LA BASE DE DATOS
            Conex.Close();

            //MENSAJE DE CONFIRMACION
            MessageBox.Show("FARMACIA ALMACENADA CORRECTAMENTE");

            //LIMPIEZA DE LOS CUADROS DE TEXTO
            idFarmacia.Clear();
            idProp.Clear();
            direFarmacia.Clear();
            cdFarmacia.Clear();
            estadoFarmacia.Clear();
            habFarmacia.Clear();
            superFarmacia.Clear();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            String bajaFarm = "DELETE FROM regFarmacia WHERE idFarmacia =" + idFarmacia.Text;
            Conex.Open();
            SqlCommand Instruc = new SqlCommand(bajaFarm, Conex);

            Instruc.ExecuteNonQuery();

            idFarmacia.Clear();
            Conex.Close();
            MessageBox.Show("Registro de Farmacia eliminada");
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Conex.Open();

            string modificar = "UPDATE regFarmacia SET idFarmacia =" + idFarmacia.Text + ", idProp =" + idProp.Text + ", direFarmacia= '" + direFarmacia.Text + "', cdFarmacia= '" + cdFarmacia.Text + "', estadoFarmacia= '" + estadoFarmacia.Text + "', habFarmcia =" + habFarmacia.Text + ", superFarmacia =" + superFarmacia.Text + " WHERE idFarmacia =" + idFarmacia.Text;
            SqlCommand comando = new SqlCommand(modificar, Conex);
            int cantidad;
            cantidad = comando.ExecuteNonQuery();

            if (cantidad > 0)
            {
                MessageBox.Show("Registro Modificado");
            }

            Conex.Close();

            idFarmacia.Clear();
            idProp.Clear();
            direFarmacia.Clear();
            cdFarmacia.Clear();
            estadoFarmacia.Clear();
            habFarmacia.Clear();
            superFarmacia.Clear();
        }

=======
>>>>>>> 7223065b07a22dd466f9fe47f698acec8bff7634
        private void btn_propietario_Click(object sender, EventArgs e)
        {
            Form propietario = new frm_propietario();
            propietario.Show();
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
<<<<<<< HEAD

        private void button1_Click(object sender, EventArgs e)
        {
            Form registro = new Registro();
            registro.Show();
            this.Hide();
        }
=======
        #endregion
>>>>>>> 7223065b07a22dd466f9fe47f698acec8bff7634
    }
}
