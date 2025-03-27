using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static IconMenuItem MenuActivo = null;
        private static Form FormActivo = null;

        public Inicio()
        {
            InitializeComponent();
            this.Size = new Size(650, 300);
            this.MinimumSize = new Size(650, 300);
            this.MaximumSize = new Size(650, 300);

            // Bloquear maximizar y minimizar
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Fijar el borde para que no se pueda redimensionar
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
         
        // cambio dinamico de tamaños dentro del mismo contenedor de form (FUNCIONA CON DOBLE CLICK)
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.Transparent;
                MenuActivo.ForeColor = Color.White;
                MenuActivo.IconColor = Color.White;
            }

            menu.BackColor = Color.Black;
            menu.ForeColor = Color.Black;
            menu.IconColor = Color.Black;
            MenuActivo = menu;

            if (FormActivo != null)
            {
                FormActivo.Close();
            }

            // ajuste tamaño formulario principal a nuevo formulario
            this.Size = formulario.Size;
            this.MinimumSize = formulario.MinimumSize;
            this.MaximumSize = formulario.MaximumSize;

            // formulario dentro de contenedor
            FormActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.None; // mantiene tamaño original
            formulario.BackColor = Color.LightYellow;

            contenedor.Controls.Clear(); // limpia contenedor antes de agregar nuevo form
            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        // Botones para abrir formularios y ajustar la ventana principal al tamaño de cada uno

        private void menuInquilino_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmInquilino());
        }

        private void subMenuDetalleInquilino_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuInquilino, new frmDetalleInquilino());
        }

        private void menuGarante_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(menuGarante, new frmGarante());
        }

        private void menuContrato_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuContrato, new frmContrato());
        }

        private void menuServicio_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(menuServicio, new frmServicio());
        }

        private void menuArreglo_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(menuArreglo, new frmArreglo());
        }
    }
}
