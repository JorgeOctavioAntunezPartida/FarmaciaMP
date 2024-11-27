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
    public partial class frm_medicamento : Form
    {
        public frm_medicamento()
        {
            InitializeComponent();
        }

        SqlConnection Conex = new SqlConnection(ConexionSQL.conexioSql);

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Form inicio = new pantalla_inicio();
            inicio.Show();
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            
        }

        #region Funciones Adicionales

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