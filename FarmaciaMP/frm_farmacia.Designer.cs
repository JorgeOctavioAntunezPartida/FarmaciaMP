namespace FarmaciaMP
{
    partial class frm_farmacia
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
            this.btn_ciudad = new System.Windows.Forms.Button();
            this.btn_medicamento = new System.Windows.Forms.Button();
            this.btn_propietario = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.habFarmacia = new System.Windows.Forms.TextBox();
            this.lbl_habFarmcia = new System.Windows.Forms.Label();
            this.estadoFarmacia = new System.Windows.Forms.TextBox();
            this.cdFarmacia = new System.Windows.Forms.TextBox();
            this.direFarmacia = new System.Windows.Forms.TextBox();
            this.idProp = new System.Windows.Forms.TextBox();
            this.idFarmacia = new System.Windows.Forms.TextBox();
            this.lbl_estadoFarmacia = new System.Windows.Forms.Label();
            this.lbl_cdFarmacia = new System.Windows.Forms.Label();
            this.lbl_direFarmacia = new System.Windows.Forms.Label();
            this.lbl_idProp = new System.Windows.Forms.Label();
            this.lbl_idFarmacia = new System.Windows.Forms.Label();
            this.superFarmacia = new System.Windows.Forms.TextBox();
            this.lbl_superFarmacia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_encavezado)).BeginInit();
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
            this.btn_inicio.TabIndex = 16;
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
            this.pbx_encavezado.TabIndex = 17;
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
            this.btn_consulta.TabIndex = 15;
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
            this.btn_ciudad.TabIndex = 14;
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
            this.btn_medicamento.TabIndex = 13;
            this.btn_medicamento.UseVisualStyleBackColor = false;
            this.btn_medicamento.Click += new System.EventHandler(this.btn_medicamento_Click);
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
            this.btn_propietario.TabIndex = 11;
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
            this.btn_modificar.TabIndex = 41;
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
            this.btn_eliminar.TabIndex = 40;
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
            this.btn_guardar.TabIndex = 39;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // habFarmacia
            // 
            this.habFarmacia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habFarmacia.Location = new System.Drawing.Point(200, 540);
            this.habFarmacia.Name = "habFarmacia";
            this.habFarmacia.Size = new System.Drawing.Size(200, 27);
            this.habFarmacia.TabIndex = 37;
            // 
            // lbl_habFarmcia
            // 
            this.lbl_habFarmcia.AutoSize = true;
            this.lbl_habFarmcia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_habFarmcia.Location = new System.Drawing.Point(197, 519);
            this.lbl_habFarmcia.Name = "lbl_habFarmcia";
            this.lbl_habFarmcia.Size = new System.Drawing.Size(320, 18);
            this.lbl_habFarmcia.TabIndex = 36;
            this.lbl_habFarmcia.Text = "Cantidad de habitantes de la ciudad";
            // 
            // estadoFarmacia
            // 
            this.estadoFarmacia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoFarmacia.Location = new System.Drawing.Point(200, 489);
            this.estadoFarmacia.Name = "estadoFarmacia";
            this.estadoFarmacia.Size = new System.Drawing.Size(200, 27);
            this.estadoFarmacia.TabIndex = 35;
            // 
            // cdFarmacia
            // 
            this.cdFarmacia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdFarmacia.Location = new System.Drawing.Point(200, 438);
            this.cdFarmacia.Name = "cdFarmacia";
            this.cdFarmacia.Size = new System.Drawing.Size(200, 27);
            this.cdFarmacia.TabIndex = 34;
            // 
            // direFarmacia
            // 
            this.direFarmacia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direFarmacia.Location = new System.Drawing.Point(200, 387);
            this.direFarmacia.Name = "direFarmacia";
            this.direFarmacia.Size = new System.Drawing.Size(300, 27);
            this.direFarmacia.TabIndex = 33;
            // 
            // idProp
            // 
            this.idProp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProp.Location = new System.Drawing.Point(200, 336);
            this.idProp.Name = "idProp";
            this.idProp.Size = new System.Drawing.Size(300, 27);
            this.idProp.TabIndex = 32;
            // 
            // idFarmacia
            // 
            this.idFarmacia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idFarmacia.Location = new System.Drawing.Point(200, 285);
            this.idFarmacia.Name = "idFarmacia";
            this.idFarmacia.Size = new System.Drawing.Size(300, 27);
            this.idFarmacia.TabIndex = 31;
            // 
            // lbl_estadoFarmacia
            // 
            this.lbl_estadoFarmacia.AutoSize = true;
            this.lbl_estadoFarmacia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estadoFarmacia.Location = new System.Drawing.Point(197, 468);
            this.lbl_estadoFarmacia.Name = "lbl_estadoFarmacia";
            this.lbl_estadoFarmacia.Size = new System.Drawing.Size(68, 18);
            this.lbl_estadoFarmacia.TabIndex = 30;
            this.lbl_estadoFarmacia.Text = "Estado";
            // 
            // lbl_cdFarmacia
            // 
            this.lbl_cdFarmacia.AutoSize = true;
            this.lbl_cdFarmacia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cdFarmacia.Location = new System.Drawing.Point(197, 417);
            this.lbl_cdFarmacia.Name = "lbl_cdFarmacia";
            this.lbl_cdFarmacia.Size = new System.Drawing.Size(156, 18);
            this.lbl_cdFarmacia.TabIndex = 29;
            this.lbl_cdFarmacia.Text = "Ciudad de origen";
            // 
            // lbl_direFarmacia
            // 
            this.lbl_direFarmacia.AutoSize = true;
            this.lbl_direFarmacia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direFarmacia.Location = new System.Drawing.Point(197, 366);
            this.lbl_direFarmacia.Name = "lbl_direFarmacia";
            this.lbl_direFarmacia.Size = new System.Drawing.Size(197, 18);
            this.lbl_direFarmacia.TabIndex = 28;
            this.lbl_direFarmacia.Text = "Dirección de farmacia";
            // 
            // lbl_idProp
            // 
            this.lbl_idProp.AutoSize = true;
            this.lbl_idProp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idProp.Location = new System.Drawing.Point(197, 315);
            this.lbl_idProp.Name = "lbl_idProp";
            this.lbl_idProp.Size = new System.Drawing.Size(132, 18);
            this.lbl_idProp.TabIndex = 27;
            this.lbl_idProp.Text = "ID Propietario";
            // 
            // lbl_idFarmacia
            // 
            this.lbl_idFarmacia.AutoSize = true;
            this.lbl_idFarmacia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idFarmacia.Location = new System.Drawing.Point(197, 264);
            this.lbl_idFarmacia.Name = "lbl_idFarmacia";
            this.lbl_idFarmacia.Size = new System.Drawing.Size(114, 18);
            this.lbl_idFarmacia.TabIndex = 26;
            this.lbl_idFarmacia.Text = "ID Farmacia";
            // 
            // superFarmacia
            // 
            this.superFarmacia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superFarmacia.Location = new System.Drawing.Point(200, 591);
            this.superFarmacia.Name = "superFarmacia";
            this.superFarmacia.Size = new System.Drawing.Size(200, 27);
            this.superFarmacia.TabIndex = 38;
            // 
            // lbl_superFarmacia
            // 
            this.lbl_superFarmacia.AutoSize = true;
            this.lbl_superFarmacia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_superFarmacia.Location = new System.Drawing.Point(197, 570);
            this.lbl_superFarmacia.Name = "lbl_superFarmacia";
            this.lbl_superFarmacia.Size = new System.Drawing.Size(95, 18);
            this.lbl_superFarmacia.TabIndex = 41;
            this.lbl_superFarmacia.Text = "Superficie";
            // 
            // frm_farmacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FarmaciaMP.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.superFarmacia);
            this.Controls.Add(this.lbl_superFarmacia);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.habFarmacia);
            this.Controls.Add(this.lbl_habFarmcia);
            this.Controls.Add(this.estadoFarmacia);
            this.Controls.Add(this.cdFarmacia);
            this.Controls.Add(this.direFarmacia);
            this.Controls.Add(this.idProp);
            this.Controls.Add(this.idFarmacia);
            this.Controls.Add(this.lbl_estadoFarmacia);
            this.Controls.Add(this.lbl_cdFarmacia);
            this.Controls.Add(this.lbl_direFarmacia);
            this.Controls.Add(this.lbl_idProp);
            this.Controls.Add(this.lbl_idFarmacia);
            this.Controls.Add(this.btn_inicio);
            this.Controls.Add(this.pbx_encavezado);
            this.Controls.Add(this.btn_consulta);
            this.Controls.Add(this.btn_ciudad);
            this.Controls.Add(this.btn_medicamento);
            this.Controls.Add(this.btn_propietario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_farmacia";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmacias";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_encavezado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.PictureBox pbx_encavezado;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.Button btn_ciudad;
        private System.Windows.Forms.Button btn_medicamento;
        private System.Windows.Forms.Button btn_propietario;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox habFarmacia;
        private System.Windows.Forms.Label lbl_habFarmcia;
        private System.Windows.Forms.TextBox estadoFarmacia;
        private System.Windows.Forms.TextBox cdFarmacia;
        private System.Windows.Forms.TextBox direFarmacia;
        private System.Windows.Forms.TextBox idProp;
        private System.Windows.Forms.TextBox idFarmacia;
        private System.Windows.Forms.Label lbl_estadoFarmacia;
        private System.Windows.Forms.Label lbl_cdFarmacia;
        private System.Windows.Forms.Label lbl_direFarmacia;
        private System.Windows.Forms.Label lbl_idProp;
        private System.Windows.Forms.Label lbl_idFarmacia;
        private System.Windows.Forms.TextBox superFarmacia;
        private System.Windows.Forms.Label lbl_superFarmacia;
    }
}