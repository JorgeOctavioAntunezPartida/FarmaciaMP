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
            this.lbl_ownerName = new System.Windows.Forms.Label();
            this.lbl_ownerLastName = new System.Windows.Forms.Label();
            this.lbl_ownerGender = new System.Windows.Forms.Label();
            this.lbl_ownerPhoneNumber = new System.Windows.Forms.Label();
            this.lbl_ownerGmail = new System.Windows.Forms.Label();
            this.txt_ownerName = new System.Windows.Forms.TextBox();
            this.txt_ownerLastName = new System.Windows.Forms.TextBox();
            this.txt_ownerPhoneNumber = new System.Windows.Forms.TextBox();
            this.txt_ownerGmail = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.cbx_ownerGender = new System.Windows.Forms.ComboBox();
            this.gbx_insert = new System.Windows.Forms.GroupBox();
            this.gbx_table = new System.Windows.Forms.GroupBox();
            this.dgv_ownerTable = new System.Windows.Forms.DataGridView();
            this.btn_deleteUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_encavezado)).BeginInit();
            this.gbx_insert.SuspendLayout();
            this.gbx_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ownerTable)).BeginInit();
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
            this.btn_medicamento.TabIndex = 1;
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
            this.btn_farmacia.TabIndex = 0;
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
            this.btn_inicio.TabIndex = 4;
            this.btn_inicio.UseVisualStyleBackColor = false;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // lbl_ownerName
            // 
            this.lbl_ownerName.AutoSize = true;
            this.lbl_ownerName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ownerName.Location = new System.Drawing.Point(6, 16);
            this.lbl_ownerName.Name = "lbl_ownerName";
            this.lbl_ownerName.Size = new System.Drawing.Size(78, 18);
            this.lbl_ownerName.TabIndex = 10;
            this.lbl_ownerName.Text = "Nombre";
            // 
            // lbl_ownerLastName
            // 
            this.lbl_ownerLastName.AutoSize = true;
            this.lbl_ownerLastName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ownerLastName.Location = new System.Drawing.Point(6, 67);
            this.lbl_ownerLastName.Name = "lbl_ownerLastName";
            this.lbl_ownerLastName.Size = new System.Drawing.Size(76, 18);
            this.lbl_ownerLastName.TabIndex = 11;
            this.lbl_ownerLastName.Text = "Apellido";
            // 
            // lbl_ownerGender
            // 
            this.lbl_ownerGender.AutoSize = true;
            this.lbl_ownerGender.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ownerGender.Location = new System.Drawing.Point(11, 118);
            this.lbl_ownerGender.Name = "lbl_ownerGender";
            this.lbl_ownerGender.Size = new System.Drawing.Size(73, 18);
            this.lbl_ownerGender.TabIndex = 12;
            this.lbl_ownerGender.Text = "Género";
            // 
            // lbl_ownerPhoneNumber
            // 
            this.lbl_ownerPhoneNumber.AutoSize = true;
            this.lbl_ownerPhoneNumber.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ownerPhoneNumber.Location = new System.Drawing.Point(6, 168);
            this.lbl_ownerPhoneNumber.Name = "lbl_ownerPhoneNumber";
            this.lbl_ownerPhoneNumber.Size = new System.Drawing.Size(183, 18);
            this.lbl_ownerPhoneNumber.TabIndex = 13;
            this.lbl_ownerPhoneNumber.Text = "Número de teléfono";
            // 
            // lbl_ownerGmail
            // 
            this.lbl_ownerGmail.AutoSize = true;
            this.lbl_ownerGmail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ownerGmail.Location = new System.Drawing.Point(6, 219);
            this.lbl_ownerGmail.Name = "lbl_ownerGmail";
            this.lbl_ownerGmail.Size = new System.Drawing.Size(170, 18);
            this.lbl_ownerGmail.TabIndex = 14;
            this.lbl_ownerGmail.Text = "Correo electrónico";
            // 
            // txt_ownerName
            // 
            this.txt_ownerName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ownerName.Location = new System.Drawing.Point(9, 37);
            this.txt_ownerName.MaxLength = 49;
            this.txt_ownerName.Name = "txt_ownerName";
            this.txt_ownerName.Size = new System.Drawing.Size(300, 27);
            this.txt_ownerName.TabIndex = 5;
            // 
            // txt_ownerLastName
            // 
            this.txt_ownerLastName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ownerLastName.Location = new System.Drawing.Point(9, 88);
            this.txt_ownerLastName.MaxLength = 49;
            this.txt_ownerLastName.Name = "txt_ownerLastName";
            this.txt_ownerLastName.Size = new System.Drawing.Size(300, 27);
            this.txt_ownerLastName.TabIndex = 6;
            // 
            // txt_ownerPhoneNumber
            // 
            this.txt_ownerPhoneNumber.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ownerPhoneNumber.Location = new System.Drawing.Point(9, 189);
            this.txt_ownerPhoneNumber.MaxLength = 19;
            this.txt_ownerPhoneNumber.Name = "txt_ownerPhoneNumber";
            this.txt_ownerPhoneNumber.Size = new System.Drawing.Size(300, 27);
            this.txt_ownerPhoneNumber.TabIndex = 8;
            // 
            // txt_ownerGmail
            // 
            this.txt_ownerGmail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ownerGmail.Location = new System.Drawing.Point(9, 240);
            this.txt_ownerGmail.MaxLength = 127;
            this.txt_ownerGmail.Name = "txt_ownerGmail";
            this.txt_ownerGmail.Size = new System.Drawing.Size(300, 27);
            this.txt_ownerGmail.TabIndex = 9;
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
            this.btn_guardar.TabIndex = 15;
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
            this.btn_eliminar.TabIndex = 16;
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
            this.btn_modificar.TabIndex = 17;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // cbx_ownerGender
            // 
            this.cbx_ownerGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_ownerGender.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_ownerGender.FormattingEnabled = true;
            this.cbx_ownerGender.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.cbx_ownerGender.Location = new System.Drawing.Point(9, 139);
            this.cbx_ownerGender.Name = "cbx_ownerGender";
            this.cbx_ownerGender.Size = new System.Drawing.Size(121, 26);
            this.cbx_ownerGender.TabIndex = 7;
            // 
            // gbx_insert
            // 
            this.gbx_insert.Controls.Add(this.lbl_ownerName);
            this.gbx_insert.Controls.Add(this.cbx_ownerGender);
            this.gbx_insert.Controls.Add(this.lbl_ownerLastName);
            this.gbx_insert.Controls.Add(this.lbl_ownerGender);
            this.gbx_insert.Controls.Add(this.lbl_ownerPhoneNumber);
            this.gbx_insert.Controls.Add(this.lbl_ownerGmail);
            this.gbx_insert.Controls.Add(this.txt_ownerGmail);
            this.gbx_insert.Controls.Add(this.txt_ownerName);
            this.gbx_insert.Controls.Add(this.txt_ownerPhoneNumber);
            this.gbx_insert.Controls.Add(this.txt_ownerLastName);
            this.gbx_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbx_insert.Location = new System.Drawing.Point(230, 264);
            this.gbx_insert.Name = "gbx_insert";
            this.gbx_insert.Size = new System.Drawing.Size(320, 280);
            this.gbx_insert.TabIndex = 18;
            this.gbx_insert.TabStop = false;
            // 
            // gbx_table
            // 
            this.gbx_table.Controls.Add(this.btn_deleteUpdate);
            this.gbx_table.Controls.Add(this.dgv_ownerTable);
            this.gbx_table.Location = new System.Drawing.Point(230, 264);
            this.gbx_table.Name = "gbx_table";
            this.gbx_table.Size = new System.Drawing.Size(320, 280);
            this.gbx_table.TabIndex = 19;
            this.gbx_table.TabStop = false;
            this.gbx_table.Visible = false;
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
            // frm_propietario
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
            this.Controls.Add(this.btn_medicamento);
            this.Controls.Add(this.btn_farmacia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_propietario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Propietarios";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_encavezado)).EndInit();
            this.gbx_insert.ResumeLayout(false);
            this.gbx_insert.PerformLayout();
            this.gbx_table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ownerTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.Button btn_ciudad;
        private System.Windows.Forms.Button btn_medicamento;
        private System.Windows.Forms.Button btn_farmacia;
        private System.Windows.Forms.PictureBox pbx_encavezado;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Label lbl_ownerName;
        private System.Windows.Forms.Label lbl_ownerLastName;
        private System.Windows.Forms.Label lbl_ownerGender;
        private System.Windows.Forms.Label lbl_ownerPhoneNumber;
        private System.Windows.Forms.Label lbl_ownerGmail;
        private System.Windows.Forms.TextBox txt_ownerName;
        private System.Windows.Forms.TextBox txt_ownerLastName;
        private System.Windows.Forms.TextBox txt_ownerPhoneNumber;
        private System.Windows.Forms.TextBox txt_ownerGmail;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.ComboBox cbx_ownerGender;
        private System.Windows.Forms.GroupBox gbx_insert;
        private System.Windows.Forms.GroupBox gbx_table;
        private System.Windows.Forms.DataGridView dgv_ownerTable;
        private System.Windows.Forms.Button btn_deleteUpdate;
    }
}