namespace FarmaciaMP
{
    partial class frm_medicamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_medicamento));
            this.btn_inicio = new System.Windows.Forms.Button();
            this.pbx_encavezado = new System.Windows.Forms.PictureBox();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.btn_ciudad = new System.Windows.Forms.Button();
            this.btn_farmacia = new System.Windows.Forms.Button();
            this.btn_propietario = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.descripcionMedi = new System.Windows.Forms.TextBox();
            this.lbl_descripcionMedi = new System.Windows.Forms.Label();
            this.precioMedi = new System.Windows.Forms.TextBox();
            this.similarMedi = new System.Windows.Forms.TextBox();
            this.genericomedi = new System.Windows.Forms.TextBox();
            this.nomComercial = new System.Windows.Forms.TextBox();
            this.idMedi = new System.Windows.Forms.TextBox();
            this.lbl_precioMedi = new System.Windows.Forms.Label();
            this.lbl_similarMedi = new System.Windows.Forms.Label();
            this.lbl_nombreGenerico = new System.Windows.Forms.Label();
            this.lbl_nombreComercial = new System.Windows.Forms.Label();
            this.lbl_idMedi = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_encavezado)).BeginInit();
=======
            this.txt_medicineName = new System.Windows.Forms.TextBox();
            this.lbl_medicineName = new System.Windows.Forms.Label();
            this.gbx_insert = new System.Windows.Forms.GroupBox();
            this.pbx_icon = new System.Windows.Forms.PictureBox();
            this.gbx_table = new System.Windows.Forms.GroupBox();
            this.btn_deleteUpdate = new System.Windows.Forms.Button();
            this.dgv_medicineTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_encavezado)).BeginInit();
            this.gbx_insert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_icon)).BeginInit();
            this.gbx_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_medicineTable)).BeginInit();
>>>>>>> 7223065b07a22dd466f9fe47f698acec8bff7634
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
            this.btn_inicio.TabIndex = 23;
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
            this.pbx_encavezado.TabIndex = 24;
            this.pbx_encavezado.TabStop = false;
            // 
            // btn_consulta
            // 
            this.btn_consulta.BackColor = System.Drawing.Color.White;
            this.btn_consulta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_consulta.BackgroundImage")));
            this.btn_consulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_consulta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_consulta.FlatAppearance.BorderSize = 2;
            this.btn_consulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consulta.Location = new System.Drawing.Point(51, 438);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(60, 60);
            this.btn_consulta.TabIndex = 22;
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
            this.btn_ciudad.Location = new System.Drawing.Point(51, 372);
            this.btn_ciudad.Name = "btn_ciudad";
            this.btn_ciudad.Size = new System.Drawing.Size(60, 60);
            this.btn_ciudad.TabIndex = 21;
            this.btn_ciudad.UseVisualStyleBackColor = false;
            this.btn_ciudad.Click += new System.EventHandler(this.btn_ciudad_Click);
            // 
            // btn_farmacia
            // 
            this.btn_farmacia.BackColor = System.Drawing.Color.White;
            this.btn_farmacia.BackgroundImage = global::FarmaciaMP.Properties.Resources.icon_farmacia;
            this.btn_farmacia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_farmacia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_farmacia.FlatAppearance.BorderSize = 2;
            this.btn_farmacia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_farmacia.Location = new System.Drawing.Point(51, 306);
            this.btn_farmacia.Name = "btn_farmacia";
            this.btn_farmacia.Size = new System.Drawing.Size(60, 60);
            this.btn_farmacia.TabIndex = 19;
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
            this.btn_propietario.Location = new System.Drawing.Point(51, 240);
            this.btn_propietario.Name = "btn_propietario";
            this.btn_propietario.Size = new System.Drawing.Size(60, 60);
            this.btn_propietario.TabIndex = 18;
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
            this.btn_modificar.TabIndex = 40;
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
            this.btn_eliminar.TabIndex = 39;
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
            this.btn_guardar.TabIndex = 38;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // descripcionMedi
            // 
            this.descripcionMedi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionMedi.Location = new System.Drawing.Point(200, 540);
            this.descripcionMedi.Multiline = true;
            this.descripcionMedi.Name = "descripcionMedi";
            this.descripcionMedi.Size = new System.Drawing.Size(200, 100);
            this.descripcionMedi.TabIndex = 37;
            // 
            // lbl_descripcionMedi
            // 
            this.lbl_descripcionMedi.AutoSize = true;
            this.lbl_descripcionMedi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcionMedi.Location = new System.Drawing.Point(197, 519);
            this.lbl_descripcionMedi.Name = "lbl_descripcionMedi";
            this.lbl_descripcionMedi.Size = new System.Drawing.Size(108, 18);
            this.lbl_descripcionMedi.TabIndex = 36;
            this.lbl_descripcionMedi.Text = "Descripción";
            // 
            // precioMedi
            // 
            this.precioMedi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioMedi.Location = new System.Drawing.Point(200, 489);
            this.precioMedi.Name = "precioMedi";
            this.precioMedi.Size = new System.Drawing.Size(200, 27);
            this.precioMedi.TabIndex = 35;
            // 
            // similarMedi
            // 
            this.similarMedi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.similarMedi.Location = new System.Drawing.Point(200, 438);
            this.similarMedi.Name = "similarMedi";
            this.similarMedi.Size = new System.Drawing.Size(300, 27);
            this.similarMedi.TabIndex = 34;
            // 
            // genericomedi
            // 
