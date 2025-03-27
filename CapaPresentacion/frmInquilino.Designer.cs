namespace CapaPresentacion
{
    partial class frmInquilino
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreInquilino = new System.Windows.Forms.TextBox();
            this.txtApellidoInquilino = new System.Windows.Forms.TextBox();
            this.txtTelefonoInquilino = new System.Windows.Forms.TextBox();
            this.txtDniInquilino = new System.Windows.Forms.TextBox();
            this.dgvDataInquilino = new System.Windows.Forms.DataGridView();
            this.Boton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdInquilino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreInquilino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoInquilino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeléfonoInquilino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DniInquilino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBusquedaInquilino = new System.Windows.Forms.TextBox();
            this.cboBusquedaInquilino = new System.Windows.Forms.ComboBox();
            this.btnLimpiarInquilino = new FontAwesome.Sharp.IconButton();
            this.btnBuscarInquilino = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.txtIndice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataInquilino)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(232, 387);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(25, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(24, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(24, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(23, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Registro Inquilino";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(24, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "DNI";
            // 
            // txtNombreInquilino
            // 
            this.txtNombreInquilino.Location = new System.Drawing.Point(27, 73);
            this.txtNombreInquilino.Name = "txtNombreInquilino";
            this.txtNombreInquilino.Size = new System.Drawing.Size(174, 20);
            this.txtNombreInquilino.TabIndex = 7;
            // 
            // txtApellidoInquilino
            // 
            this.txtApellidoInquilino.Location = new System.Drawing.Point(27, 124);
            this.txtApellidoInquilino.Name = "txtApellidoInquilino";
            this.txtApellidoInquilino.Size = new System.Drawing.Size(174, 20);
            this.txtApellidoInquilino.TabIndex = 8;
            // 
            // txtTelefonoInquilino
            // 
            this.txtTelefonoInquilino.Location = new System.Drawing.Point(27, 179);
            this.txtTelefonoInquilino.Name = "txtTelefonoInquilino";
            this.txtTelefonoInquilino.Size = new System.Drawing.Size(174, 20);
            this.txtTelefonoInquilino.TabIndex = 9;
            // 
            // txtDniInquilino
            // 
            this.txtDniInquilino.Location = new System.Drawing.Point(27, 231);
            this.txtDniInquilino.Name = "txtDniInquilino";
            this.txtDniInquilino.Size = new System.Drawing.Size(174, 20);
            this.txtDniInquilino.TabIndex = 10;
            // 
            // dgvDataInquilino
            // 
            this.dgvDataInquilino.AllowUserToAddRows = false;
            this.dgvDataInquilino.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataInquilino.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataInquilino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataInquilino.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Boton,
            this.IdInquilino,
            this.NombreInquilino,
            this.ApellidoInquilino,
            this.TeléfonoInquilino,
            this.DniInquilino});
            this.dgvDataInquilino.Location = new System.Drawing.Point(260, 84);
            this.dgvDataInquilino.MultiSelect = false;
            this.dgvDataInquilino.Name = "dgvDataInquilino";
            this.dgvDataInquilino.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataInquilino.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataInquilino.RowTemplate.Height = 28;
            this.dgvDataInquilino.Size = new System.Drawing.Size(572, 285);
            this.dgvDataInquilino.TabIndex = 14;
            this.dgvDataInquilino.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataInquilino_CellContentClick);
            this.dgvDataInquilino.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvDataInquilino_CellPainting);
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
            // IdInquilino
            // 
            this.IdInquilino.HeaderText = "Id";
            this.IdInquilino.Name = "IdInquilino";
            this.IdInquilino.ReadOnly = true;
            // 
            // NombreInquilino
            // 
            this.NombreInquilino.HeaderText = "Nombre";
            this.NombreInquilino.Name = "NombreInquilino";
            this.NombreInquilino.ReadOnly = true;
            // 
            // ApellidoInquilino
            // 
            this.ApellidoInquilino.HeaderText = "Apellido";
            this.ApellidoInquilino.Name = "ApellidoInquilino";
            this.ApellidoInquilino.ReadOnly = true;
            // 
            // TeléfonoInquilino
            // 
            this.TeléfonoInquilino.HeaderText = "Teléfono";
            this.TeléfonoInquilino.Name = "TeléfonoInquilino";
            this.TeléfonoInquilino.ReadOnly = true;
            // 
            // DniInquilino
            // 
            this.DniInquilino.HeaderText = "DNI";
            this.DniInquilino.Name = "DniInquilino";
            this.DniInquilino.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(260, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(572, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Lista de Inquilinos";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(197, 38);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(25, 20);
            this.txtId.TabIndex = 16;
            this.txtId.Text = "0";
            this.txtId.Visible = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(260, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(572, 31);
            this.label8.TabIndex = 17;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(271, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Buscar por...";
            // 
            // txtBusquedaInquilino
            // 
            this.txtBusquedaInquilino.Location = new System.Drawing.Point(523, 52);
            this.txtBusquedaInquilino.Name = "txtBusquedaInquilino";
            this.txtBusquedaInquilino.Size = new System.Drawing.Size(164, 20);
            this.txtBusquedaInquilino.TabIndex = 22;
            // 
            // cboBusquedaInquilino
            // 
            this.cboBusquedaInquilino.FormattingEnabled = true;
            this.cboBusquedaInquilino.Location = new System.Drawing.Point(366, 52);
            this.cboBusquedaInquilino.Name = "cboBusquedaInquilino";
            this.cboBusquedaInquilino.Size = new System.Drawing.Size(151, 21);
            this.cboBusquedaInquilino.TabIndex = 23;
            // 
            // btnLimpiarInquilino
            // 
            this.btnLimpiarInquilino.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnLimpiarInquilino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarInquilino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarInquilino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarInquilino.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiarInquilino.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarInquilino.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnLimpiarInquilino.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarInquilino.IconSize = 20;
            this.btnLimpiarInquilino.Location = new System.Drawing.Point(753, 50);
            this.btnLimpiarInquilino.Name = "btnLimpiarInquilino";
            this.btnLimpiarInquilino.Size = new System.Drawing.Size(45, 24);
            this.btnLimpiarInquilino.TabIndex = 21;
            this.btnLimpiarInquilino.UseVisualStyleBackColor = false;
            this.btnLimpiarInquilino.Click += new System.EventHandler(this.btnLimpiarInquilino_Click);
            // 
            // btnBuscarInquilino
            // 
            this.btnBuscarInquilino.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBuscarInquilino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarInquilino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarInquilino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarInquilino.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarInquilino.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnBuscarInquilino.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnBuscarInquilino.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarInquilino.IconSize = 20;
            this.btnBuscarInquilino.Location = new System.Drawing.Point(706, 50);
            this.btnBuscarInquilino.Name = "btnBuscarInquilino";
            this.btnBuscarInquilino.Size = new System.Drawing.Size(41, 24);
            this.btnBuscarInquilino.TabIndex = 20;
            this.btnBuscarInquilino.UseVisualStyleBackColor = false;
            this.btnBuscarInquilino.Click += new System.EventHandler(this.btnBuscarInquilino_Click);
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
            this.btnEliminar.Location = new System.Drawing.Point(28, 336);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(174, 28);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnLimpiar.Location = new System.Drawing.Point(27, 302);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(174, 28);
            this.btnLimpiar.TabIndex = 12;
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
            this.btnGuardar.Location = new System.Drawing.Point(27, 268);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(174, 28);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(166, 38);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(25, 20);
            this.txtIndice.TabIndex = 24;
            this.txtIndice.Text = "0";
            this.txtIndice.Visible = false;
            // 
            // frmInquilino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(857, 387);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.cboBusquedaInquilino);
            this.Controls.Add(this.txtBusquedaInquilino);
            this.Controls.Add(this.btnLimpiarInquilino);
            this.Controls.Add(this.btnBuscarInquilino);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvDataInquilino);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDniInquilino);
            this.Controls.Add(this.txtTelefonoInquilino);
            this.Controls.Add(this.txtApellidoInquilino);
            this.Controls.Add(this.txtNombreInquilino);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmInquilino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestorInquilinos";
            this.Load += new System.EventHandler(this.frmInquilino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataInquilino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreInquilino;
        private System.Windows.Forms.TextBox txtApellidoInquilino;
        private System.Windows.Forms.TextBox txtTelefonoInquilino;
        private System.Windows.Forms.TextBox txtDniInquilino;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private System.Windows.Forms.DataGridView dgvDataInquilino;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnLimpiarInquilino;
        private FontAwesome.Sharp.IconButton btnBuscarInquilino;
        private System.Windows.Forms.TextBox txtBusquedaInquilino;
        private System.Windows.Forms.ComboBox cboBusquedaInquilino;
        private System.Windows.Forms.DataGridViewButtonColumn Boton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInquilino;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreInquilino;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoInquilino;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeléfonoInquilino;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniInquilino;
        private System.Windows.Forms.TextBox txtIndice;
    }
}