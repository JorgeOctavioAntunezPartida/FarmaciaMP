namespace FarmaciaMP
{
    partial class frm_propietario
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
            this.btn_consulta = new System.Windows.Forms.Button();
            this.btn_ciudad = new System.Windows.Forms.Button();
            this.btn_medicamento = new System.Windows.Forms.Button();
            this.btn_farmacia = new System.Windows.Forms.Button();
            this.pbx_encavezado = new System.Windows.Forms.PictureBox();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.lbl_idProp = new System.Windows.Forms.Label();
            this.lbl_nombreProp = new System.Windows.Forms.Label();
            this.lbl_direccionProp = new System.Windows.Forms.Label();
            this.lbl_cdProp = new System.Windows.Forms.Label();
            this.lbl_telProp = new System.Windows.Forms.Label();
            this.idProp = new System.Windows.Forms.TextBox();
            this.nombreProp = new System.Windows.Forms.TextBox();
            this.direccionProp = new System.Windows.Forms.TextBox();
            this.cdProp = new System.Windows.Forms.TextBox();
            this.telProp = new System.Windows.Forms.TextBox();
            this.lbl_emailProp = new System.Windows.Forms.Label();
            this.emailProp = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_encavezado)).BeginInit();
            this.SuspendLayout();
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
            this.btn_consulta.TabIndex = 9;
            this.btn_consulta.UseVisualStyleBackColor = false;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // btn_ciudad
            // 
            this.btn_ciudad.BackColor = System.Drawing.Color.White;
            this.btn_ciudad.BackgroundImage = global::FarmaciaMP.Properties.Resources.icon_ciudad;
            this.btn_ciudad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ciudad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ciudad.FlatAppearance.BorderSize = 2;
            this.btn_ciudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ciudad.Location = new System.Drawing.Point(60, 396);
            this.btn_ciudad.Name = "btn_ciudad";
            this.btn_ciudad.Size = new System.Drawing.Size(60, 60);
            this.btn_ciudad.TabIndex = 8;
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
            this.btn_medicamento.Location = new System.Drawing.Point(60, 330);
            this.btn_medicamento.Name = "btn_medicamento";
            this.btn_medicamento.Size = new System.Drawing.Size(60, 60);
            this.btn_medicamento.TabIndex = 7;
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
            this.btn_farmacia.Location = new System.Drawing.Point(60, 264);
            this.btn_farmacia.Name = "btn_farmacia";
            this.btn_farmacia.Size = new System.Drawing.Size(60, 60);
            this.btn_farmacia.TabIndex = 6;
            this.btn_farmacia.UseVisualStyleBackColor = false;
            this.btn_farmacia.Click += new System.EventHandler(this.btn_farmacia_Click);
            // 
            // pbx_encavezado
            // 
            this.pbx_encavezado.BackgroundImage = global::FarmaciaMP.Properties.Resources.encabezado;
            this.pbx_encavezado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbx_encavezado.Location = new System.Drawing.Point(12, 12);
            this.pbx_encavezado.Name = "pbx_encavezado";
            this.pbx_encavezado.Size = new System.Drawing.Size(760, 180);
            this.pbx_encavezado.TabIndex = 10;
            this.pbx_encavezado.TabStop = false;
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
            this.btn_inicio.TabIndex = 10;
            this.btn_inicio.UseVisualStyleBackColor = false;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // lbl_idProp
            // 
            this.lbl_idProp.AutoSize = true;
            this.lbl_idProp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idProp.Location = new System.Drawing.Point(197, 264);
            this.lbl_idProp.Name = "lbl_idProp";
            this.lbl_idProp.Size = new System.Drawing.Size(141, 18);
            this.lbl_idProp.TabIndex = 11;
            this.lbl_idProp.Text = "No. Propietario";
            // 
            // lbl_nombreProp
            // 
            this.lbl_nombreProp.AutoSize = true;
            this.lbl_nombreProp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreProp.Location = new System.Drawing.Point(197, 315);
            this.lbl_nombreProp.Name = "lbl_nombreProp";
            this.lbl_nombreProp.Size = new System.Drawing.Size(212, 18);
            this.lbl_nombreProp.TabIndex = 12;
            this.lbl_nombreProp.Text = "Nombre del Propietario";
            // 
            // lbl_direccionProp
            // 
            this.lbl_direccionProp.AutoSize = true;
            this.lbl_direccionProp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccionProp.Location = new System.Drawing.Point(197, 366);
            this.lbl_direccionProp.Name = "lbl_direccionProp";
            this.lbl_direccionProp.Size = new System.Drawing.Size(88, 18);
            this.lbl_direccionProp.TabIndex = 13;
            this.lbl_direccionProp.Text = "Dirección";
            // 
            // lbl_cdProp
            // 
            this.lbl_cdProp.AutoSize = true;
            this.lbl_cdProp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cdProp.Location = new System.Drawing.Point(197, 417);
            this.lbl_cdProp.Name = "lbl_cdProp";
            this.lbl_cdProp.Size = new System.Drawing.Size(68, 18);
            this.lbl_cdProp.TabIndex = 14;
            this.lbl_cdProp.Text = "Ciudad";
            // 
            // lbl_telProp
            // 
            this.lbl_telProp.AutoSize = true;
            this.lbl_telProp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telProp.Location = new System.Drawing.Point(197, 468);
            this.lbl_telProp.Name = "lbl_telProp";
            this.lbl_telProp.Size = new System.Drawing.Size(86, 18);
            this.lbl_telProp.TabIndex = 15;
            this.lbl_telProp.Text = "Teléfono";
            // 
            // idProp
            // 
            this.idProp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProp.Location = new System.Drawing.Point(200, 285);
            this.idProp.Name = "idProp";
            this.idProp.Size = new System.Drawing.Size(300, 27);
            this.idProp.TabIndex = 16;
            // 
            // nombreProp
            // 
            this.nombreProp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreProp.Location = new System.Drawing.Point(200, 336);
            this.nombreProp.Name = "nombreProp";
            this.nombreProp.Size = new System.Drawing.Size(300, 27);
            this.nombreProp.TabIndex = 17;
            // 
            // direccionProp
            // 
            this.direccionProp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionProp.Location = new System.Drawing.Point(200, 387);
            this.direccionProp.Name = "direccionProp";
            this.direccionProp.Size = new System.Drawing.Size(300, 27);
            this.direccionProp.TabIndex = 18;
            // 
            // cdProp
            // 
            this.cdProp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdProp.Location = new System.Drawing.Point(200, 438);
            this.cdProp.Name = "cdProp";
            this.cdProp.Size = new System.Drawing.Size(200, 27);
            this.cdProp.TabIndex = 19;
            // 
            // telProp
            // 
            this.telProp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telProp.Location = new System.Drawing.Point(200, 489);
            this.telProp.Name = "telProp";
            this.telProp.Size = new System.Drawing.Size(200, 27);
            this.telProp.TabIndex = 20;
            // 
            // lbl_emailProp
            // 
            this.lbl_emailProp.AutoSize = true;
            this.lbl_emailProp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emailProp.Location = new System.Drawing.Point(197, 519);
            this.lbl_emailProp.Name = "lbl_emailProp";
            this.lbl_emailProp.Size = new System.Drawing.Size(54, 18);
            this.lbl_emailProp.TabIndex = 21;
            this.lbl_emailProp.Text = "Email";
            // 
            // emailProp
            // 
            this.emailProp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailProp.Location = new System.Drawing.Point(200, 540);
            this.emailProp.Name = "emailProp";
            this.emailProp.Size = new System.Drawing.Size(200, 27);
            this.emailProp.TabIndex = 22;
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
            this.btn_guardar.TabIndex = 23;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
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
            this.btn_eliminar.TabIndex = 24;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
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
            this.btn_modificar.TabIndex = 25;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // frm_propietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FarmaciaMP.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.emailProp);
            this.Controls.Add(this.lbl_emailProp);
            this.Controls.Add(this.telProp);
            this.Controls.Add(this.cdProp);
            this.Controls.Add(this.direccionProp);
            this.Controls.Add(this.nombreProp);
            this.Controls.Add(this.idProp);
            this.Controls.Add(this.lbl_telProp);
            this.Controls.Add(this.lbl_cdProp);
            this.Controls.Add(this.lbl_direccionProp);
            this.Controls.Add(this.lbl_nombreProp);
            this.Controls.Add(this.lbl_idProp);
            this.Controls.Add(this.btn_inicio);
            this.Controls.Add(this.pbx_encavezado);
            this.Controls.Add(this.btn_consulta);
            this.Controls.Add(this.btn_ciudad);
            this.Controls.Add(this.btn_medicamento);
            this.Controls.Add(this.btn_farmacia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_propietario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Propietarios";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_encavezado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.Button btn_ciudad;
        private System.Windows.Forms.Button btn_medicamento;
        private System.Windows.Forms.Button btn_farmacia;
        private System.Windows.Forms.PictureBox pbx_encavezado;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Label lbl_idProp;
        private System.Windows.Forms.Label lbl_nombreProp;
        private System.Windows.Forms.Label lbl_direccionProp;
        private System.Windows.Forms.Label lbl_cdProp;
        private System.Windows.Forms.Label lbl_telProp;
        private System.Windows.Forms.TextBox idProp;
        private System.Windows.Forms.TextBox nombreProp;
        private System.Windows.Forms.TextBox direccionProp;
        private System.Windows.Forms.TextBox cdProp;
        private System.Windows.Forms.TextBox telProp;
        private System.Windows.Forms.Label lbl_emailProp;
        private System.Windows.Forms.TextBox emailProp;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
    }
}