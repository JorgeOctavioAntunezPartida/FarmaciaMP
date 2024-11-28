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
            this.txt_pharmacyName = new System.Windows.Forms.TextBox();
            this.lbl_locationId = new System.Windows.Forms.Label();
            this.lbl_ownerId = new System.Windows.Forms.Label();
            this.lbl_pharmacyName = new System.Windows.Forms.Label();
            this.gbx_insert = new System.Windows.Forms.GroupBox();
            this.cbx_locationId = new System.Windows.Forms.ComboBox();
            this.cbx_ownerId = new System.Windows.Forms.ComboBox();
            this.gbx_table = new System.Windows.Forms.GroupBox();
            this.btn_deleteUpdate = new System.Windows.Forms.Button();
            this.dgv_pharmacyTable = new System.Windows.Forms.DataGridView();
            this.btn_stock = new System.Windows.Forms.Button();
            this.gbx_stock = new System.Windows.Forms.GroupBox();
            this.cbx_medicine = new System.Windows.Forms.ComboBox();
            this.cbx_pharmacy = new System.Windows.Forms.ComboBox();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_pharmacy = new System.Windows.Forms.Label();
            this.lbl_medicine = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.btn_loadStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_encavezado)).BeginInit();
            this.gbx_insert.SuspendLayout();
            this.gbx_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pharmacyTable)).BeginInit();
            this.gbx_stock.SuspendLayout();
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
            this.btn_modificar.TabIndex = 7;
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
            this.btn_eliminar.TabIndex = 6;
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
            this.btn_guardar.TabIndex = 5;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txt_pharmacyName
            // 
            this.txt_pharmacyName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pharmacyName.Location = new System.Drawing.Point(9, 37);
            this.txt_pharmacyName.MaxLength = 49;
            this.txt_pharmacyName.Name = "txt_pharmacyName";
            this.txt_pharmacyName.Size = new System.Drawing.Size(300, 27);
            this.txt_pharmacyName.TabIndex = 9;
            // 
            // lbl_locationId
            // 
            this.lbl_locationId.AutoSize = true;
            this.lbl_locationId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_locationId.Location = new System.Drawing.Point(6, 118);
            this.lbl_locationId.Name = "lbl_locationId";
            this.lbl_locationId.Size = new System.Drawing.Size(91, 18);
            this.lbl_locationId.TabIndex = 14;
            this.lbl_locationId.Text = "Ubicación";
            // 
            // lbl_ownerId
            // 
            this.lbl_ownerId.AutoSize = true;
            this.lbl_ownerId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ownerId.Location = new System.Drawing.Point(6, 67);
            this.lbl_ownerId.Name = "lbl_ownerId";
            this.lbl_ownerId.Size = new System.Drawing.Size(106, 18);
            this.lbl_ownerId.TabIndex = 13;
            this.lbl_ownerId.Text = "Propietario";
            // 
            // lbl_pharmacyName
            // 
            this.lbl_pharmacyName.AutoSize = true;
            this.lbl_pharmacyName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pharmacyName.Location = new System.Drawing.Point(6, 16);
            this.lbl_pharmacyName.Name = "lbl_pharmacyName";
            this.lbl_pharmacyName.Size = new System.Drawing.Size(202, 18);
            this.lbl_pharmacyName.TabIndex = 12;
            this.lbl_pharmacyName.Text = "Nombre de la sucursal";
            // 
            // gbx_insert
            // 
            this.gbx_insert.Controls.Add(this.cbx_locationId);
            this.gbx_insert.Controls.Add(this.cbx_ownerId);
            this.gbx_insert.Controls.Add(this.lbl_pharmacyName);
            this.gbx_insert.Controls.Add(this.lbl_ownerId);
            this.gbx_insert.Controls.Add(this.lbl_locationId);
            this.gbx_insert.Controls.Add(this.txt_pharmacyName);
            this.gbx_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbx_insert.Location = new System.Drawing.Point(230, 264);
            this.gbx_insert.Name = "gbx_insert";
            this.gbx_insert.Size = new System.Drawing.Size(320, 280);
            this.gbx_insert.TabIndex = 8;
            this.gbx_insert.TabStop = false;
            // 
            // cbx_locationId
            // 
            this.cbx_locationId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_locationId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_locationId.FormattingEnabled = true;
            this.cbx_locationId.Location = new System.Drawing.Point(9, 139);
            this.cbx_locationId.Name = "cbx_locationId";
            this.cbx_locationId.Size = new System.Drawing.Size(300, 24);
            this.cbx_locationId.TabIndex = 19;
            // 
            // cbx_ownerId
            // 
            this.cbx_ownerId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_ownerId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_ownerId.FormattingEnabled = true;
            this.cbx_ownerId.Location = new System.Drawing.Point(9, 88);
            this.cbx_ownerId.Name = "cbx_ownerId";
            this.cbx_ownerId.Size = new System.Drawing.Size(300, 26);
            this.cbx_ownerId.TabIndex = 18;
            // 
            // gbx_table
            // 
            this.gbx_table.Controls.Add(this.btn_deleteUpdate);
            this.gbx_table.Controls.Add(this.dgv_pharmacyTable);
            this.gbx_table.Location = new System.Drawing.Point(126, 264);
            this.gbx_table.Name = "gbx_table";
            this.gbx_table.Size = new System.Drawing.Size(540, 280);
            this.gbx_table.TabIndex = 20;
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
            // dgv_pharmacyTable
            // 
            this.dgv_pharmacyTable.AllowUserToResizeColumns = false;
            this.dgv_pharmacyTable.BackgroundColor = System.Drawing.Color.White;
            this.dgv_pharmacyTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_pharmacyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pharmacyTable.Location = new System.Drawing.Point(6, 18);
            this.dgv_pharmacyTable.Name = "dgv_pharmacyTable";
            this.dgv_pharmacyTable.ReadOnly = true;
            this.dgv_pharmacyTable.Size = new System.Drawing.Size(528, 198);
            this.dgv_pharmacyTable.TabIndex = 0;
            // 
            // btn_stock
            // 
            this.btn_stock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_stock.FlatAppearance.BorderSize = 2;
            this.btn_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stock.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_stock.Location = new System.Drawing.Point(672, 432);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(100, 50);
            this.btn_stock.TabIndex = 8;
            this.btn_stock.Text = "Stock";
            this.btn_stock.UseVisualStyleBackColor = true;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // gbx_stock
            // 
            this.gbx_stock.Controls.Add(this.btn_loadStock);
            this.gbx_stock.Controls.Add(this.cbx_medicine);
            this.gbx_stock.Controls.Add(this.cbx_pharmacy);
            this.gbx_stock.Controls.Add(this.lbl_stock);
            this.gbx_stock.Controls.Add(this.lbl_pharmacy);
            this.gbx_stock.Controls.Add(this.lbl_medicine);
            this.gbx_stock.Controls.Add(this.txt_stock);
            this.gbx_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbx_stock.Location = new System.Drawing.Point(230, 264);
            this.gbx_stock.Name = "gbx_stock";
            this.gbx_stock.Size = new System.Drawing.Size(320, 280);
            this.gbx_stock.TabIndex = 21;
            this.gbx_stock.TabStop = false;
            this.gbx_stock.Visible = false;
            // 
            // cbx_medicine
            // 
            this.cbx_medicine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_medicine.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_medicine.FormattingEnabled = true;
            this.cbx_medicine.Location = new System.Drawing.Point(9, 88);
            this.cbx_medicine.Name = "cbx_medicine";
            this.cbx_medicine.Size = new System.Drawing.Size(300, 26);
            this.cbx_medicine.TabIndex = 2;
            // 
            // cbx_pharmacy
            // 
            this.cbx_pharmacy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_pharmacy.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_pharmacy.FormattingEnabled = true;
            this.cbx_pharmacy.Location = new System.Drawing.Point(9, 37);
            this.cbx_pharmacy.Name = "cbx_pharmacy";
            this.cbx_pharmacy.Size = new System.Drawing.Size(300, 26);
            this.cbx_pharmacy.TabIndex = 1;
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock.Location = new System.Drawing.Point(6, 118);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(86, 18);
            this.lbl_stock.TabIndex = 12;
            this.lbl_stock.Text = "Cantidad";
            // 
            // lbl_pharmacy
            // 
            this.lbl_pharmacy.AutoSize = true;
            this.lbl_pharmacy.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pharmacy.Location = new System.Drawing.Point(6, 16);
            this.lbl_pharmacy.Name = "lbl_pharmacy";
            this.lbl_pharmacy.Size = new System.Drawing.Size(88, 18);
            this.lbl_pharmacy.TabIndex = 13;
            this.lbl_pharmacy.Text = "Farmacia";
            // 
            // lbl_medicine
            // 
            this.lbl_medicine.AutoSize = true;
            this.lbl_medicine.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_medicine.Location = new System.Drawing.Point(6, 67);
            this.lbl_medicine.Name = "lbl_medicine";
            this.lbl_medicine.Size = new System.Drawing.Size(136, 18);
            this.lbl_medicine.TabIndex = 14;
            this.lbl_medicine.Text = "Mediacamento";
            // 
            // txt_stock
            // 
            this.txt_stock.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock.Location = new System.Drawing.Point(9, 139);
            this.txt_stock.MaxLength = 4;
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(103, 27);
            this.txt_stock.TabIndex = 3;
            // 
            // btn_loadStock
            // 
            this.btn_loadStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_loadStock.FlatAppearance.BorderSize = 2;
            this.btn_loadStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadStock.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadStock.ForeColor = System.Drawing.Color.White;
            this.btn_loadStock.Location = new System.Drawing.Point(214, 222);
            this.btn_loadStock.Name = "btn_loadStock";
            this.btn_loadStock.Size = new System.Drawing.Size(100, 50);
            this.btn_loadStock.TabIndex = 22;
            this.btn_loadStock.Text = "Cargar";
            this.btn_loadStock.UseVisualStyleBackColor = false;
            this.btn_loadStock.Click += new System.EventHandler(this.btn_loadStock_Click);
            // 
            // frm_farmacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FarmaciaMP.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.gbx_stock);
            this.Controls.Add(this.btn_stock);
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
            this.Controls.Add(this.btn_propietario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_farmacia";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmacias";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_encavezado)).EndInit();
            this.gbx_insert.ResumeLayout(false);
            this.gbx_insert.PerformLayout();
            this.gbx_table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pharmacyTable)).EndInit();
            this.gbx_stock.ResumeLayout(false);
            this.gbx_stock.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txt_pharmacyName;
        private System.Windows.Forms.Label lbl_locationId;
        private System.Windows.Forms.Label lbl_ownerId;
        private System.Windows.Forms.Label lbl_pharmacyName;
        private System.Windows.Forms.GroupBox gbx_insert;
        private System.Windows.Forms.ComboBox cbx_ownerId;
        private System.Windows.Forms.ComboBox cbx_locationId;
        private System.Windows.Forms.GroupBox gbx_table;
        private System.Windows.Forms.Button btn_deleteUpdate;
        private System.Windows.Forms.DataGridView dgv_pharmacyTable;
        private System.Windows.Forms.Button btn_stock;
        private System.Windows.Forms.GroupBox gbx_stock;
        private System.Windows.Forms.ComboBox cbx_medicine;
        private System.Windows.Forms.ComboBox cbx_pharmacy;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Label lbl_pharmacy;
        private System.Windows.Forms.Label lbl_medicine;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Button btn_loadStock;
    }
}