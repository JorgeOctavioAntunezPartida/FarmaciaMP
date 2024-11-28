using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FarmaciaMP.pantalla_inicio;

namespace FarmaciaMP
{
    public partial class frm_medicamento : Form
    {
        private string conexionSql = "server=DESKTOP-D739HSR\\WINNEMAN; database=FarmaciasMP; integrated security=true";
        public frm_medicamento()
        {
            InitializeComponent();
        }

        SqlConnection Conex = new SqlConnection(ConexionSQL.conexioSql);

<<<<<<< HEAD
=======
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
>>>>>>> 7223065b07a22dd466f9fe47f698acec8bff7634
        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Form inicio = new pantalla_inicio();
            inicio.Show();
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //se abre la conexion con la base de datos
            Conex.Open();

            //Valores para cada variable
            SqlCommand AltasMed = new SqlCommand("INSERT INTO regMedicamento (idMedi, comercialMedi, genericoMedi, similarMedi, precioMedi, descripMedi) VALUES (@idMedi, @ComercialMedi, @genericoMedi, @similarMedi, @precioMedi, @descrioMedi)", Conex);

            AltasMed.Parameters.AddWithValue("idMedi", idMedi.Text);
            AltasMed.Parameters.AddWithValue("ComercialMedi", nomComercial.Text);
            AltasMed.Parameters.AddWithValue("genericoMedi", genericomedi.Text);
            AltasMed.Parameters.AddWithValue("similarMedi", similarMedi.Text);
            AltasMed.Parameters.AddWithValue("precioMedi", precioMedi.Text);
            AltasMed.Parameters.AddWithValue("descrioMedi", descripcionMedi.Text);

            //se captura los valores en la base de datos
            AltasMed.ExecuteNonQuery();

            //se cierra la conexion
            Conex.Close();

            //mensaje de socio almancenado
            MessageBox.Show("Socio Almacenado");

            //se limpian los textbox para un nuevo almacenamiento
            idMedi.Clear();
            nomComercial.Clear();
            genericomedi.Clear();
            similarMedi.Clear();
            precioMedi.Clear();
            descripcionMedi.Clear();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Conex.Open();

            string bajaMedi = "DELETE FROM regMedicamento WHERE idMedi = " + idMedi.Text;

            SqlCommand cmdBorrar = new SqlCommand(bajaMedi, Conex);
            cmdBorrar.ExecuteNonQuery();

            idMedi.Clear();

            Conex.Close();
            MessageBox.Show("Medicamento Eliminado");
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Conex.Open();
            string consulta = "UPDATE regMedicamento SET idMedi =" + idMedi.Text + ", comercialMedi = " + nomComercial.Text + ", genericoMedi='"
                + genericomedi.Text + "', similarMedi='" + similarMedi.Text + "', precioMedi=" + precioMedi.Text + ", descripMedi='" + descripcionMedi.Text + "' WHERE idMedi=" + idMedi.Text;
            SqlCommand comando = new SqlCommand(consulta, Conex);
            int cantidad;
            cantidad = comando.ExecuteNonQuery();

            if (cantidad > 0)
            {
                MessageBox.Show("Registro modificado con exito");
            }

            Conex.Close();

            idMedi.Clear();
            nomComercial.Clear();
            genericomedi.Clear();
            similarMedi.Clear();
            precioMedi.Clear();
            descripcionMedi.Clear();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form registro = new Registro();
            registro.Show();
            this.Hide();
        }
    }
}
