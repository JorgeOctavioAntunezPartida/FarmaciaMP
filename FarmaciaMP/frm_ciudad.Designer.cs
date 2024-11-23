namespace FarmaciaMP
{
    partial class frm_ciudad
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
            this.pbx_encavezado = new System.Windows.Forms.PictureBox();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.btn_medicamento = new System.Windows.Forms.Button();
            this.btn_farmacia = new System.Windows.Forms.Button();
            this.btn_propietario = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txt_locationCity = new System.Windows.Forms.TextBox();
            this.txt_locationAddress = new System.Windows.Forms.TextBox();
            this.lbl_estadoReg = new System.Windows.Forms.Label();
            this.lbl_ciudadReg = new System.Windows.Forms.Label();
            this.lbl_idCiudad = new System.Windows.Forms.Label();
            this.cbx_locationState = new System.Windows.Forms.ComboBox();
            this.gbx_insert = new System.Windows.Forms.GroupBox();
            this.btn_deleteUpdate = new System.Windows.Forms.Button();
            this.gbx_table = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_encavezado)).BeginInit();
            this.gbx_insert.SuspendLayout();
            this.gbx_table.SuspendLayout();
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
            this.btn_inicio.Location = new System.Drawing.Point(60, 600);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(60, 60);
            this.btn_inicio.TabIndex = 4;
            this.btn_inicio.UseVisualStyleBackColor = false;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // pbx_encavezado
            // 
            this.pbx_encavezado.BackgroundImage = global::FarmaciaMP.Properties.Resources.encabezado;
            this.pbx_encavezado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbx_encavezado.Location = new System.Drawing.Point(12, 12);
            this.pbx_encavezado.Name = "pbx_encavezado";
            this.pbx_encavezado.Size = new System.Drawing.Size(760, 180);
            this.pbx_encavezado.TabIndex = 31;
            this.pbx_encavezado.TabStop = false;
            // 
            // btn_consulta
            // 
            this.btn_consulta.BackColor = System.Drawing.Color.White;
            this.btn_consulta.BackgroundImage = global::FarmaciaMP.Properties.Resources.icon_registro;
            this.btn_consulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_consulta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_consulta.FlatAppearance.BorderSize = 2;
            this.btn_consulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consulta.Location = new System.Drawing.Point(60, 462);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(60, 60);
            this.btn_consulta.TabIndex = 3;
            this.btn_consulta.UseVisualStyleBackColor = false;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // btn_medicamento
            // 
            this.btn_medicamento.BackColor = System.Drawing.Color.White;
            this.btn_medicamento.BackgroundImage = global::FarmaciaMP.Properties.Resources.icon_medicamento;
            this.btn_medicamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_medicamento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_medicamento.FlatAppearance.BorderSize = 2;
            this.btn_medicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_medicamento.Location = new System.Drawing.Point(60, 396);
            this.btn_medicamento.Name = "btn_medicamento";
            this.btn_medicamento.Size = new System.Drawing.Size(60, 60);
            this.btn_medicamento.TabIndex = 2;
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
            this.btn_farmacia.Location = new System.Drawing.Point(60, 330);
            this.btn_farmacia.Name = "btn_farmacia";
            this.btn_farmacia.Size = new System.Drawing.Size(60, 60);
            this.btn_farmacia.TabIndex = 1;
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
            this.btn_propietario.Location = new System.Drawing.Point(60, 264);
            this.btn_propietario.Name = "btn_propietario";
            this.btn_propietario.Size = new System.Drawing.Size(60, 60);
            this.btn_propietario.TabIndex = 0;
            this.btn_propietario.UseVisualStyleBackColor = false;
            this.btn_propietario.Click += new System.EventHandler(this.btn_propietario_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_modificar.FlatAppearance.BorderSize = 2;
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_modificar.Location = new System.Drawing.Point(672, 376);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(100, 50);
            this.btn_modificar.TabIndex = 10;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_eliminar.FlatAppearance.BorderSize = 2;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_eliminar.Location = new System.Drawing.Point(672, 320);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(100, 50);
            this.btn_eliminar.TabIndex = 9;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_guardar.FlatAppearance.BorderSize = 2;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_guardar.Location = new System.Drawing.Point(672, 264);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(100, 50);
            this.btn_guardar.TabIndex = 8;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txt_locationCity
            // 
            this.txt_locationCity.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_locationCity.Location = new System.Drawing.Point(9, 131);
            this.txt_locationCity.MaxLength = 49;
            this.txt_locationCity.Name = "txt_locationCity";
            this.txt_locationCity.Size = new System.Drawing.Size(305, 27);
            this.txt_locationCity.TabIndex = 6;
            // 
            // txt_locationAddress
            // 
            this.txt_locationAddress.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_locationAddress.Location = new System.Drawing.Point(9, 37);
            this.txt_locationAddress.MaxLength = 74;
            this.txt_locationAddress.Multiline = true;
            this.txt_locationAddress.Name = "txt_locationAddress";
            this.txt_locationAddress.Size = new System.Drawing.Size(305, 70);
            this.txt_locationAddress.TabIndex = 5;
            // 
            // lbl_estadoReg
            // 
            this.lbl_estadoReg.AutoSize = true;
            this.lbl_estadoReg.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estadoReg.Location = new System.Drawing.Point(6, 161);
            this.lbl_estadoReg.Name = "lbl_estadoReg";
            this.lbl_estadoReg.Size = new System.Drawing.Size(68, 18);
            this.lbl_estadoReg.TabIndex = 34;
            this.lbl_estadoReg.Text = "Estado";
            // 
            // lbl_ciudadReg
            // 
            this.lbl_ciudadReg.AutoSize = true;
            this.lbl_ciudadReg.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ciudadReg.Location = new System.Drawing.Point(6, 110);
            this.lbl_ciudadReg.Name = "lbl_ciudadReg";
            this.lbl_ciudadReg.Size = new System.Drawing.Size(68, 18);
            this.lbl_ciudadReg.TabIndex = 33;
            this.lbl_ciudadReg.Text = "Ciudad";
            // 
            // lbl_idCiudad
            // 
            this.lbl_idCiudad.AutoSize = true;
            this.lbl_idCiudad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idCiudad.Location = new System.Drawing.Point(6, 16);
            this.lbl_idCiudad.Name = "lbl_idCiudad";
            this.lbl_idCiudad.Size = new System.Drawing.Size(88, 18);
            this.lbl_idCiudad.TabIndex = 32;
            this.lbl_idCiudad.Text = "Dirección";
            // 
            // cbx_locationState
            // 
            this.cbx_locationState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_locationState.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_locationState.FormattingEnabled = true;
            this.cbx_locationState.Items.AddRange(new object[] {
            "Aguascalientes",
            "Baja California",
            "Baja California Sur",
            "Campeche",
            "Chiapas",
            "Chihuahua",
            "Ciudad de México",
            "Coahuila",
            "Colima",
            "Durango",
            "Guanajuato",
            "Guerrero",
            "Hidalgo",
            "Jalisco",
            "México (Estado de México)",
            "Michoacán",
            "Morelos",
            "Nayarit",
            "Nuevo León",
            "Oaxaca",
            "Puebla",
            "Querétaro",
            "Quintana Roo",
            "San Luis Potosí",
            "Sinaloa",
            "Sonora",
            "Tabasco",
            "Tamaulipas",
            "Tlaxcala",
            "Veracruz",
            "Yucatán",
            "Zacatecas"});
            this.cbx_locationState.Location = new System.Drawing.Point(9, 182);
            this.cbx_locationState.Name = "cbx_locationState";
            this.cbx_locationState.Size = new System.Drawing.Size(305, 26);
            this.cbx_locationState.TabIndex = 7;
            // 
            // gbx_insert
            // 
            this.gbx_insert.Controls.Add(this.lbl_idCiudad);
            this.gbx_insert.Controls.Add(this.cbx_locationState);
            this.gbx_insert.Controls.Add(this.lbl_ciudadReg);
            this.gbx_insert.Controls.Add(this.lbl_estadoReg);
            this.gbx_insert.Controls.Add(this.txt_locationAddress);
            this.gbx_insert.Controls.Add(this.txt_locationCity);
            this.gbx_insert.Location = new System.Drawing.Point(230, 264);
            this.gbx_insert.Name = "gbx_insert";
            this.gbx_insert.Size = new System.Drawing.Size(320, 280);
            this.gbx_insert.TabIndex = 11;
            this.gbx_insert.TabStop = false;
            // 
            // btn_deleteUpdate
            // 
            this.btn_deleteUpdate.BackColor = System.Drawing.Color.Gray;
            this.btn_deleteUpdate.FlatAppearance.BorderSize = 2;
            this.btn_deleteUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteUpdate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteUpdate.ForeColor = System.Drawing.Color.White;
            this.btn_deleteUpdate.Location = new System.Drawing.Point(6, 224);
            this.btn_deleteUpdate.Name = "btn_deleteUpdate";
            this.btn_deleteUpdate.Size = new System.Drawing.Size(100, 50);
            this.btn_deleteUpdate.TabIndex = 37;
            this.btn_deleteUpdate.Text = "...";
            this.btn_deleteUpdate.UseVisualStyleBackColor = false;
            // 
            // gbx_table
            // 
            this.gbx_table.Controls.Add(this.btn_deleteUpdate);
            this.gbx_table.Location = new System.Drawing.Point(230, 264);
            this.gbx_table.Name = "gbx_table";
            this.gbx_table.Size = new System.Drawing.Size(320, 280);
            this.gbx_table.TabIndex = 12;
            this.gbx_table.TabStop = false;
            this.gbx_table.Visible = false;
            // 
            // frm_ciudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FarmaciaMP.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.gbx_table);
            this.Controls.Add(this.gbx_insert);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_inicio);
            this.Controls.Add(this.pbx_encavezado);
            this.Controls.Add(this.btn_consulta);
            this.Controls.Add(this.btn_medicamento);
            this.Controls.Add(this.btn_farmacia);
            this.Controls.Add(this.btn_propietario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_ciudad";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ciudades";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_encavezado)).EndInit();
            this.gbx_insert.ResumeLayout(false);
            this.gbx_insert.PerformLayout();
            this.gbx_table.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.PictureBox pbx_encavezado;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.Button btn_medicamento;
        private System.Windows.Forms.Button btn_farmacia;
        private System.Windows.Forms.Button btn_propietario;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txt_locationCity;
        private System.Windows.Forms.TextBox txt_locationAddress;
        private System.Windows.Forms.Label lbl_estadoReg;
        private System.Windows.Forms.Label lbl_ciudadReg;
        private System.Windows.Forms.Label lbl_idCiudad;
        private System.Windows.Forms.ComboBox cbx_locationState;
        private System.Windows.Forms.GroupBox gbx_insert;
        private System.Windows.Forms.Button btn_deleteUpdate;
        private System.Windows.Forms.GroupBox gbx_table;
    }
}