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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FarmaciaMP
{
    public partial class frm_consulta : Form
    {
        public frm_consulta()
        {
            InitializeComponent();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Form inicio = new pantalla_inicio();
            inicio.Show();
            this.Close();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            string tabla = "regProp";

            if (cbx_tablas.SelectedIndex == -1)
            {
                // Si no hay ningún elemento seleccionado, muestra un mensaje de advertencia
                MessageBox.Show("No hay ningún elemento seleccionado. Por favor, selecciona uno.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                switch (cbx_tablas.SelectedIndex)
                {
                    case 0:
                        tabla = "regProp";
                        break;

                    case 1:
                        tabla = "regFarmacia";
                        break;

                    case 2:
                        tabla = "regMedicamento";
                        break;

                    case 3:
                        tabla = "regCiudad";
                        break;

                    default:
                        tabla = "regProp";
                        break;
                }

                // Consulta SQL para obtener los datos de la tabla
                string query = "SELECT * FROM " + tabla;

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
                        dgv_tabla.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
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

        private void btn_ciudad_Click(object sender, EventArgs e)
        {
            Form ciudad = new frm_ciudad();
            ciudad.Show();
            this.Close();
        }
    }
}
