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
    public partial class frm_ciudad : Form
    {
        public frm_ciudad()
        {
            InitializeComponent();
        }

        SqlConnection Conex = new SqlConnection(ConexionSQL.conexioSql);

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (btn_eliminar.Text == "Eliminar")
            {
                // ClearRegister(); // Limpia las cajas de texto

                gbx_table.Visible = true;
                btn_guardar.Enabled = false;
                btn_modificar.Enabled = false;
                btn_eliminar.Text = "Cancelar";

                btn_eliminar.BackColor = Color.Gray;
                btn_eliminar.ForeColor = Color.White;
                btn_eliminar.FlatAppearance.BorderColor = Color.White;

                btn_deleteUpdate.Text = "Eliminar";
                btn_deleteUpdate.BackColor = Color.Red;

                // ViewTable();
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

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (btn_modificar.Text == "Modificar")
            {
                // ClearRegister(); // Limpia las cajas de texto

                gbx_table.Visible = true;
                btn_guardar.Enabled = false;
                btn_eliminar.Enabled = false;
                btn_modificar.Text = "Cancelar";

                btn_modificar.BackColor = Color.Gray;
                btn_modificar.ForeColor = Color.White;
                btn_modificar.FlatAppearance.BorderColor = Color.White;

                btn_deleteUpdate.Text = "Modificar";
                btn_deleteUpdate.BackColor = Color.Orange;

                // ViewTable();
            }
            else
            {
                // ClearRegister(); // Limpia las cajas de texto

                btn_modificar.Text = "Modificar";
                gbx_table.Visible = false;
                btn_guardar.Enabled = true;
                btn_eliminar.Enabled = true;

                btn_modificar.BackColor = Color.White;
                btn_modificar.ForeColor = Color.FromArgb(255, 128, 0);
                btn_modificar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            }
        }

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