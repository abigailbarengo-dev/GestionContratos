namespace CapaPresentacion
{
    partial class frmContrato
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
            this.cboInquilinoContrato = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.cboBusquedaContrato = new System.Windows.Forms.ComboBox();
            this.txtBusquedaContrato = new System.Windows.Forms.TextBox();
            this.btnLimpiarContrato = new FontAwesome.Sharp.IconButton();
            this.btnBuscarContrato = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.dgvDataContrato = new System.Windows.Forms.DataGridView();
            this.Boton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InquilinoContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.Guardarbtn = new FontAwesome.Sharp.IconButton();
            this.Limpiarbtn = new FontAwesome.Sharp.IconButton();
            this.Eliminarbtn = new FontAwesome.Sharp.IconButton();
            this.txtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.txtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataContrato)).BeginInit();
            this.SuspendLayout();
            // 
            // cboInquilinoContrato
            // 
            this.cboInquilinoContrato.FormattingEnabled = true;
            this.cboInquilinoContrato.Location = new System.Drawing.Point(34, 227);
            this.cboInquilinoContrato.Name = "cboInquilinoContrato";
            this.cboInquilinoContrato.Size = new System.Drawing.Size(173, 21);
            this.cboInquilinoContrato.TabIndex = 79;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(30, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 15);
            this.label11.TabIndex = 78;
            this.label11.Text = "Inquilino correspondiente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(12, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "Registro Contrato de alquiler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(30, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 56;
            this.label4.Text = "Monto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(29, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 55;
            this.label3.Text = "Fecha de finalización";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(30, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 54;
            this.label2.Text = "Fecha de inicio ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 414);
            this.label1.TabIndex = 53;
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(155, 37);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(25, 20);
            this.txtIndice.TabIndex = 75;
            this.txtIndice.Text = "0";
            this.txtIndice.Visible = false;
            // 
            // cboBusquedaContrato
            // 
            this.cboBusquedaContrato.FormattingEnabled = true;
            this.cboBusquedaContrato.Location = new System.Drawing.Point(413, 50);
            this.cboBusquedaContrato.Name = "cboBusquedaContrato";
            this.cboBusquedaContrato.Size = new System.Drawing.Size(151, 21);
            this.cboBusquedaContrato.TabIndex = 74;
            // 
            // txtBusquedaContrato
            // 
            this.txtBusquedaContrato.Location = new System.Drawing.Point(570, 50);
            this.txtBusquedaContrato.Name = "txtBusquedaContrato";
            this.txtBusquedaContrato.Size = new System.Drawing.Size(164, 20);
            this.txtBusquedaContrato.TabIndex = 73;
            // 
            // btnLimpiarContrato
            // 
            this.btnLimpiarContrato.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnLimpiarContrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarContrato.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiarContrato.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarContrato.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnLimpiarContrato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarContrato.IconSize = 20;
            this.btnLimpiarContrato.Location = new System.Drawing.Point(797, 48);
            this.btnLimpiarContrato.Name = "btnLimpiarContrato";
            this.btnLimpiarContrato.Size = new System.Drawing.Size(45, 24);
            this.btnLimpiarContrato.TabIndex = 72;
            this.btnLimpiarContrato.UseVisualStyleBackColor = false;
            this.btnLimpiarContrato.Click += new System.EventHandler(this.btnLimpiarContrato_Click);
            // 
            // btnBuscarContrato
            // 
            this.btnBuscarContrato.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBuscarContrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarContrato.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarContrato.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnBuscarContrato.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnBuscarContrato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarContrato.IconSize = 20;
            this.btnBuscarContrato.Location = new System.Drawing.Point(750, 48);
            this.btnBuscarContrato.Name = "btnBuscarContrato";
            this.btnBuscarContrato.Size = new System.Drawing.Size(41, 24);
            this.btnBuscarContrato.TabIndex = 71;
            this.btnBuscarContrato.UseVisualStyleBackColor = false;
            this.btnBuscarContrato.Click += new System.EventHandler(this.btnBuscarContrato_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(318, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 70;
            this.label9.Text = "Buscar por...";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(302, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(554, 31);
            this.label8.TabIndex = 69;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(186, 37);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(25, 20);
            this.txtId.TabIndex = 68;
            this.txtId.Text = "0";
            this.txtId.Visible = false;
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
            this.btnEliminar.Location = new System.Drawing.Point(33, 449);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(174, 28);
            this.btnEliminar.TabIndex = 65;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
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
            this.btnLimpiar.Location = new System.Drawing.Point(32, 415);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(174, 28);
            this.btnLimpiar.TabIndex = 64;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
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
            this.btnGuardar.Location = new System.Drawing.Point(32, 381);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(174, 28);
            this.btnGuardar.TabIndex = 63;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // dgvDataContrato
            // 
            this.dgvDataContrato.AllowUserToAddRows = false;
            this.dgvDataContrato.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataContrato.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataContrato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Boton,
            this.IdContrato,
            this.FechaInicio,
            this.FechaFin,
            this.MontoContrato,
            this.InquilinoContrato});
            this.dgvDataContrato.Location = new System.Drawing.Point(321, 82);
            this.dgvDataContrato.MultiSelect = false;
            this.dgvDataContrato.Name = "dgvDataContrato";
            this.dgvDataContrato.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataContrato.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataContrato.RowTemplate.Height = 28;
            this.dgvDataContrato.Size = new System.Drawing.Size(524, 320);
            this.dgvDataContrato.TabIndex = 66;
            this.dgvDataContrato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataContrato_CellContentClick);
            this.dgvDataContrato.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvDataContrato_CellPainting);
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
            // IdContrato
            // 
            this.IdContrato.HeaderText = "Id";
            this.IdContrato.Name = "IdContrato";
            this.IdContrato.ReadOnly = true;
            this.IdContrato.Width = 50;
            // 
            // FechaInicio
            // 
            this.FechaInicio.HeaderText = "Fecha de inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            // 
            // FechaFin
            // 
            this.FechaFin.HeaderText = "Fecha de finalizacion";
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            // 
            // MontoContrato
            // 
            this.MontoContrato.HeaderText = "Monto ";
            this.MontoContrato.Name = "MontoContrato";
            this.MontoContrato.ReadOnly = true;
            // 
            // InquilinoContrato
            // 
            this.InquilinoContrato.HeaderText = "Inquilino";
            this.InquilinoContrato.Name = "InquilinoContrato";
            this.InquilinoContrato.ReadOnly = true;
            this.InquilinoContrato.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.InquilinoContrato.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(287, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(578, 25);
            this.label7.TabIndex = 67;
            this.label7.Text = "Lista de Contratos de alquiler";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Guardarbtn
            // 
            this.Guardarbtn.BackColor = System.Drawing.Color.Green;
            this.Guardarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guardarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardarbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Guardarbtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Guardarbtn.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.Guardarbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Guardarbtn.Location = new System.Drawing.Point(32, 272);
            this.Guardarbtn.Name = "Guardarbtn";
            this.Guardarbtn.Size = new System.Drawing.Size(174, 28);
            this.Guardarbtn.TabIndex = 80;
            this.Guardarbtn.Text = "Guardar";
            this.Guardarbtn.UseVisualStyleBackColor = false;
            this.Guardarbtn.Click += new System.EventHandler(this.Guardarbtn_Click);
            // 
            // Limpiarbtn
            // 
            this.Limpiarbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Limpiarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Limpiarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limpiarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiarbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Limpiarbtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Limpiarbtn.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.Limpiarbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Limpiarbtn.Location = new System.Drawing.Point(31, 306);
            this.Limpiarbtn.Name = "Limpiarbtn";
            this.Limpiarbtn.Size = new System.Drawing.Size(174, 28);
            this.Limpiarbtn.TabIndex = 81;
            this.Limpiarbtn.Text = "Limpiar";
            this.Limpiarbtn.UseVisualStyleBackColor = false;
            this.Limpiarbtn.Click += new System.EventHandler(this.Limpiarbtn_Click);
            // 
            // Eliminarbtn
            // 
            this.Eliminarbtn.BackColor = System.Drawing.Color.Red;
            this.Eliminarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Eliminarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminarbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Eliminarbtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Eliminarbtn.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.Eliminarbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Eliminarbtn.Location = new System.Drawing.Point(31, 340);
            this.Eliminarbtn.Name = "Eliminarbtn";
            this.Eliminarbtn.Size = new System.Drawing.Size(174, 28);
            this.Eliminarbtn.TabIndex = 82;
            this.Eliminarbtn.Text = "Eliminar";
            this.Eliminarbtn.UseVisualStyleBackColor = false;
            this.Eliminarbtn.Click += new System.EventHandler(this.Eliminarbtn_Click);
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Location = new System.Drawing.Point(31, 123);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(221, 20);
            this.txtFechaFin.TabIndex = 83;
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Location = new System.Drawing.Point(31, 70);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(221, 20);
            this.txtFechaInicio.TabIndex = 84;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(33, 172);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(174, 20);
            this.txtMonto.TabIndex = 61;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(25, 20);
            this.textBox1.TabIndex = 86;
            this.textBox1.Text = "0";
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(227, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(25, 20);
            this.textBox2.TabIndex = 85;
            this.textBox2.Text = "0";
            this.textBox2.Visible = false;
            // 
            // frmContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 414);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.txtFechaFin);
            this.Controls.Add(this.Eliminarbtn);
            this.Controls.Add(this.Limpiarbtn);
            this.Controls.Add(this.Guardarbtn);
            this.Controls.Add(this.cboInquilinoContrato);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.cboBusquedaContrato);
            this.Controls.Add(this.txtBusquedaContrato);
            this.Controls.Add(this.btnLimpiarContrato);
            this.Controls.Add(this.btnBuscarContrato);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvDataContrato);
            this.Controls.Add(this.label7);
            this.Name = "frmContrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionInquilinos";
            this.Load += new System.EventHandler(this.frmContrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataContrato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboInquilinoContrato;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.ComboBox cboBusquedaContrato;
        private System.Windows.Forms.TextBox txtBusquedaContrato;
        private FontAwesome.Sharp.IconButton btnLimpiarContrato;
        private FontAwesome.Sharp.IconButton btnBuscarContrato;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtId;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.DataGridView dgvDataContrato;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton Guardarbtn;
        private FontAwesome.Sharp.IconButton Limpiarbtn;
        private FontAwesome.Sharp.IconButton Eliminarbtn;
        private System.Windows.Forms.DateTimePicker txtFechaFin;
        private System.Windows.Forms.DateTimePicker txtFechaInicio;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewButtonColumn Boton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn InquilinoContrato;
    }
}