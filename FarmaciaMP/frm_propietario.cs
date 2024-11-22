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
using static FarmaciaMP.pantalla_inicio;

namespace FarmaciaMP
{
    public partial class frm_propietario : Form
    {
        public frm_propietario()
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
            Conex.Open();

            string consulta = "INSERT INTO regProp VALUES(" + idProp.Text + ", '" + nombreProp.Text + "', '" + direccionProp.Text + "', '" + cdProp.Text + "', '" + telProp.Text + "', '" + emailProp.Text + "')";

            //se captura los valores en la base de datos
            SqlCommand comando = new SqlCommand(consulta, Conex);
            comando.ExecuteNonQuery();

            //mensaje de socio almancenado
            MessageBox.Show("Nuevo socio: " + nombreProp.Text, "Socio Almacenado", MessageBoxButtons.OK,MessageBoxIcon.Information);

            //se cierra la conexion
            Conex.Close();

            //se limpian los textbox para un nuevo almacenamiento
            idProp.Clear();
            nombreProp.Clear();
            direccionProp.Clear();
            cdProp.Clear();
            telProp.Clear();
            emailProp.Clear();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Conex.Open();

            string baja = "DELETE FROM regProp WHERE idProp =" + idProp.Text;

            SqlCommand cmdInstr = new SqlCommand(baja, Conex);

            cmdInstr.ExecuteNonQuery();

            idProp.Clear();

            Conex.Close();

            MessageBox.Show("", "Socio Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Conex.Open();

            string buscar = "UPDATE regProp SET idProp =" + idProp.Text + ", nombreProp= '" + nombreProp.Text + "', direccionProp='" + direccionProp.Text + "', cdProp='" + cdProp.Text + "', telProp='" + telProp.Text + "', emailProp ='" + emailProp.Text + "' WHERE idProp =" + idProp.Text;

            SqlCommand nuevaBusqueda = new SqlCommand(buscar, Conex);
            int cant;
            cant = nuevaBusqueda.ExecuteNonQuery();

            if (cant > 0)
            {
                MessageBox.Show("Registro Modificado");

            }
            Conex.Close();

            idProp.Clear();
            nombreProp.Clear();
            direccionProp.Clear();
            cdProp.Clear();
            telProp.Clear();
            emailProp.Clear();
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

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            Form consulta = new frm_consulta();
            consulta.Show();
            this.Close();
        }
    }
}