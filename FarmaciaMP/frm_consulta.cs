using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FarmaciaMP.pantalla_inicio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FarmaciaMP
{

    public partial class frm_consulta : Form
    {
        //private string conexion = "server=DESKTOP-D739HSR\\WINNEMAN; database=FarmaciasMP; integrated security=true";
        //string connectionString = "Server=TU_SERVIDOR;Database=FarmaciasMP;User Id=TU_USUARIO;Password=TU_CONTRASEÑA;";

        //conaatructor
        public frm_consulta()
        {
            InitializeComponent();
        }
        //LLADAMA AL METODO LOAD DATA PARA CARGAR EL PROCEDIMIENTO ALMACENADO
        private void loadDAta(string procedData, string orderDirection)
        {
            try
            {
                //ACCEDIENDO A LA BASE DE DATOS Y CREANDO UNA CONEXION LLAMADA PROCEDIMIENTO
                using (SqlConnection procedimiento = new SqlConnection(ConexionSQL.conexioSql))
                {
                    //SE ABRE LA CONEXION PROCEDIMIENTO
                    procedimiento.Open();

                    //SE CREA UN COMANDO DE SQL Y SE LE AGREGAN LOS VALORES DEL METODO 
                    using (SqlCommand cmd = new SqlCommand(procedData, procedimiento))
                    {
                        //SE CREA COMANDO Y SE LE ASGINA UN VALOR PROCEDIMIENTO Y EL NOMBRE DEL PROCEDIMIENTO ALMACENDO EN SQL
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue(@orderDirection, orderDirection);

                        //RELLENO DE TABLA EN EL FORM DESDE SQL
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGridView1.DataSource = table;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}", "Error");
            }
        }
        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Form inicio = new pantalla_inicio();
            inicio.Show();
            this.Close();
        }
        //

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            string procedureName = comboBox.SelectedItem.ToString();
            string orderDirection = comboBox.SelectedItem.ToString();
            LoadData(procedureName, orderDirection);
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
        //vistas
        private void frm_consulta_Load(object sender, EventArgs e)
        {
            comboBox.Items.AddRange(new string[]
            {
                "GetOwnerTableData",
                "GetLocationTableData",
                "GetPharmacyTableData",
                "GetMedicineTableData",
                "GetInventoryTableData"
            });
            comboBox.Items.AddRange(new string[] { "ASC", "DESC" });
            comboBox.SelectedIndex = 0;

        }


        private void cbx_tablas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadData(string procedureName, string orderDirection)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConexionSQL.conexioSql))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@OrderDirection", orderDirection);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGridView1.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
