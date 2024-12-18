﻿namespace FarmaciaMP
{
    partial class frm_consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_consulta));
            this.btn_inicio = new System.Windows.Forms.Button();
            this.pbx_encavezado = new System.Windows.Forms.PictureBox();
            this.btn_ciudad = new System.Windows.Forms.Button();
            this.btn_medicamento = new System.Windows.Forms.Button();
            this.btn_farmacia = new System.Windows.Forms.Button();
            this.btn_propietario = new System.Windows.Forms.Button();
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.lbl_menu = new System.Windows.Forms.Label();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.cbxOrdenamiento = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_encavezado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.btn_inicio.TabIndex = 37;
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
            this.pbx_encavezado.TabIndex = 38;
            this.pbx_encavezado.TabStop = false;
            // 
            // btn_ciudad
            // 
            this.btn_ciudad.BackColor = System.Drawing.Color.White;
            this.btn_ciudad.BackgroundImage = global::FarmaciaMP.Properties.Resources.icon_ciudad;
            this.btn_ciudad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ciudad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ciudad.FlatAppearance.BorderSize = 2;
            this.btn_ciudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ciudad.Location = new System.Drawing.Point(60, 430);
            this.btn_ciudad.Name = "btn_ciudad";
            this.btn_ciudad.Size = new System.Drawing.Size(60, 60);
            this.btn_ciudad.TabIndex = 35;
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
            this.btn_medicamento.Location = new System.Drawing.Point(60, 364);
            this.btn_medicamento.Name = "btn_medicamento";
            this.btn_medicamento.Size = new System.Drawing.Size(60, 60);
            this.btn_medicamento.TabIndex = 34;
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
            this.btn_farmacia.Location = new System.Drawing.Point(60, 298);
            this.btn_farmacia.Name = "btn_farmacia";
            this.btn_farmacia.Size = new System.Drawing.Size(60, 60);
            this.btn_farmacia.TabIndex = 33;
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
            this.btn_propietario.Location = new System.Drawing.Point(60, 232);
            this.btn_propietario.Name = "btn_propietario";
            this.btn_propietario.Size = new System.Drawing.Size(60, 60);
            this.btn_propietario.TabIndex = 32;
            this.btn_propietario.UseVisualStyleBackColor = false;
            this.btn_propietario.Click += new System.EventHandler(this.btn_propietario_Click);
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla.Location = new System.Drawing.Point(200, 264);
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.Size = new System.Drawing.Size(572, 258);
            this.dgv_tabla.TabIndex = 39;
            // 
            // lbl_menu
            // 
            this.lbl_menu.AutoSize = true;
            this.lbl_menu.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_menu.Location = new System.Drawing.Point(546, 538);
            this.lbl_menu.Name = "lbl_menu";
            this.lbl_menu.Size = new System.Drawing.Size(56, 18);
            this.lbl_menu.TabIndex = 41;
            this.lbl_menu.Text = "Menu";
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_mostrar.FlatAppearance.BorderSize = 2;
            this.btn_mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mostrar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_mostrar.Location = new System.Drawing.Point(672, 542);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(100, 50);
            this.btn_mostrar.TabIndex = 42;
            this.btn_mostrar.Text = "Mostrar";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(209, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 230);
            this.dataGridView1.TabIndex = 43;
            // 
            // comboBox
            // 
            this.comboBox.AllowDrop = true;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(515, 559);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(123, 21);
            this.comboBox.Sorted = true;
            this.comboBox.TabIndex = 44;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // cbxOrdenamiento
            // 
            this.cbxOrdenamiento.AllowDrop = true;
            this.cbxOrdenamiento.FormattingEnabled = true;
            this.cbxOrdenamiento.Items.AddRange(new object[] {
            "Ascendente",
            "Descendete"});
            this.cbxOrdenamiento.Location = new System.Drawing.Point(515, 586);
            this.cbxOrdenamiento.Name = "cbxOrdenamiento";
            this.cbxOrdenamiento.Size = new System.Drawing.Size(123, 21);
            this.cbxOrdenamiento.Sorted = true;
            this.cbxOrdenamiento.TabIndex = 45;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(60, 496);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 46;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_consulta
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 761);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxOrdenamiento);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.lbl_menu);
            this.Controls.Add(this.dgv_tabla);
            this.Controls.Add(this.btn_inicio);
            this.Controls.Add(this.pbx_encavezado);
            this.Controls.Add(this.btn_ciudad);
            this.Controls.Add(this.btn_medicamento);
            this.Controls.Add(this.btn_farmacia);
            this.Controls.Add(this.btn_propietario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.frm_consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_encavezado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.PictureBox pbx_encavezado;
        private System.Windows.Forms.Button btn_ciudad;
        private System.Windows.Forms.Button btn_medicamento;
        private System.Windows.Forms.Button btn_farmacia;
        private System.Windows.Forms.Button btn_propietario;
        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.Label lbl_menu;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.ComboBox comboBox;
        public System.Windows.Forms.ComboBox cbxOrdenamiento;
        private System.Windows.Forms.Button button1;
    }
}