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
        private string conexion = "server=DESKTOP-D739HSR\\WINNEMAN; database=FarmaciasMP; integrated security=true";
        //string connectionString = "Server=TU_SERVIDOR;Database=FarmaciasMP;User Id=TU_USUARIO;Password=TU_CONTRASEÑA;";

        //conaatructor
        public frm_consulta()
        {
            InitializeComponent();

            
        }
        //LLADAMA AL METODO LOAD DATA PARA CARGAR EL PROCEDIMIENTO ALMACENADO
        private void loadData(string procedData, string orderDirection)
        {
            try
            {
                //ACCEDIENDO A LA BASE DE DATOS Y CREANDO UNA CONEXION LLAMADA PROCEDIMIENTO
                using (SqlConnection procedimiento = new SqlConnection(conexion))
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
                        dataGridView1.AutoResizeColumns();
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
            if (comboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a procedure.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbxOrdenamiento.SelectedItem == null)
            {
                MessageBox.Show("Please select an order direction.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get selected procedure and order direction
            string procedureName = comboBox.SelectedItem.ToString();
            string orderDirection = cbxOrdenamiento.SelectedItem.ToString();

            // Load data
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
            comboBox.Items.Clear(); // Clear any existing items
            comboBox.Items.AddRange(new string[]
            {
            //PROCEDIMIENTOS ALMACENADOS QUE SE PUEDEN OBSERVAR CON AYUDA DE LOS COMBOBOX
                
                "Farmacias",
                "Medicamentos",
                "Inventario",

            //VISTAS ALMACENADAS QUE CONTIENEN INNER JOIN PARA PODER CARGAR DOS TABLAS LA MISMA CONSULTA
            // Vistas
                "Detalles_Propietarios",
                "Local_Farmacias",
                "propietarios_direcciones",
                "inventario_farmacias",
                "Pharmacy_infoData"

            });

            // Order Direction ComboBox
            cbxOrdenamiento.Items.Clear(); // Clear any existing items
            cbxOrdenamiento.Items.AddRange(new string[] { "ASC", "DESC" });

            // Set default selections
            if (comboBox.Items.Count > 0)
                comboBox.SelectedIndex = 0;

            if (cbxOrdenamiento.Items.Count > 0)
                cbxOrdenamiento.SelectedIndex = 0;
        }


        private void cbx_tablas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadData(string procedureName, string orderDirection)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    conn.Open();
                    // Determinar si es un procedimiento almacenado o una vista
                    string query = procedureName.Contains("_") || procedureName.Contains(" ")
                        ? $"SELECT * FROM {procedureName}"
                        : procedureName;

                    //PROCEDIMIENTO ALMACENADO
                    using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                    {
                        if (!query.StartsWith("SELECT"))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@OrderDirection", orderDirection);
                        }
                        else
                        {
                            // Para vistas, agregar ORDER BY si es necesario
                            if (orderDirection == "Descendente")
                            {
                                query += " ORDER BY 1 DESC";
                            }
                            else
                            {
                                query += " ORDER BY 1 ASC";
                            }
                            cmd.CommandText = query;
                        }
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGridView1.DataSource = table;
                        dataGridView1.AutoResizeColumns();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form registro = new Registro();
            registro.Show();
            this.Hide();
        }
    }
}
