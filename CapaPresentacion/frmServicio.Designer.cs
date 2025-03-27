namespace CapaPresentacion
{
    partial class frmServicio
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.eliminarbtn = new FontAwesome.Sharp.IconButton();
            this.limpiarbtn = new FontAwesome.Sharp.IconButton();
            this.guardarbtn = new FontAwesome.Sharp.IconButton();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.cboBusquedaServicio = new System.Windows.Forms.ComboBox();
            this.txtBusquedaServicio = new System.Windows.Forms.TextBox();
            this.btnLimpiarServicio = new FontAwesome.Sharp.IconButton();
            this.btnBuscarServicio = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.dgvDataServicio = new System.Windows.Forms.DataGridView();
            this.Boton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreInquilino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboContratoServicio = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(25, 20);
            this.textBox1.TabIndex = 114;
            this.textBox1.Text = "0";
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(227, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(25, 20);
            this.textBox2.TabIndex = 113;
            this.textBox2.Text = "0";
            this.textBox2.Visible = false;
            // 
            // eliminarbtn
            // 
            this.eliminarbtn.BackColor = System.Drawing.Color.Red;
            this.eliminarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eliminarbtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.eliminarbtn.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.eliminarbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.eliminarbtn.Location = new System.Drawing.Point(28, 318);
            this.eliminarbtn.Name = "eliminarbtn";
            this.eliminarbtn.Size = new System.Drawing.Size(174, 28);
            this.eliminarbtn.TabIndex = 110;
            this.eliminarbtn.Text = "Eliminar";
            this.eliminarbtn.UseVisualStyleBackColor = false;
            this.eliminarbtn.Click += new System.EventHandler(this.eliminarbtn_Click);
            // 
            // limpiarbtn
            // 
            this.limpiarbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.limpiarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limpiarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.limpiarbtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.limpiarbtn.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.limpiarbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.limpiarbtn.Location = new System.Drawing.Point(28, 284);
            this.limpiarbtn.Name = "limpiarbtn";
            this.limpiarbtn.Size = new System.Drawing.Size(174, 28);
            this.limpiarbtn.TabIndex = 109;
            this.limpiarbtn.Text = "Limpiar";
            this.limpiarbtn.UseVisualStyleBackColor = false;
            this.limpiarbtn.Click += new System.EventHandler(this.limpiarbtn_Click);
            // 
            // guardarbtn
            // 
            this.guardarbtn.BackColor = System.Drawing.Color.Green;
            this.guardarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guardarbtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.guardarbtn.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.guardarbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.guardarbtn.Location = new System.Drawing.Point(29, 250);
            this.guardarbtn.Name = "guardarbtn";
            this.guardarbtn.Size = new System.Drawing.Size(174, 28);
            this.guardarbtn.TabIndex = 108;
            this.guardarbtn.Text = "Guardar";
            this.guardarbtn.UseVisualStyleBackColor = false;
            this.guardarbtn.Click += new System.EventHandler(this.guardarbtn_Click);
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(29, 134);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(174, 20);
            this.txtCosto.TabIndex = 92;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(12, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 91;
            this.label5.Text = "Registro Servicios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(26, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 90;
            this.label4.Text = "Costo de servicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(28, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 88;
            this.label2.Text = "Tipo de servicio";
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
            this.label1.Size = new System.Drawing.Size(264, 412);
            this.label1.TabIndex = 87;
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(155, 32);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(25, 20);
            this.txtIndice.TabIndex = 105;
            this.txtIndice.Text = "0";
            this.txtIndice.Visible = false;
            // 
            // cboBusquedaServicio
            // 
            this.cboBusquedaServicio.FormattingEnabled = true;
            this.cboBusquedaServicio.Location = new System.Drawing.Point(397, 44);
            this.cboBusquedaServicio.Name = "cboBusquedaServicio";
            this.cboBusquedaServicio.Size = new System.Drawing.Size(151, 21);
            this.cboBusquedaServicio.TabIndex = 104;
            // 
            // txtBusquedaServicio
            // 
            this.txtBusquedaServicio.Location = new System.Drawing.Point(568, 45);
            this.txtBusquedaServicio.Name = "txtBusquedaServicio";
            this.txtBusquedaServicio.Size = new System.Drawing.Size(164, 20);
            this.txtBusquedaServicio.TabIndex = 103;
            // 
            // btnLimpiarServicio
            // 
            this.btnLimpiarServicio.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnLimpiarServicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarServicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiarServicio.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarServicio.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnLimpiarServicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarServicio.IconSize = 20;
            this.btnLimpiarServicio.Location = new System.Drawing.Point(800, 42);
            this.btnLimpiarServicio.Name = "btnLimpiarServicio";
            this.btnLimpiarServicio.Size = new System.Drawing.Size(45, 24);
            this.btnLimpiarServicio.TabIndex = 102;
            this.btnLimpiarServicio.UseVisualStyleBackColor = false;
            this.btnLimpiarServicio.Click += new System.EventHandler(this.btnLimpiarServicio_Click);
            // 
            // btnBuscarServicio
            // 
            this.btnBuscarServicio.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBuscarServicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarServicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarServicio.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnBuscarServicio.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnBuscarServicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarServicio.IconSize = 20;
            this.btnBuscarServicio.Location = new System.Drawing.Point(753, 42);
            this.btnBuscarServicio.Name = "btnBuscarServicio";
            this.btnBuscarServicio.Size = new System.Drawing.Size(41, 24);
            this.btnBuscarServicio.TabIndex = 101;
            this.btnBuscarServicio.UseVisualStyleBackColor = false;
            this.btnBuscarServicio.Click += new System.EventHandler(this.btnBuscarServicio_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(302, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 100;
            this.label9.Text = "Buscar por...";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(288, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(578, 31);
            this.label8.TabIndex = 99;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(186, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(25, 20);
            this.txtId.TabIndex = 98;
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
            this.btnEliminar.Location = new System.Drawing.Point(33, 444);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(174, 28);
            this.btnEliminar.TabIndex = 95;
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
            this.btnLimpiar.Location = new System.Drawing.Point(32, 410);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(174, 28);
            this.btnLimpiar.TabIndex = 94;
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
            this.btnGuardar.Location = new System.Drawing.Point(32, 376);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(174, 28);
            this.btnGuardar.TabIndex = 93;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // dgvDataServicio
            // 
            this.dgvDataServicio.AllowUserToAddRows = false;
            this.dgvDataServicio.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataServicio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataServicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Boton,
            this.IdServicio,
            this.TipoServicio,
            this.CostoServicio,
            this.NombreInquilino});
            this.dgvDataServicio.Location = new System.Drawing.Point(379, 86);
            this.dgvDataServicio.MultiSelect = false;
            this.dgvDataServicio.Name = "dgvDataServicio";
            this.dgvDataServicio.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataServicio.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataServicio.RowTemplate.Height = 28;
            this.dgvDataServicio.Size = new System.Drawing.Size(441, 318);
            this.dgvDataServicio.TabIndex = 96;
            this.dgvDataServicio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataServicio_CellContentClick);
            this.dgvDataServicio.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvDataServicio_CellPainting);
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
            // IdServicio
            // 
            this.IdServicio.HeaderText = "Id";
            this.IdServicio.Name = "IdServicio";
            this.IdServicio.ReadOnly = true;
            this.IdServicio.Width = 50;
            // 
            // TipoServicio
            // 
            this.TipoServicio.HeaderText = "Tipo de servicio";
            this.TipoServicio.Name = "TipoServicio";
            this.TipoServicio.ReadOnly = true;
            // 
            // CostoServicio
            // 
            this.CostoServicio.HeaderText = "Costo del servicio";
            this.CostoServicio.Name = "CostoServicio";
            this.CostoServicio.ReadOnly = true;
            // 
            // NombreInquilino
            // 
            this.NombreInquilino.HeaderText = "Inquilino";
            this.NombreInquilino.Name = "NombreInquilino";
            this.NombreInquilino.ReadOnly = true;
            this.NombreInquilino.Width = 120;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(288, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(578, 25);
            this.label7.TabIndex = 97;
            this.label7.Text = "Lista de servicios";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(29, 82);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(174, 20);
            this.txtTipo.TabIndex = 115;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(28, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 15);
            this.label11.TabIndex = 106;
            this.label11.Text = "Inquilino predilecto";
            // 
            // cboContratoServicio
            // 
            this.cboContratoServicio.FormattingEnabled = true;
            this.cboContratoServicio.Location = new System.Drawing.Point(29, 193);
            this.cboContratoServicio.Name = "cboContratoServicio";
            this.cboContratoServicio.Size = new System.Drawing.Size(173, 21);
            this.cboContratoServicio.TabIndex = 107;
            // 
            // frmServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 412);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.eliminarbtn);
            this.Controls.Add(this.limpiarbtn);
            this.Controls.Add(this.guardarbtn);
            this.Controls.Add(this.cboContratoServicio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.cboBusquedaServicio);
            this.Controls.Add(this.txtBusquedaServicio);
            this.Controls.Add(this.btnLimpiarServicio);
            this.Controls.Add(this.btnBuscarServicio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvDataServicio);
            this.Controls.Add(this.label7);
            this.Name = "frmServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestorInquilinos";
            this.Load += new System.EventHandler(this.frmServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataServicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private FontAwesome.Sharp.IconButton eliminarbtn;
        private FontAwesome.Sharp.IconButton limpiarbtn;
        private FontAwesome.Sharp.IconButton guardarbtn;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.ComboBox cboBusquedaServicio;
        private System.Windows.Forms.TextBox txtBusquedaServicio;
        private FontAwesome.Sharp.IconButton btnLimpiarServicio;
        private FontAwesome.Sharp.IconButton btnBuscarServicio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtId;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.DataGridView dgvDataServicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboContratoServicio;
        private System.Windows.Forms.DataGridViewButtonColumn Boton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreInquilino;
    }
}