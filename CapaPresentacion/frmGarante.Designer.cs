namespace CapaPresentacion
{
    partial class frmGarante
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.cboBusquedaGarante = new System.Windows.Forms.ComboBox();
            this.txtBusquedaGarante = new System.Windows.Forms.TextBox();
            this.btnLimpiarGarante = new FontAwesome.Sharp.IconButton();
            this.btnBuscarGarante = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.dgvDataGarante = new System.Windows.Forms.DataGridView();
            this.Boton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdGarante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreGarante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoGarante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeléfonoGarante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MailGarante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionGarante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InquilinoGarante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMailGarante = new System.Windows.Forms.TextBox();
            this.txtTelefonoGarante = new System.Windows.Forms.TextBox();
            this.txtApellidoGarante = new System.Windows.Forms.TextBox();
            this.txtNombreGarante = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDireccionGarante = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboInquilinoGarante = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataGarante)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(154, 32);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(25, 20);
            this.txtIndice.TabIndex = 47;
            this.txtIndice.Text = "0";
            this.txtIndice.Visible = false;
            // 
            // cboBusquedaGarante
            // 
            this.cboBusquedaGarante.FormattingEnabled = true;
            this.cboBusquedaGarante.Location = new System.Drawing.Point(468, 47);
            this.cboBusquedaGarante.Name = "cboBusquedaGarante";
            this.cboBusquedaGarante.Size = new System.Drawing.Size(151, 21);
            this.cboBusquedaGarante.TabIndex = 46;
            // 
            // txtBusquedaGarante
            // 
            this.txtBusquedaGarante.Location = new System.Drawing.Point(637, 47);
            this.txtBusquedaGarante.Name = "txtBusquedaGarante";
            this.txtBusquedaGarante.Size = new System.Drawing.Size(164, 20);
            this.txtBusquedaGarante.TabIndex = 45;
            // 
            // btnLimpiarGarante
            // 
            this.btnLimpiarGarante.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnLimpiarGarante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarGarante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarGarante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarGarante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiarGarante.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarGarante.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnLimpiarGarante.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarGarante.IconSize = 20;
            this.btnLimpiarGarante.Location = new System.Drawing.Point(880, 43);
            this.btnLimpiarGarante.Name = "btnLimpiarGarante";
            this.btnLimpiarGarante.Size = new System.Drawing.Size(45, 24);
            this.btnLimpiarGarante.TabIndex = 44;
            this.btnLimpiarGarante.UseVisualStyleBackColor = false;
            this.btnLimpiarGarante.Click += new System.EventHandler(this.btnLimpiarGarante_Click);
            // 
            // btnBuscarGarante
            // 
            this.btnBuscarGarante.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBuscarGarante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarGarante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarGarante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarGarante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarGarante.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnBuscarGarante.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnBuscarGarante.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarGarante.IconSize = 20;
            this.btnBuscarGarante.Location = new System.Drawing.Point(833, 44);
            this.btnBuscarGarante.Name = "btnBuscarGarante";
            this.btnBuscarGarante.Size = new System.Drawing.Size(41, 24);
            this.btnBuscarGarante.TabIndex = 43;
            this.btnBuscarGarante.UseVisualStyleBackColor = false;
            this.btnBuscarGarante.Click += new System.EventHandler(this.btnBuscarGarante_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(373, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Buscar por...";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(352, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(596, 31);
            this.label8.TabIndex = 41;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(185, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(25, 20);
            this.txtId.TabIndex = 40;
            this.txtId.Text = "0";
            this.txtId.Visible = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(285, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(700, 25);
            this.label7.TabIndex = 39;
            this.label7.Text = "Lista de Garantes";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEliminar.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.Location = new System.Drawing.Point(32, 444);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(174, 28);
            this.btnEliminar.TabIndex = 37;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLimpiar.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.Location = new System.Drawing.Point(31, 410);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(174, 28);
            this.btnLimpiar.TabIndex = 36;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Green;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGuardar.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.Location = new System.Drawing.Point(31, 376);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(174, 28);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // dgvDataGarante
            // 
            this.dgvDataGarante.AllowUserToAddRows = false;
            this.dgvDataGarante.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataGarante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataGarante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataGarante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Boton,
            this.IdGarante,
            this.NombreGarante,
            this.ApellidoGarante,
            this.TeléfonoGarante,
            this.MailGarante,
            this.DireccionGarante,
            this.InquilinoGarante});
            this.dgvDataGarante.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvDataGarante.Location = new System.Drawing.Point(272, 82);
            this.dgvDataGarante.MultiSelect = false;
            this.dgvDataGarante.Name = "dgvDataGarante";
            this.dgvDataGarante.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataGarante.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataGarante.RowTemplate.Height = 28;
            this.dgvDataGarante.Size = new System.Drawing.Size(723, 366);
            this.dgvDataGarante.TabIndex = 38;
            this.dgvDataGarante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataGarante_CellContentClick_1);
            this.dgvDataGarante.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvDataGarante_CellPainting_1);
            // 
            // Boton
            // 
            this.Boton.HeaderText = "";
            this.Boton.Name = "Boton";
            this.Boton.ReadOnly = true;
            this.Boton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Boton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Boton.Width = 30;
            // 
            // IdGarante
            // 
            this.IdGarante.HeaderText = "Id";
            this.IdGarante.Name = "IdGarante";
            this.IdGarante.ReadOnly = true;
            this.IdGarante.Width = 50;
            // 
            // NombreGarante
            // 
            this.NombreGarante.HeaderText = "Nombre";
            this.NombreGarante.Name = "NombreGarante";
            this.NombreGarante.ReadOnly = true;
            // 
            // ApellidoGarante
            // 
            this.ApellidoGarante.HeaderText = "Apellido";
            this.ApellidoGarante.Name = "ApellidoGarante";
            this.ApellidoGarante.ReadOnly = true;
            // 
            // TeléfonoGarante
            // 
            this.TeléfonoGarante.HeaderText = "Teléfono";
            this.TeléfonoGarante.Name = "TeléfonoGarante";
            this.TeléfonoGarante.ReadOnly = true;
            // 
            // MailGarante
            // 
            this.MailGarante.HeaderText = "Mail";
            this.MailGarante.Name = "MailGarante";
            this.MailGarante.ReadOnly = true;
            // 
            // DireccionGarante
            // 
            this.DireccionGarante.HeaderText = "Direccion";
            this.DireccionGarante.Name = "DireccionGarante";
            this.DireccionGarante.ReadOnly = true;
            // 
            // InquilinoGarante
            // 
            this.InquilinoGarante.HeaderText = "Inquilino";
            this.InquilinoGarante.Name = "InquilinoGarante";
            this.InquilinoGarante.ReadOnly = true;
            this.InquilinoGarante.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.InquilinoGarante.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtMailGarante
            // 
            this.txtMailGarante.Location = new System.Drawing.Point(31, 223);
            this.txtMailGarante.Name = "txtMailGarante";
            this.txtMailGarante.Size = new System.Drawing.Size(174, 20);
            this.txtMailGarante.TabIndex = 34;
            // 
            // txtTelefonoGarante
            // 
            this.txtTelefonoGarante.Location = new System.Drawing.Point(31, 171);
            this.txtTelefonoGarante.Name = "txtTelefonoGarante";
            this.txtTelefonoGarante.Size = new System.Drawing.Size(174, 20);
            this.txtTelefonoGarante.TabIndex = 33;
            // 
            // txtApellidoGarante
            // 
            this.txtApellidoGarante.Location = new System.Drawing.Point(31, 116);
            this.txtApellidoGarante.Name = "txtApellidoGarante";
            this.txtApellidoGarante.Size = new System.Drawing.Size(174, 20);
            this.txtApellidoGarante.TabIndex = 32;
            // 
            // txtNombreGarante
            // 
            this.txtNombreGarante.Location = new System.Drawing.Point(31, 65);
            this.txtNombreGarante.Name = "txtNombreGarante";
            this.txtNombreGarante.Size = new System.Drawing.Size(174, 20);
            this.txtNombreGarante.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(28, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Registro Garante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(28, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(28, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(29, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 495);
            this.label1.TabIndex = 25;
            // 
            // txtDireccionGarante
            // 
            this.txtDireccionGarante.Location = new System.Drawing.Point(31, 274);
            this.txtDireccionGarante.Name = "txtDireccionGarante";
            this.txtDireccionGarante.Size = new System.Drawing.Size(174, 20);
            this.txtDireccionGarante.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(28, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 15);
            this.label10.TabIndex = 48;
            this.label10.Text = "Direccion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(28, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 15);
            this.label11.TabIndex = 50;
            this.label11.Text = "Inquilino correspondiente";
            // 
            // cboInquilinoGarante
            // 
            this.cboInquilinoGarante.FormattingEnabled = true;
            this.cboInquilinoGarante.Location = new System.Drawing.Point(32, 329);
            this.cboInquilinoGarante.Name = "cboInquilinoGarante";
            this.cboInquilinoGarante.Size = new System.Drawing.Size(173, 21);
            this.cboInquilinoGarante.TabIndex = 52;
            // 
            // frmGarante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 495);
            this.Controls.Add(this.cboInquilinoGarante);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDireccionGarante);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.cboBusquedaGarante);
            this.Controls.Add(this.txtBusquedaGarante);
            this.Controls.Add(this.btnLimpiarGarante);
            this.Controls.Add(this.btnBuscarGarante);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvDataGarante);
            this.Controls.Add(this.txtMailGarante);
            this.Controls.Add(this.txtTelefonoGarante);
            this.Controls.Add(this.txtApellidoGarante);
            this.Controls.Add(this.txtNombreGarante);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGarante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestorInquilinos";
            this.Load += new System.EventHandler(this.frmGarante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataGarante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.ComboBox cboBusquedaGarante;
        private System.Windows.Forms.TextBox txtBusquedaGarante;
        private FontAwesome.Sharp.IconButton btnLimpiarGarante;
        private FontAwesome.Sharp.IconButton btnBuscarGarante;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.DataGridView dgvDataGarante;
        private System.Windows.Forms.TextBox txtMailGarante;
        private System.Windows.Forms.TextBox txtTelefonoGarante;
        private System.Windows.Forms.TextBox txtApellidoGarante;
        private System.Windows.Forms.TextBox txtNombreGarante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDireccionGarante;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboInquilinoGarante;
        private System.Windows.Forms.DataGridViewButtonColumn Boton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGarante;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreGarante;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoGarante;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeléfonoGarante;
        private System.Windows.Forms.DataGridViewTextBoxColumn MailGarante;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionGarante;
        private System.Windows.Forms.DataGridViewTextBoxColumn InquilinoGarante;
    }
}