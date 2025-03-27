namespace CapaPresentacion
{
    partial class frmDetalleInquilino
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
            this.btnPdf = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboReporteInquilino = new System.Windows.Forms.ComboBox();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtExpensas = new System.Windows.Forms.TextBox();
            this.ReporteAlquiler = new System.Windows.Forms.GroupBox();
            this.dgvReporte1 = new System.Windows.Forms.DataGridView();
            this.Boton1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nombreInquilino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gastoAlquiler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar1 = new System.Windows.Forms.Button();
            this.txtMontoAlquiler = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMontoArreglos = new System.Windows.Forms.TextBox();
            this.txtMontoServicios = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboReporteTipoArreglo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboTipoServicio = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregar3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDetalles = new System.Windows.Forms.RichTextBox();
            this.dgvReporte3 = new System.Windows.Forms.DataGridView();
            this.Boton3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gastoExpensas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gastoComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvReporte2 = new System.Windows.Forms.DataGridView();
            this.Boton2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tipoArreglo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gastoArreglos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gastoServicios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar2 = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.ReporteAlquiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPdf.Location = new System.Drawing.Point(572, 407);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(153, 31);
            this.btnPdf.TabIndex = 1;
            this.btnPdf.Text = "Descargar en PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inquilino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Comisión %";
            // 
            // cboReporteInquilino
            // 
            this.cboReporteInquilino.FormattingEnabled = true;
            this.cboReporteInquilino.Location = new System.Drawing.Point(25, 32);
            this.cboReporteInquilino.Name = "cboReporteInquilino";
            this.cboReporteInquilino.Size = new System.Drawing.Size(97, 21);
            this.cboReporteInquilino.TabIndex = 9;
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(10, 32);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(84, 20);
            this.txtPorcentaje.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Expensas";
            // 
            // txtExpensas
            // 
            this.txtExpensas.Location = new System.Drawing.Point(10, 72);
            this.txtExpensas.Name = "txtExpensas";
            this.txtExpensas.Size = new System.Drawing.Size(84, 20);
            this.txtExpensas.TabIndex = 12;
            // 
            // ReporteAlquiler
            // 
            this.ReporteAlquiler.Controls.Add(this.dgvReporte1);
            this.ReporteAlquiler.Controls.Add(this.btnAgregar1);
            this.ReporteAlquiler.Controls.Add(this.txtMontoAlquiler);
            this.ReporteAlquiler.Controls.Add(this.label4);
            this.ReporteAlquiler.Controls.Add(this.label2);
            this.ReporteAlquiler.Controls.Add(this.cboReporteInquilino);
            this.ReporteAlquiler.Location = new System.Drawing.Point(12, 12);
            this.ReporteAlquiler.Name = "ReporteAlquiler";
            this.ReporteAlquiler.Size = new System.Drawing.Size(304, 239);
            this.ReporteAlquiler.TabIndex = 15;
            this.ReporteAlquiler.TabStop = false;
            this.ReporteAlquiler.Text = "Información Inquilino";
            // 
            // dgvReporte1
            // 
            this.dgvReporte1.AllowUserToAddRows = false;
            this.dgvReporte1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvReporte1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Boton1,
            this.nombreInquilino,
            this.gastoAlquiler});
            this.dgvReporte1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvReporte1.Location = new System.Drawing.Point(10, 98);
            this.dgvReporte1.MultiSelect = false;
            this.dgvReporte1.Name = "dgvReporte1";
            this.dgvReporte1.Size = new System.Drawing.Size(278, 135);
            this.dgvReporte1.TabIndex = 18;
            this.dgvReporte1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvReporte1_CellPainting);
            // 
            // Boton1
            // 
            this.Boton1.HeaderText = "";
            this.Boton1.Name = "Boton1";
            this.Boton1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Boton1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Boton1.UseColumnTextForButtonValue = true;
            this.Boton1.Width = 35;
            // 
            // nombreInquilino
            // 
            this.nombreInquilino.HeaderText = "Nombre ";
            this.nombreInquilino.Name = "nombreInquilino";
            // 
            // gastoAlquiler
            // 
            this.gastoAlquiler.HeaderText = "Costo alquiler";
            this.gastoAlquiler.Name = "gastoAlquiler";
            // 
            // btnAgregar1
            // 
            this.btnAgregar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregar1.Location = new System.Drawing.Point(157, 47);
            this.btnAgregar1.Name = "btnAgregar1";
            this.btnAgregar1.Size = new System.Drawing.Size(80, 31);
            this.btnAgregar1.TabIndex = 24;
            this.btnAgregar1.Text = "Agregar";
            this.btnAgregar1.UseVisualStyleBackColor = false;
            this.btnAgregar1.Click += new System.EventHandler(this.btnAgregar1_Click);
            // 
            // txtMontoAlquiler
            // 
            this.txtMontoAlquiler.Location = new System.Drawing.Point(25, 72);
            this.txtMontoAlquiler.Name = "txtMontoAlquiler";
            this.txtMontoAlquiler.Size = new System.Drawing.Size(97, 20);
            this.txtMontoAlquiler.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Alquiler";
            // 
            // txtMontoArreglos
            // 
            this.txtMontoArreglos.Location = new System.Drawing.Point(10, 72);
            this.txtMontoArreglos.Name = "txtMontoArreglos";
            this.txtMontoArreglos.Size = new System.Drawing.Size(96, 20);
            this.txtMontoArreglos.TabIndex = 20;
            // 
            // txtMontoServicios
            // 
            this.txtMontoServicios.Location = new System.Drawing.Point(119, 72);
            this.txtMontoServicios.Name = "txtMontoServicios";
            this.txtMontoServicios.Size = new System.Drawing.Size(97, 20);
            this.txtMontoServicios.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tipo de Arreglo";
            // 
            // cboReporteTipoArreglo
            // 
            this.cboReporteTipoArreglo.FormattingEnabled = true;
            this.cboReporteTipoArreglo.Location = new System.Drawing.Point(9, 32);
            this.cboReporteTipoArreglo.Name = "cboReporteTipoArreglo";
            this.cboReporteTipoArreglo.Size = new System.Drawing.Size(97, 21);
            this.cboReporteTipoArreglo.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tipo de Servicio";
            // 
            // cboTipoServicio
            // 
            this.cboTipoServicio.FormattingEnabled = true;
            this.cboTipoServicio.Location = new System.Drawing.Point(119, 32);
            this.cboTipoServicio.Name = "cboTipoServicio";
            this.cboTipoServicio.Size = new System.Drawing.Size(97, 21);
            this.cboTipoServicio.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Monto Servicios ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Monto Arreglos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregar3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dgvReporte3);
            this.groupBox2.Controls.Add(this.txtPorcentaje);
            this.groupBox2.Controls.Add(this.txtExpensas);
            this.groupBox2.Location = new System.Drawing.Point(322, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 239);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Otros";
            // 
            // btnAgregar3
            // 
            this.btnAgregar3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregar3.Location = new System.Drawing.Point(327, 38);
            this.btnAgregar3.Name = "btnAgregar3";
            this.btnAgregar3.Size = new System.Drawing.Size(80, 31);
            this.btnAgregar3.TabIndex = 25;
            this.btnAgregar3.Text = "Agregar";
            this.btnAgregar3.UseVisualStyleBackColor = false;
            this.btnAgregar3.Click += new System.EventHandler(this.btnAgregar3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDetalles);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(100, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 76);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles";
            // 
            // txtDetalles
            // 
            this.txtDetalles.Location = new System.Drawing.Point(6, 15);
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(208, 55);
            this.txtDetalles.TabIndex = 18;
            this.txtDetalles.Text = "";
            // 
            // dgvReporte3
            // 
            this.dgvReporte3.AllowUserToAddRows = false;
            this.dgvReporte3.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvReporte3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Boton3,
            this.gastoExpensas,
            this.gastoComision,
            this.Detalles});
            this.dgvReporte3.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvReporte3.Location = new System.Drawing.Point(25, 98);
            this.dgvReporte3.MultiSelect = false;
            this.dgvReporte3.Name = "dgvReporte3";
            this.dgvReporte3.Size = new System.Drawing.Size(378, 135);
            this.dgvReporte3.TabIndex = 18;
            this.dgvReporte3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReporte3_CellContentClick);
            this.dgvReporte3.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvReporte3_CellPainting);
            // 
            // Boton3
            // 
            this.Boton3.HeaderText = "";
            this.Boton3.Name = "Boton3";
            this.Boton3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Boton3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Boton3.UseColumnTextForButtonValue = true;
            this.Boton3.Width = 35;
            // 
            // gastoExpensas
            // 
            this.gastoExpensas.HeaderText = "Expensas: luz y agua bomba";
            this.gastoExpensas.Name = "gastoExpensas";
            // 
            // gastoComision
            // 
            this.gastoComision.HeaderText = "Costo comisión";
            this.gastoComision.Name = "gastoComision";
            // 
            // Detalles
            // 
            this.Detalles.HeaderText = "Detalles";
            this.Detalles.Name = "Detalles";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvReporte2);
            this.groupBox3.Controls.Add(this.btnAgregar2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtMontoArreglos);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtMontoServicios);
            this.groupBox3.Controls.Add(this.cboReporteTipoArreglo);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cboTipoServicio);
            this.groupBox3.Location = new System.Drawing.Point(12, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(514, 239);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Servicios y arreglos";
            // 
            // dgvReporte2
            // 
            this.dgvReporte2.AllowUserToAddRows = false;
            this.dgvReporte2.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvReporte2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Boton2,
            this.tipoArreglo,
            this.gastoArreglos,
            this.tipoServicio,
            this.gastoServicios});
            this.dgvReporte2.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvReporte2.Location = new System.Drawing.Point(25, 100);
            this.dgvReporte2.MultiSelect = false;
            this.dgvReporte2.Name = "dgvReporte2";
            this.dgvReporte2.Size = new System.Drawing.Size(478, 133);
            this.dgvReporte2.TabIndex = 18;
            this.dgvReporte2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReporte2_CellContentClick);
            this.dgvReporte2.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvReporte2_CellPainting);
            // 
            // Boton2
            // 
            this.Boton2.HeaderText = "";
            this.Boton2.Name = "Boton2";
            this.Boton2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Boton2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Boton2.UseColumnTextForButtonValue = true;
            this.Boton2.Width = 35;
            // 
            // tipoArreglo
            // 
            this.tipoArreglo.HeaderText = "Tipo de Arreglo";
            this.tipoArreglo.Name = "tipoArreglo";
            // 
            // gastoArreglos
            // 
            this.gastoArreglos.HeaderText = "Costo arreglo";
            this.gastoArreglos.Name = "gastoArreglos";
            // 
            // tipoServicio
            // 
            this.tipoServicio.HeaderText = "Tipo de servicio";
            this.tipoServicio.Name = "tipoServicio";
            // 
            // gastoServicios
            // 
            this.gastoServicios.HeaderText = "Costo servicio ";
            this.gastoServicios.Name = "gastoServicios";
            // 
            // btnAgregar2
            // 
            this.btnAgregar2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregar2.Location = new System.Drawing.Point(265, 47);
            this.btnAgregar2.Name = "btnAgregar2";
            this.btnAgregar2.Size = new System.Drawing.Size(80, 31);
            this.btnAgregar2.TabIndex = 18;
            this.btnAgregar2.Text = "Agregar";
            this.btnAgregar2.UseVisualStyleBackColor = false;
            this.btnAgregar2.Click += new System.EventHandler(this.btnAgregar2_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoEllipsis = true;
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Green;
            this.lblTotal.Location = new System.Drawing.Point(547, 357);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(133, 24);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total general";
            // 
            // frmDetalleInquilino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 506);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ReporteAlquiler);
            this.Controls.Add(this.btnPdf);
            this.Name = "frmDetalleInquilino";
            this.Text = "GestionInquilinos";
            this.Load += new System.EventHandler(this.frmDetalleInquilino_Load);
            this.ReporteAlquiler.ResumeLayout(false);
            this.ReporteAlquiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboReporteInquilino;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtExpensas;
        private System.Windows.Forms.GroupBox ReporteAlquiler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboReporteTipoArreglo;
        private System.Windows.Forms.ComboBox cboTipoServicio;
        private System.Windows.Forms.TextBox txtMontoArreglos;
        private System.Windows.Forms.TextBox txtMontoServicios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtDetalles;
        private System.Windows.Forms.TextBox txtMontoAlquiler;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAgregar2;
        private System.Windows.Forms.Button btnAgregar1;
        private System.Windows.Forms.DataGridView dgvReporte1;
        private System.Windows.Forms.Button btnAgregar3;
        private System.Windows.Forms.DataGridView dgvReporte3;
        private System.Windows.Forms.DataGridView dgvReporte2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewButtonColumn Boton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn gastoExpensas;
        private System.Windows.Forms.DataGridViewTextBoxColumn gastoComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalles;
        private System.Windows.Forms.DataGridViewButtonColumn Boton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoArreglo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gastoArreglos;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn gastoServicios;
        private System.Windows.Forms.DataGridViewButtonColumn Boton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreInquilino;
        private System.Windows.Forms.DataGridViewTextBoxColumn gastoAlquiler;
    }
}