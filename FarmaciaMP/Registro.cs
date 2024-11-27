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

namespace FarmaciaMP
{
    public partial class Registro : Form
    {
        private string cadenaConexion = "server=DESKTOP-D739HSR\\WINNEMAN; database=FarmaciasMP; integrated security=true";
        private void limpiarCampos()
        {
            foreach(Control control in this.Controls)
            {
                if(control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }
        public Registro()
        {
            InitializeComponent();
        }

        private void saveProp_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una conexión SQL utilizando la cadena de conexión
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    using (SqlCommand cmd = new SqlCommand("AgregarPropietario", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar parámetros
                        cmd.Parameters.AddWithValue("@ownerName", txtOwnerName.Text);
                        cmd.Parameters.AddWithValue("@ownerLastName", txtOwnerLastName.Text);
                        cmd.Parameters.AddWithValue("@ownerGender", txtOwnerGender.Text);
                        cmd.Parameters.AddWithValue("@ownerPhoneNumber", txtOwnerPhone.Text);
                        cmd.Parameters.AddWithValue("@ownerGmail", txtOwnerEmail.Text);

                        // Abrir conexión
                        conexion.Open();

                        // Ejecutar y obtener el ID generado
                        int newOwnerId = (int)cmd.ExecuteScalar();

                        // Mostrar mensaje de éxito
                        MessageBox.Show($"Propietario agregado correctamente con ID: {newOwnerId}");
                    }
                }
                limpiarCampos();

            }
            catch (Exception ex)
            {
                // Manejar errores
                MessageBox.Show($"Error al guardar el propietario: {ex.Message}");
            }
        }
    

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //BOTON PARA PROCEDIMIENTO DE FARMACIA
        private void savePharmacy_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una conexión SQL utilizando la cadena de conexión
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    using (SqlCommand cmd = new SqlCommand("AgregarFarmacia", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar parámetros
                        cmd.Parameters.AddWithValue("@pharmacyName", txtPharmacyName.Text);
                        cmd.Parameters.AddWithValue("@ownerId", int.Parse(txtOwnerId.Text));
                        cmd.Parameters.AddWithValue("@locationId", int.Parse(txtLocationId.Text));

                        // Abrir conexión
                        conexion.Open();

                        // Ejecutar y obtener el ID generado
                        int newPharmacyId = (int)cmd.ExecuteScalar();

                        MessageBox.Show($"Farmacia agregada correctamente con ID: {newPharmacyId}");
                    }
                }
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la farmacia: {ex.Message}");
            }
        }
        //guardar medicamentos
        private void addMedicine_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    using (SqlCommand cmd = new SqlCommand("AgregarMedicamentoInventario", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar parámetros
                        cmd.Parameters.AddWithValue("@pharmacyId", int.Parse(txtPharmacyId.Text));
                        cmd.Parameters.AddWithValue("@medicineId", int.Parse(txtMedicineId.Text));
                        cmd.Parameters.AddWithValue("@stock", int.Parse(txtStock.Text));

                        // Abrir conexión
                        conexion.Open();

                        // Ejecutar y verificar resultado
                        int operationStatus = (int)cmd.ExecuteScalar();

                        if (operationStatus == 1)
                        {
                            MessageBox.Show("Medicamento agregado o actualizado en el inventario correctamente.");
                        }
                    }
                }
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el medicamento: {ex.Message}");
            }
            
        }

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

        private void btn_ciudad_Click(object sender, EventArgs e)
        {
            Form ciudad = new frm_ciudad();
            ciudad.Show();
            this.Close();
        }
    }
}
