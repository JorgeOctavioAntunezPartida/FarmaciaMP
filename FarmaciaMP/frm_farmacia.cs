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
    public partial class frm_farmacia : Form
    {
        public frm_farmacia()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form registro = new Registro();
            registro.Show();
            this.Hide();
        }
    }
}
