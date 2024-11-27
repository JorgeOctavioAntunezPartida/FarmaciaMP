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
            this.btn_inicio = new System.Windows.Forms.Button();
            this.pbx_encavezado = new System.Windows.Forms.PictureBox();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.btn_ciudad = new System.Windows.Forms.Button();
            this.btn_farmacia = new System.Windows.Forms.Button();
            this.btn_propietario = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txt_medicineName = new System.Windows.Forms.TextBox();
            this.lbl_medicineName = new System.Windows.Forms.Label();
            this.gbx_insert = new System.Windows.Forms.GroupBox();
            this.pbx_icon = new System.Windows.Forms.PictureBox();
            this.gbx_table = new System.Windows.Forms.GroupBox();
            this.btn_deleteUpdate = new System.Windows.Forms.Button();
            this.dgv_ownerTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_encavezado)).BeginInit();
            this.gbx_insert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_icon)).BeginInit();
            this.gbx_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ownerTable)).BeginInit();
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
            this.pbx_encavezado.TabIndex = 24;
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
            this.btn_ciudad.TabIndex = 2;
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
            this.btn_modificar.TabIndex = 9;
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
            this.btn_eliminar.TabIndex = 8;
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
            this.btn_guardar.TabIndex = 7;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txt_medicineName
            // 
            this.txt_medicineName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_medicineName.Location = new System.Drawing.Point(9, 37);
            this.txt_medicineName.MaxLength = 49;
            this.txt_medicineName.Name = "txt_medicineName";
            this.txt_medicineName.Size = new System.Drawing.Size(305, 27);
            this.txt_medicineName.TabIndex = 5;
            // 
            // lbl_medicineName
            // 
            this.lbl_medicineName.AutoSize = true;
            this.lbl_medicineName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_medicineName.Location = new System.Drawing.Point(6, 16);
            this.lbl_medicineName.Name = "lbl_medicineName";
            this.lbl_medicineName.Size = new System.Drawing.Size(125, 18);
            this.lbl_medicineName.TabIndex = 6;
            this.lbl_medicineName.Text = "Medicamento";
            // 
            // gbx_insert
            // 
            this.gbx_insert.Controls.Add(this.pbx_icon);
            this.gbx_insert.Controls.Add(this.lbl_medicineName);
            this.gbx_insert.Controls.Add(this.txt_medicineName);
            this.gbx_insert.Location = new System.Drawing.Point(230, 264);
            this.gbx_insert.Name = "gbx_insert";
            this.gbx_insert.Size = new System.Drawing.Size(320, 280);
            this.gbx_insert.TabIndex = 6;
            this.gbx_insert.TabStop = false;
            // 
            // pbx_icon
            // 
            this.pbx_icon.BackgroundImage = global::FarmaciaMP.Properties.Resources.medicamentoicon;
            this.pbx_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbx_icon.Location = new System.Drawing.Point(9, 70);
            this.pbx_icon.Name = "pbx_icon";
            this.pbx_icon.Size = new System.Drawing.Size(305, 204);
            this.pbx_icon.TabIndex = 7;
            this.pbx_icon.TabStop = false;
            // 
            // gbx_table
            // 
            this.gbx_table.Controls.Add(this.btn_deleteUpdate);
            this.gbx_table.Controls.Add(this.dgv_ownerTable);
            this.gbx_table.Location = new System.Drawing.Point(230, 264);
            this.gbx_table.Name = "gbx_table";
            this.gbx_table.Size = new System.Drawing.Size(320, 280);
            this.gbx_table.TabIndex = 7;
            this.gbx_table.TabStop = false;
            this.gbx_table.Visible = false;
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
            this.btn_deleteUpdate.TabIndex = 20;
            this.btn_deleteUpdate.Text = "...";
            this.btn_deleteUpdate.UseVisualStyleBackColor = false;
            this.btn_deleteUpdate.Click += new System.EventHandler(this.btn_deleteUpdate_Click);
            // 
            // dgv_ownerTable
            // 
            this.dgv_ownerTable.AllowUserToResizeColumns = false;
            this.dgv_ownerTable.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ownerTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ownerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ownerTable.Location = new System.Drawing.Point(6, 18);
            this.dgv_ownerTable.Name = "dgv_ownerTable";
            this.dgv_ownerTable.ReadOnly = true;
            this.dgv_ownerTable.Size = new System.Drawing.Size(308, 198);
            this.dgv_ownerTable.TabIndex = 0;
            // 
            // frm_medicamento
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
            this.Controls.Add(this.btn_ciudad);
            this.Controls.Add(this.btn_farmacia);
            this.Controls.Add(this.btn_propietario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_medicamento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicamentos";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_encavezado)).EndInit();
            this.gbx_insert.ResumeLayout(false);
            this.gbx_insert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_icon)).EndInit();
            this.gbx_table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ownerTable)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txt_medicineName;
        private System.Windows.Forms.Label lbl_medicineName;
        private System.Windows.Forms.GroupBox gbx_insert;
        private System.Windows.Forms.PictureBox pbx_icon;
        private System.Windows.Forms.GroupBox gbx_table;
        private System.Windows.Forms.Button btn_deleteUpdate;
        private System.Windows.Forms.DataGridView dgv_ownerTable;
    }
}