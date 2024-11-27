namespace FarmaciaMP
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_inicio = new System.Windows.Forms.Button();
            this.btn_ciudad = new System.Windows.Forms.Button();
            this.btn_medicamento = new System.Windows.Forms.Button();
            this.btn_farmacia = new System.Windows.Forms.Button();
            this.btn_propietario = new System.Windows.Forms.Button();
            this.pbx_encavezado = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.savePharmacy = new System.Windows.Forms.Button();
            this.saveProp = new System.Windows.Forms.Button();
            this.addMedicine = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.propietario = new System.Windows.Forms.TabPage();
            this.txtOwnerEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOwnerPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOwnerGender = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOwnerLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Medicamento = new System.Windows.Forms.TabPage();
            this.guardarFarmacia = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLocationId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOwnerId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPharmacyName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMedicineId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPharmacyId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_encavezado)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.propietario.SuspendLayout();
            this.Medicamento.SuspendLayout();
            this.guardarFarmacia.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.Color.White;
            this.btn_inicio.BackgroundImage = global::FarmaciaMP.Properties.Resources.icon_inicio;
            this.btn_inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_inicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_inicio.FlatAppearance.BorderSize = 2;
            this.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inicio.Location = new System.Drawing.Point(38, 540);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(60, 60);
            this.btn_inicio.TabIndex = 44;
            this.btn_inicio.UseVisualStyleBackColor = false;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // btn_ciudad
            // 
            this.btn_ciudad.BackColor = System.Drawing.Color.White;
            this.btn_ciudad.BackgroundImage = global::FarmaciaMP.Properties.Resources.icon_ciudad;
            this.btn_ciudad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ciudad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ciudad.FlatAppearance.BorderSize = 2;
            this.btn_ciudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ciudad.Location = new System.Drawing.Point(38, 435);
            this.btn_ciudad.Name = "btn_ciudad";
            this.btn_ciudad.Size = new System.Drawing.Size(60, 60);
            this.btn_ciudad.TabIndex = 43;
            this.btn_ciudad.UseVisualStyleBackColor = false;
            this.btn_ciudad.Click += new System.EventHandler(this.btn_ciudad_Click);
            // 
            // btn_medicamento
            // 
            this.btn_medicamento.BackColor = System.Drawing.Color.White;
            this.btn_medicamento.BackgroundImage = global::FarmaciaMP.Properties.Resources.icon_medicamento;
            this.btn_medicamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_medicamento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_medicamento.FlatAppearance.BorderSize = 2;
            this.btn_medicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_medicamento.Location = new System.Drawing.Point(38, 369);
            this.btn_medicamento.Name = "btn_medicamento";
            this.btn_medicamento.Size = new System.Drawing.Size(60, 60);
            this.btn_medicamento.TabIndex = 42;
            this.btn_medicamento.UseVisualStyleBackColor = false;
            this.btn_medicamento.Click += new System.EventHandler(this.btn_medicamento_Click);
            // 
            // btn_farmacia
            // 
            this.btn_farmacia.BackColor = System.Drawing.Color.White;
            this.btn_farmacia.BackgroundImage = global::FarmaciaMP.Properties.Resources.icon_farmacia;
            this.btn_farmacia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_farmacia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_farmacia.FlatAppearance.BorderSize = 2;
            this.btn_farmacia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_farmacia.Location = new System.Drawing.Point(38, 303);
            this.btn_farmacia.Name = "btn_farmacia";
            this.btn_farmacia.Size = new System.Drawing.Size(60, 60);
            this.btn_farmacia.TabIndex = 41;
            this.btn_farmacia.UseVisualStyleBackColor = false;
            this.btn_farmacia.Click += new System.EventHandler(this.btn_farmacia_Click);
            // 
            // btn_propietario
            // 
            this.btn_propietario.BackColor = System.Drawing.Color.White;
            this.btn_propietario.BackgroundImage = global::FarmaciaMP.Properties.Resources.icon_usuario;
            this.btn_propietario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_propietario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_propietario.FlatAppearance.BorderSize = 2;
            this.btn_propietario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_propietario.Location = new System.Drawing.Point(38, 237);
            this.btn_propietario.Name = "btn_propietario";
            this.btn_propietario.Size = new System.Drawing.Size(60, 60);
            this.btn_propietario.TabIndex = 40;
            this.btn_propietario.UseVisualStyleBackColor = false;
            this.btn_propietario.Click += new System.EventHandler(this.btn_propietario_Click);
            // 
            // pbx_encavezado
            // 
            this.pbx_encavezado.BackgroundImage = global::FarmaciaMP.Properties.Resources.encabezado;
            this.pbx_encavezado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbx_encavezado.Location = new System.Drawing.Point(4, 12);
            this.pbx_encavezado.Name = "pbx_encavezado";
            this.pbx_encavezado.Size = new System.Drawing.Size(760, 180);
            this.pbx_encavezado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbx_encavezado.TabIndex = 39;
            this.pbx_encavezado.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(123, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 23);
            this.label1.TabIndex = 45;
            this.label1.Text = "Selecciona los elementos a agregar:";
            // 
            // savePharmacy
            // 
            this.savePharmacy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.savePharmacy.FlatAppearance.BorderSize = 2;
            this.savePharmacy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePharmacy.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePharmacy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.savePharmacy.Location = new System.Drawing.Point(632, 288);
            this.savePharmacy.Name = "savePharmacy";
            this.savePharmacy.Size = new System.Drawing.Size(174, 50);
            this.savePharmacy.TabIndex = 47;
            this.savePharmacy.Text = "Guardar Farmacia";
            this.savePharmacy.UseVisualStyleBackColor = true;
            this.savePharmacy.Click += new System.EventHandler(this.savePharmacy_Click);
            // 
            // saveProp
            // 
            this.saveProp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.saveProp.FlatAppearance.BorderSize = 2;
            this.saveProp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveProp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveProp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.saveProp.Location = new System.Drawing.Point(632, 351);
            this.saveProp.Name = "saveProp";
            this.saveProp.Size = new System.Drawing.Size(174, 50);
            this.saveProp.TabIndex = 48;
            this.saveProp.Text = "Guardar Propietario";
            this.saveProp.UseVisualStyleBackColor = true;
            this.saveProp.Click += new System.EventHandler(this.saveProp_Click);
            // 
            // addMedicine
            // 
            this.addMedicine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addMedicine.FlatAppearance.BorderSize = 2;
            this.addMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMedicine.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMedicine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addMedicine.Location = new System.Drawing.Point(632, 414);
            this.addMedicine.Name = "addMedicine";
            this.addMedicine.Size = new System.Drawing.Size(174, 50);
            this.addMedicine.TabIndex = 49;
            this.addMedicine.Text = "Agregar Medicamento";
            this.addMedicine.UseVisualStyleBackColor = true;
            this.addMedicine.Click += new System.EventHandler(this.addMedicine_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.propietario);
            this.tabControl1.Controls.Add(this.Medicamento);
            this.tabControl1.Controls.Add(this.guardarFarmacia);
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(445, 278);
            this.tabControl1.TabIndex = 50;
            // 
            // propietario
            // 
            this.propietario.Controls.Add(this.txtOwnerEmail);
            this.propietario.Controls.Add(this.label6);
            this.propietario.Controls.Add(this.txtOwnerPhone);
            this.propietario.Controls.Add(this.label5);
            this.propietario.Controls.Add(this.txtOwnerGender);
            this.propietario.Controls.Add(this.label4);
            this.propietario.Controls.Add(this.txtOwnerLastName);
            this.propietario.Controls.Add(this.label3);
            this.propietario.Controls.Add(this.txtOwnerName);
            this.propietario.Controls.Add(this.label2);
            this.propietario.Location = new System.Drawing.Point(4, 25);
            this.propietario.Name = "propietario";
            this.propietario.Padding = new System.Windows.Forms.Padding(3);
            this.propietario.Size = new System.Drawing.Size(437, 249);
            this.propietario.TabIndex = 0;
            this.propietario.Text = "Agregar Propietario";
            this.propietario.UseVisualStyleBackColor = true;
            // 
            // txtOwnerEmail
            // 
            this.txtOwnerEmail.Location = new System.Drawing.Point(119, 159);
            this.txtOwnerEmail.Name = "txtOwnerEmail";
            this.txtOwnerEmail.Size = new System.Drawing.Size(198, 23);
            this.txtOwnerEmail.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Email:";
            // 
            // txtOwnerPhone
            // 
            this.txtOwnerPhone.Location = new System.Drawing.Point(119, 126);
            this.txtOwnerPhone.Name = "txtOwnerPhone";
            this.txtOwnerPhone.Size = new System.Drawing.Size(198, 23);
            this.txtOwnerPhone.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefono:";
            // 
            // txtOwnerGender
            // 
            this.txtOwnerGender.Location = new System.Drawing.Point(119, 90);
            this.txtOwnerGender.Name = "txtOwnerGender";
            this.txtOwnerGender.Size = new System.Drawing.Size(198, 23);
            this.txtOwnerGender.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Genero:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtOwnerLastName
            // 
            this.txtOwnerLastName.Location = new System.Drawing.Point(119, 53);
            this.txtOwnerLastName.Name = "txtOwnerLastName";
            this.txtOwnerLastName.Size = new System.Drawing.Size(198, 23);
            this.txtOwnerLastName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Location = new System.Drawing.Point(119, 11);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(198, 23);
            this.txtOwnerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre(s):";
            // 
            // Medicamento
            // 
            this.Medicamento.Controls.Add(this.txtStock);
            this.Medicamento.Controls.Add(this.label7);
            this.Medicamento.Controls.Add(this.txtMedicineId);
            this.Medicamento.Controls.Add(this.label8);
            this.Medicamento.Controls.Add(this.txtPharmacyId);
            this.Medicamento.Controls.Add(this.label12);
            this.Medicamento.Location = new System.Drawing.Point(4, 25);
            this.Medicamento.Name = "Medicamento";
            this.Medicamento.Padding = new System.Windows.Forms.Padding(3);
            this.Medicamento.Size = new System.Drawing.Size(437, 249);
            this.Medicamento.TabIndex = 1;
            this.Medicamento.Text = "Agregar Medicamento";
            this.Medicamento.UseVisualStyleBackColor = true;
            // 
            // guardarFarmacia
            // 
            this.guardarFarmacia.Controls.Add(this.txtLocationId);
            this.guardarFarmacia.Controls.Add(this.label9);
            this.guardarFarmacia.Controls.Add(this.txtOwnerId);
            this.guardarFarmacia.Controls.Add(this.label10);
            this.guardarFarmacia.Controls.Add(this.txtPharmacyName);
            this.guardarFarmacia.Controls.Add(this.label11);
            this.guardarFarmacia.Location = new System.Drawing.Point(4, 25);
            this.guardarFarmacia.Name = "guardarFarmacia";
            this.guardarFarmacia.Padding = new System.Windows.Forms.Padding(3);
            this.guardarFarmacia.Size = new System.Drawing.Size(437, 249);
            this.guardarFarmacia.TabIndex = 2;
            this.guardarFarmacia.Text = "Guardar Farmacia";
            this.guardarFarmacia.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(114, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 306);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // txtLocationId
            // 
            this.txtLocationId.Location = new System.Drawing.Point(196, 135);
            this.txtLocationId.Name = "txtLocationId";
            this.txtLocationId.Size = new System.Drawing.Size(198, 23);
            this.txtLocationId.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Id Localizacion:";
            // 
            // txtOwnerId
            // 
            this.txtOwnerId.Location = new System.Drawing.Point(196, 98);
            this.txtOwnerId.Name = "txtOwnerId";
            this.txtOwnerId.Size = new System.Drawing.Size(198, 23);
            this.txtOwnerId.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Id Propietario:";
            // 
            // txtPharmacyName
            // 
            this.txtPharmacyName.Location = new System.Drawing.Point(196, 56);
            this.txtPharmacyName.Name = "txtPharmacyName";
            this.txtPharmacyName.Size = new System.Drawing.Size(198, 23);
            this.txtPharmacyName.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Nombre Farmacia:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(194, 128);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(198, 23);
            this.txtStock.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Stock:";
            // 
            // txtMedicineId
            // 
            this.txtMedicineId.Location = new System.Drawing.Point(194, 91);
            this.txtMedicineId.Name = "txtMedicineId";
            this.txtMedicineId.Size = new System.Drawing.Size(198, 23);
            this.txtMedicineId.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Id Medicina:";
            // 
            // txtPharmacyId
            // 
            this.txtPharmacyId.Location = new System.Drawing.Point(194, 49);
            this.txtPharmacyId.Name = "txtPharmacyId";
            this.txtPharmacyId.Size = new System.Drawing.Size(198, 23);
            this.txtPharmacyId.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Id Farmacia:";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(844, 601);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.savePharmacy);
            this.Controls.Add(this.addMedicine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveProp);
            this.Controls.Add(this.btn_inicio);
            this.Controls.Add(this.btn_ciudad);
            this.Controls.Add(this.btn_medicamento);
            this.Controls.Add(this.btn_farmacia);
            this.Controls.Add(this.btn_propietario);
            this.Controls.Add(this.pbx_encavezado);
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_encavezado)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.propietario.ResumeLayout(false);
            this.propietario.PerformLayout();
            this.Medicamento.ResumeLayout(false);
            this.Medicamento.PerformLayout();
            this.guardarFarmacia.ResumeLayout(false);
            this.guardarFarmacia.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_encavezado;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Button btn_ciudad;
        private System.Windows.Forms.Button btn_medicamento;
        private System.Windows.Forms.Button btn_farmacia;
        private System.Windows.Forms.Button btn_propietario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button savePharmacy;
        private System.Windows.Forms.Button saveProp;
        private System.Windows.Forms.Button addMedicine;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage propietario;
        private System.Windows.Forms.TabPage Medicamento;
        private System.Windows.Forms.TabPage guardarFarmacia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOwnerEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOwnerPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOwnerGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOwnerLastName;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.TextBox txtLocationId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOwnerId;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtPharmacyName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMedicineId;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtPharmacyId;
        private System.Windows.Forms.Label label12;
    }
}