<<<<<<< HEAD
            this.genericomedi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genericomedi.Location = new System.Drawing.Point(200, 387);
            this.genericomedi.Name = "genericomedi";
            this.genericomedi.Size = new System.Drawing.Size(300, 27);
            this.genericomedi.TabIndex = 33;
=======
            this.gbx_table.Controls.Add(this.btn_deleteUpdate);
            this.gbx_table.Controls.Add(this.dgv_medicineTable);
            this.gbx_table.Location = new System.Drawing.Point(230, 264);
            this.gbx_table.Name = "gbx_table";
            this.gbx_table.Size = new System.Drawing.Size(320, 280);
            this.gbx_table.TabIndex = 7;
            this.gbx_table.TabStop = false;
            this.gbx_table.Visible = false;
>>>>>>> 7223065b07a22dd466f9fe47f698acec8bff7634
            // 
            // nomComercial
            // 
            this.nomComercial.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomComercial.Location = new System.Drawing.Point(200, 336);
            this.nomComercial.Name = "nomComercial";
            this.nomComercial.Size = new System.Drawing.Size(300, 27);
            this.nomComercial.TabIndex = 32;
            // 
<<<<<<< HEAD
            // idMedi
            // 
            this.idMedi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idMedi.Location = new System.Drawing.Point(200, 285);
            this.idMedi.Name = "idMedi";
            this.idMedi.Size = new System.Drawing.Size(200, 27);
            this.idMedi.TabIndex = 31;
            // 
            // lbl_precioMedi
            // 
            this.lbl_precioMedi.AutoSize = true;
            this.lbl_precioMedi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precioMedi.Location = new System.Drawing.Point(197, 468);
            this.lbl_precioMedi.Name = "lbl_precioMedi";
            this.lbl_precioMedi.Size = new System.Drawing.Size(63, 18);
            this.lbl_precioMedi.TabIndex = 30;
            this.lbl_precioMedi.Text = "Precio";
            // 
            // lbl_similarMedi
            // 
            this.lbl_similarMedi.AutoSize = true;
            this.lbl_similarMedi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_similarMedi.Location = new System.Drawing.Point(197, 417);
            this.lbl_similarMedi.Name = "lbl_similarMedi";
            this.lbl_similarMedi.Size = new System.Drawing.Size(215, 18);
            this.lbl_similarMedi.TabIndex = 29;
            this.lbl_similarMedi.Text = "Medicamentos similares";
            // 
            // lbl_nombreGenerico
            // 
            this.lbl_nombreGenerico.AutoSize = true;
            this.lbl_nombreGenerico.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreGenerico.Location = new System.Drawing.Point(197, 366);
            this.lbl_nombreGenerico.Name = "lbl_nombreGenerico";
            this.lbl_nombreGenerico.Size = new System.Drawing.Size(159, 18);
            this.lbl_nombreGenerico.TabIndex = 28;
            this.lbl_nombreGenerico.Text = "Nombre genérico";
            // 
            // lbl_nombreComercial
            // 
            this.lbl_nombreComercial.AutoSize = true;
            this.lbl_nombreComercial.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreComercial.Location = new System.Drawing.Point(197, 315);
            this.lbl_nombreComercial.Name = "lbl_nombreComercial";
            this.lbl_nombreComercial.Size = new System.Drawing.Size(166, 18);
            this.lbl_nombreComercial.TabIndex = 27;
            this.lbl_nombreComercial.Text = "Número comercial";
            // 
            // lbl_idMedi
            // 
            this.lbl_idMedi.AutoSize = true;
            this.lbl_idMedi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idMedi.Location = new System.Drawing.Point(197, 264);
            this.lbl_idMedi.Name = "lbl_idMedi";
            this.lbl_idMedi.Size = new System.Drawing.Size(151, 18);
            this.lbl_idMedi.TabIndex = 26;
            this.lbl_idMedi.Text = "ID Medicamento";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(51, 504);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 41;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
