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

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Form inicio = new pantalla_inicio();
            inicio.Show();
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //ABRIENDO CONEXION CON LA BASE DE DAATOS
            Conex.Open();
            string cadena = "INSERT INTO regCiudad (idCiudad, ciudadReg, estadoReg, habReg, superReg) values (" + idCiudad.Text + ", '" + ciudadReg.Text + "', '" + estadoReg.Text + "', " + habReg.Text + ", " + superReg.Text + ")";
            SqlCommand comando = new SqlCommand(cadena, Conex);
            comando.ExecuteNonQuery();

            MessageBox.Show("registro guardado con exito");

            Conex.Close();

            idCiudad.Clear();
            ciudadReg.Clear();
            estadoReg.Clear();
            habReg.Clear();
            superReg.Clear();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Conex.Open();
            string EliminarCd = "DELETE FROM regCiudad WHERE idCiudad = " + idCiudad.Text;

            SqlCommand DeleteCd = new SqlCommand(EliminarCd, Conex);


            DeleteCd.ExecuteNonQuery();

            idCiudad.Clear();
            Conex.Close();
            MessageBox.Show("Registro de Ciudad eliminado correctamente.");
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Conex.Open();
            string consulta = "UPDATE regCiudad SET idCiudad =" + idCiudad.Text + ", ciudadReg ='" + ciudadReg.Text + "', estadoReg = '" + estadoReg.Text + "', habReg ="
                + habReg.Text + ", superReg =" + superReg.Text + "WHERE idCiudad= " + idCiudad.Text;

            SqlCommand comando = new SqlCommand(consulta, Conex);
            int cantidad;
            cantidad = comando.ExecuteNonQuery();

            if (cantidad > 0)
            {
                MessageBox.Show("Registro modificado con exito");
            }

            Conex.Close();

            idCiudad.Clear();
            ciudadReg.Clear();
            estadoReg.Clear();
            habReg.Clear();
            superReg.Clear();
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
    }
}
