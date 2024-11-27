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

namespace FarmaciaMP
{
    public partial class pantalla_inicio : Form
    {
        public pantalla_inicio()
        {
            InitializeComponent();
        }

        public static class ConexionSQL
        {
            public static readonly string conexioSql = "server= JORGEHAMMERS\\SQLEXPRESS; database= FarmaciasMP; Integrated Security= True";
        }

        private void btn_propietario_Click(object sender, EventArgs e)
        {
            Form propietario = new frm_propietario();
            propietario.Show();
            this.Hide();
        }

        private void btn_farmacia_Click(object sender, EventArgs e)
        {
            Form farmacia = new frm_farmacia();
            farmacia.Show();
            this.Hide();
        }

        private void btn_medicamento_Click(object sender, EventArgs e)
        {
            Form medicamento = new frm_medicamento();
            medicamento.Show();
            this.Hide();
        }

        private void btn_ciudad_Click(object sender, EventArgs e)
        {
            Form ciudad = new frm_ciudad();
            ciudad.Show();
            this.Hide();
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            Form consulta = new frm_consulta();
            consulta.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form registro = new Registro();
            registro.Show();
            this.Hide();
        }
    }
}