=======
            // dgv_medicineTable
            // 
            this.dgv_medicineTable.AllowUserToResizeColumns = false;
            this.dgv_medicineTable.BackgroundColor = System.Drawing.Color.White;
            this.dgv_medicineTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_medicineTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_medicineTable.Location = new System.Drawing.Point(6, 18);
            this.dgv_medicineTable.Name = "dgv_medicineTable";
            this.dgv_medicineTable.ReadOnly = true;
            this.dgv_medicineTable.Size = new System.Drawing.Size(308, 198);
            this.dgv_medicineTable.TabIndex = 0;
>>>>>>> 7223065b07a22dd466f9fe47f698acec8bff7634
            // 
            // frm_medicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FarmaciaMP.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.descripcionMedi);
            this.Controls.Add(this.lbl_descripcionMedi);
            this.Controls.Add(this.precioMedi);
            this.Controls.Add(this.similarMedi);
            this.Controls.Add(this.genericomedi);
            this.Controls.Add(this.nomComercial);
            this.Controls.Add(this.idMedi);
            this.Controls.Add(this.lbl_precioMedi);
            this.Controls.Add(this.lbl_similarMedi);
            this.Controls.Add(this.lbl_nombreGenerico);
            this.Controls.Add(this.lbl_nombreComercial);
            this.Controls.Add(this.lbl_idMedi);
            this.Controls.Add(this.btn_inicio);
            this.Controls.Add(this.pbx_encavezado);
            this.Controls.Add(this.btn_consulta);
            this.Controls.Add(this.btn_ciudad);
            this.Controls.Add(this.btn_farmacia);
            this.Controls.Add(this.btn_propietario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_medicamento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicamentos";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_encavezado)).EndInit();
<<<<<<< HEAD
=======
            this.gbx_insert.ResumeLayout(false);
            this.gbx_insert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_icon)).EndInit();
            this.gbx_table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_medicineTable)).EndInit();
>>>>>>> 7223065b07a22dd466f9fe47f698acec8bff7634
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.PictureBox pbx_encavezado;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.Button btn_ciudad;
        private System.Windows.Forms.Button btn_farmacia;
        private System.Windows.Forms.Button btn_propietario;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_guardar;
<<<<<<< HEAD
        private System.Windows.Forms.TextBox descripcionMedi;
        private System.Windows.Forms.Label lbl_descripcionMedi;
        private System.Windows.Forms.TextBox precioMedi;
        private System.Windows.Forms.TextBox similarMedi;
        private System.Windows.Forms.TextBox genericomedi;
        private System.Windows.Forms.TextBox nomComercial;
        private System.Windows.Forms.TextBox idMedi;
        private System.Windows.Forms.Label lbl_precioMedi;
        private System.Windows.Forms.Label lbl_similarMedi;
        private System.Windows.Forms.Label lbl_nombreGenerico;
        private System.Windows.Forms.Label lbl_nombreComercial;
        private System.Windows.Forms.Label lbl_idMedi;
        private System.Windows.Forms.Button button1;
=======
        private System.Windows.Forms.TextBox txt_medicineName;
        private System.Windows.Forms.Label lbl_medicineName;
        private System.Windows.Forms.GroupBox gbx_insert;
        private System.Windows.Forms.PictureBox pbx_icon;
        private System.Windows.Forms.GroupBox gbx_table;
        private System.Windows.Forms.Button btn_deleteUpdate;
        private System.Windows.Forms.DataGridView dgv_medicineTable;
>>>>>>> 7223065b07a22dd466f9fe47f698acec8bff7634
    }
}