namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuInquilino = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuDetalleInquilino = new FontAwesome.Sharp.IconMenuItem();
            this.menuGarante = new FontAwesome.Sharp.IconMenuItem();
            this.menuContrato = new FontAwesome.Sharp.IconMenuItem();
            this.menuServicio = new FontAwesome.Sharp.IconMenuItem();
            this.menuArreglo = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.contenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuInquilino,
            this.menuGarante,
            this.menuContrato,
            this.menuServicio,
            this.menuArreglo});
            this.menu.Location = new System.Drawing.Point(0, 45);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(655, 56);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuInquilino
            // 
            this.menuInquilino.AutoSize = false;
            this.menuInquilino.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuDetalleInquilino});
            this.menuInquilino.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuInquilino.IconChar = FontAwesome.Sharp.IconChar.PersonRays;
            this.menuInquilino.IconColor = System.Drawing.Color.White;
            this.menuInquilino.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuInquilino.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuInquilino.Name = "menuInquilino";
            this.menuInquilino.Size = new System.Drawing.Size(122, 52);
            this.menuInquilino.Text = "Inquilino";
            this.menuInquilino.Click += new System.EventHandler(this.menuInquilino_Click);
            // 
            // subMenuDetalleInquilino
            // 
            this.subMenuDetalleInquilino.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.subMenuDetalleInquilino.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subMenuDetalleInquilino.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuDetalleInquilino.IconColor = System.Drawing.Color.White;
            this.subMenuDetalleInquilino.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuDetalleInquilino.Name = "subMenuDetalleInquilino";
            this.subMenuDetalleInquilino.Size = new System.Drawing.Size(134, 22);
            this.subMenuDetalleInquilino.Text = "Ver Detalles";
            this.subMenuDetalleInquilino.Click += new System.EventHandler(this.subMenuDetalleInquilino_Click);
            // 
            // menuGarante
            // 
            this.menuGarante.AutoSize = false;
            this.menuGarante.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuGarante.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.menuGarante.IconColor = System.Drawing.Color.White;
            this.menuGarante.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuGarante.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuGarante.Name = "menuGarante";
            this.menuGarante.Size = new System.Drawing.Size(122, 52);
            this.menuGarante.Text = "Garante";
            this.menuGarante.Click += new System.EventHandler(this.menuGarante_Click_1);
            // 
            // menuContrato
            // 
            this.menuContrato.AutoSize = false;
            this.menuContrato.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuContrato.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.menuContrato.IconColor = System.Drawing.Color.White;
            this.menuContrato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuContrato.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuContrato.Name = "menuContrato";
            this.menuContrato.Size = new System.Drawing.Size(122, 52);
            this.menuContrato.Text = "Contrato";
            this.menuContrato.Click += new System.EventHandler(this.menuContrato_Click);
            // 
            // menuServicio
            // 
            this.menuServicio.AutoSize = false;
            this.menuServicio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuServicio.IconChar = FontAwesome.Sharp.IconChar.UsersRectangle;
            this.menuServicio.IconColor = System.Drawing.Color.White;
            this.menuServicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuServicio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuServicio.Name = "menuServicio";
            this.menuServicio.Size = new System.Drawing.Size(122, 52);
            this.menuServicio.Text = "Servicios";
            this.menuServicio.Click += new System.EventHandler(this.menuServicio_Click_1);
            // 
            // menuArreglo
            // 
            this.menuArreglo.AutoSize = false;
            this.menuArreglo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuArreglo.IconChar = FontAwesome.Sharp.IconChar.BuildingUser;
            this.menuArreglo.IconColor = System.Drawing.Color.White;
            this.menuArreglo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuArreglo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuArreglo.Name = "menuArreglo";
            this.menuArreglo.Size = new System.Drawing.Size(114, 52);
            this.menuArreglo.Text = "Arreglos";
            this.menuArreglo.Click += new System.EventHandler(this.menuArreglo_Click_1);
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(655, 45);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestion de alquileres";
            // 
            // contenedor
            // 
            this.contenedor.Controls.Add(this.label2);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 101);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(655, 349);
            this.contenedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Abigail Barengo - 2025";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestorInquilinos";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.contenedor.ResumeLayout(false);
            this.contenedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuArreglo;
        private FontAwesome.Sharp.IconMenuItem menuInquilino;
        private FontAwesome.Sharp.IconMenuItem menuGarante;
        private FontAwesome.Sharp.IconMenuItem menuContrato;
        private FontAwesome.Sharp.IconMenuItem menuServicio;
        private System.Windows.Forms.Panel contenedor;
        private FontAwesome.Sharp.IconMenuItem subMenuDetalleInquilino;
        private System.Windows.Forms.Label label2;
    }
}

