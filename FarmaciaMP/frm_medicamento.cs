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
