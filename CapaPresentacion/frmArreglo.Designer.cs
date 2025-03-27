namespace CapaPresentacion
{
    partial class frmArreglo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.eliminarbtn = new FontAwesome.Sharp.IconButton();
            this.limpiarbtn = new FontAwesome.Sharp.IconButton();
            this.guardarbtn = new FontAwesome.Sharp.IconButton();
            this.cboContratoArreglo = new System.Windows.Forms.ComboBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.cboBusquedaArreglo = new System.Windows.Forms.ComboBox();
            this.txtBusquedaArreglo = new System.Windows.Forms.TextBox();
            this.btnLimpiarArreglo = new FontAwesome.Sharp.IconButton();
            this.btnBuscarArreglo = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.dgvDataArreglo = new System.Windows.Forms.DataGridView();
            this.Boton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdArreglo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoArreglo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoArreglo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreInquilino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataArreglo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(29, 80);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(174, 20);
            this.txtTipo.TabIndex = 141;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(25, 20);
            this.textBox1.TabIndex = 140;
            this.textBox1.Text = "0";
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(227, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(25, 20);
            this.textBox2.TabIndex = 139;
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
            this.eliminarbtn.Location = new System.Drawing.Point(28, 316);
            this.eliminarbtn.Name = "eliminarbtn";
            this.eliminarbtn.Size = new System.Drawing.Size(174, 28);
            this.eliminarbtn.TabIndex = 138;
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
            this.limpiarbtn.Location = new System.Drawing.Point(28, 282);
            this.limpiarbtn.Name = "limpiarbtn";
            this.limpiarbtn.Size = new System.Drawing.Size(174, 28);
            this.limpiarbtn.TabIndex = 137;
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
            this.guardarbtn.Location = new System.Drawing.Point(29, 248);
            this.guardarbtn.Name = "guardarbtn";
            this.guardarbtn.Size = new System.Drawing.Size(174, 28);
            this.guardarbtn.TabIndex = 136;
            this.guardarbtn.Text = "Guardar";
            this.guardarbtn.UseVisualStyleBackColor = false;
            this.guardarbtn.Click += new System.EventHandler(this.guardarbtn_Click);
            // 
            // cboContratoArreglo
            // 
            this.cboContratoArreglo.FormattingEnabled = true;
            this.cboContratoArreglo.Location = new System.Drawing.Point(29, 191);
            this.cboContratoArreglo.Name = "cboContratoArreglo";
            this.cboContratoArreglo.Size = new System.Drawing.Size(173, 21);
            this.cboContratoArreglo.TabIndex = 135;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(29, 132);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(174, 20);
            this.txtCosto.TabIndex = 120;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(28, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 15);
            this.label11.TabIndex = 134;
            this.label11.Text = "Inquilino predilecto ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 119;
            this.label5.Text = "Registro Arreglos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(26, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 118;
            this.label4.Text = "Costo de arreglo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(28, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 117;
            this.label2.Text = "Tipo de arreglo";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 450);
            this.label1.TabIndex = 116;
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(155, 30);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(25, 20);
            this.txtIndice.TabIndex = 133;
            this.txtIndice.Text = "0";
            this.txtIndice.Visible = false;
            // 
            // cboBusquedaArreglo
            // 
            this.cboBusquedaArreglo.FormattingEnabled = true;
            this.cboBusquedaArreglo.Location = new System.Drawing.Point(374, 46);
            this.cboBusquedaArreglo.Name = "cboBusquedaArreglo";
            this.cboBusquedaArreglo.Size = new System.Drawing.Size(151, 21);
            this.cboBusquedaArreglo.TabIndex = 132;
            // 
            // txtBusquedaArreglo
            // 
            this.txtBusquedaArreglo.Location = new System.Drawing.Point(531, 47);
            this.txtBusquedaArreglo.Name = "txtBusquedaArreglo";
            this.txtBusquedaArreglo.Size = new System.Drawing.Size(164, 20);
            this.txtBusquedaArreglo.TabIndex = 131;
            // 
            // btnLimpiarArreglo
            // 
            this.btnLimpiarArreglo.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnLimpiarArreglo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarArreglo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarArreglo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarArreglo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiarArreglo.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarArreglo.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnLimpiarArreglo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarArreglo.IconSize = 20;
            this.btnLimpiarArreglo.Location = new System.Drawing.Point(748, 44);
            this.btnLimpiarArreglo.Name = "btnLimpiarArreglo";
            this.btnLimpiarArreglo.Size = new System.Drawing.Size(45, 24);
            this.btnLimpiarArreglo.TabIndex = 130;
            this.btnLimpiarArreglo.UseVisualStyleBackColor = false;
            this.btnLimpiarArreglo.Click += new System.EventHandler(this.btnLimpiarArreglo_Click);
            // 
            // btnBuscarArreglo
            // 
            this.btnBuscarArreglo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBuscarArreglo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarArreglo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarArreglo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarArreglo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarArreglo.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnBuscarArreglo.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnBuscarArreglo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarArreglo.IconSize = 20;
            this.btnBuscarArreglo.Location = new System.Drawing.Point(701, 44);
            this.btnBuscarArreglo.Name = "btnBuscarArreglo";
            this.btnBuscarArreglo.Size = new System.Drawing.Size(41, 24);
            this.btnBuscarArreglo.TabIndex = 129;
            this.btnBuscarArreglo.UseVisualStyleBackColor = false;
            this.btnBuscarArreglo.Click += new System.EventHandler(this.btnBuscarArreglo_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(279, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 128;
            this.label9.Text = "Buscar por...";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(270, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(531, 31);
            this.label8.TabIndex = 127;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(186, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(25, 20);
            this.txtId.TabIndex = 126;
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
            this.btnEliminar.Location = new System.Drawing.Point(33, 442);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(174, 28);
            this.btnEliminar.TabIndex = 123;
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
            this.btnLimpiar.Location = new System.Drawing.Point(32, 408);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(174, 28);
            this.btnLimpiar.TabIndex = 122;
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
            this.btnGuardar.Location = new System.Drawing.Point(32, 374);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(174, 28);
            this.btnGuardar.TabIndex = 121;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // dgvDataArreglo
            // 
            this.dgvDataArreglo.AllowUserToAddRows = false;
            this.dgvDataArreglo.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataArreglo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataArreglo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataArreglo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Boton,
            this.IdArreglo,
            this.TipoArreglo,
            this.CostoArreglo,
            this.NombreInquilino});
            this.dgvDataArreglo.Location = new System.Drawing.Point(339, 84);
            this.dgvDataArreglo.MultiSelect = false;
            this.dgvDataArreglo.Name = "dgvDataArreglo";
            this.dgvDataArreglo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataArreglo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDataArreglo.RowTemplate.Height = 28;
            this.dgvDataArreglo.Size = new System.Drawing.Size(443, 277);
            this.dgvDataArreglo.TabIndex = 124;
            this.dgvDataArreglo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataArreglo_CellContentClick);
            this.dgvDataArreglo.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvDataArreglo_CellPainting);
            // 
            // Boton
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.Boton.DefaultCellStyle = dataGridViewCellStyle2;
            this.Boton.HeaderText = "";
            this.Boton.Name = "Boton";
            this.Boton.ReadOnly = true;
            this.Boton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Boton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Boton.Width = 30;
            // 
            // IdArreglo
            // 
            this.IdArreglo.HeaderText = "Id";
            this.IdArreglo.Name = "IdArreglo";
            this.IdArreglo.ReadOnly = true;
            this.IdArreglo.Width = 50;
            // 
            // TipoArreglo
            // 
            this.TipoArreglo.HeaderText = "Tipo de arreglo";
            this.TipoArreglo.Name = "TipoArreglo";
            this.TipoArreglo.ReadOnly = true;
            // 
            // CostoArreglo
            // 
            this.CostoArreglo.HeaderText = "Costo del arreglo";
            this.CostoArreglo.Name = "CostoArreglo";
            this.CostoArreglo.ReadOnly = true;
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
            this.label7.Location = new System.Drawing.Point(282, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(511, 25);
            this.label7.TabIndex = 125;
            this.label7.Text = "Lista de arreglos";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmArreglo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.eliminarbtn);
            this.Controls.Add(this.limpiarbtn);
            this.Controls.Add(this.guardarbtn);
            this.Controls.Add(this.cboContratoArreglo);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.cboBusquedaArreglo);
            this.Controls.Add(this.txtBusquedaArreglo);
            this.Controls.Add(this.btnLimpiarArreglo);
            this.Controls.Add(this.btnBuscarArreglo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvDataArreglo);
            this.Controls.Add(this.label7);
            this.Name = "frmArreglo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestorInquilinos";
            this.Load += new System.EventHandler(this.frmArreglo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataArreglo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private FontAwesome.Sharp.IconButton eliminarbtn;
        private FontAwesome.Sharp.IconButton limpiarbtn;
        private FontAwesome.Sharp.IconButton guardarbtn;
        private System.Windows.Forms.ComboBox cboContratoArreglo;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.ComboBox cboBusquedaArreglo;
        private System.Windows.Forms.TextBox txtBusquedaArreglo;
        private FontAwesome.Sharp.IconButton btnLimpiarArreglo;
        private FontAwesome.Sharp.IconButton btnBuscarArreglo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtId;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.DataGridView dgvDataArreglo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewButtonColumn Boton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdArreglo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoArreglo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoArreglo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreInquilino;
    }
}