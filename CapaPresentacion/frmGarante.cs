using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmGarante : Form
    {
        public frmGarante()
        {
            InitializeComponent();
            this.Size = new Size(1050, 650);
            this.MinimumSize = new Size(1050, 650);
            this.MaximumSize = new Size(1050, 650);

            // Bloquear maximizar y minimizar
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Fijar el borde para que no se pueda redimensionar
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }


        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtNombreGarante.Text = "";
            txtApellidoGarante.Text = "";
            txtTelefonoGarante.Text = "";
            txtMailGarante.Text = "";
            txtDireccionGarante.Text = "";
            cboInquilinoGarante.SelectedIndex = 0;

            txtMailGarante.Select();

        }


        private void frmGarante_Load(object sender, EventArgs e)
        {
           
            List<Inquilino> listaInquilino = new CNInquilino().Listar();
            foreach (Inquilino item in listaInquilino)
            {
               // cboInquilinoGarante.Items.Add(item.Apellido);   // (antes era column.HeaderText)                   foreach para cbo inquilino                         
                cboInquilinoGarante.DataSource = listaInquilino;
                cboInquilinoGarante.DisplayMember = "Apellido";
                cboInquilinoGarante.ValueMember = "IdInquilino";
                 
            }



            foreach (DataGridViewColumn column in dgvDataGarante.Columns)
            {
                if (column.Visible == true && column.Name != "Boton")
                {                                                                                                   // foreach para filtro
                    cboBusquedaGarante.Items.Add(new ComboBoxItem(column.HeaderText, column.Name));
                }
            }                                          
                                                                   

            List<Garante> listaGarante = new CNGarante().Listar();

            foreach (Garante item in listaGarante)                                                          // no tendria que ser apellido de inquilino???
            {
                dgvDataGarante.Rows.Add(new object[] { "",
                item.IdGarante,
                item.Nombre,
                item.Apellido,
                item.Telefono,
                item.Mail,
                item.Direccion,
                item.Inquilino.Apellido });
            }



        }



        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar al Garante?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;

                    Garante objGarante = new Garante()
                    {
                        IdGarante = Convert.ToInt32(txtId.Text)
                    };

                    bool respuesta = new CNGarante().Eliminar(objGarante, out mensaje);

                    if (respuesta)
                    {
                        dgvDataGarante.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }



        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            // Validacion telefono
            if (!string.IsNullOrEmpty(txtTelefonoGarante.Text) && !Regex.IsMatch(txtTelefonoGarante.Text, @"^[0-9\s\-\(\)]+$"))
            {
                MessageBox.Show("Número de teléfono inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefonoGarante.Focus();
                return; // Detener la ejecución
            }

            // Validacion email
            if (!string.IsNullOrEmpty(txtMailGarante.Text) && !Regex.IsMatch(txtMailGarante.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Dirección de correo electrónico inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMailGarante.Focus();
                return; // Detener la ejecución
            }



            string mensaje = string.Empty;

            Garante objgarante = new Garante()
            { 
                IdGarante = Convert.ToInt32(txtId.Text),
                Nombre = txtNombreGarante.Text,
                Apellido = txtApellidoGarante.Text,
                Telefono = txtTelefonoGarante.Text,
                Mail = txtMailGarante.Text,
                Direccion = txtDireccionGarante.Text,
                Inquilino = new Inquilino() { IdInquilino = Convert.ToInt32(cboInquilinoGarante.SelectedValue) }
            };



            if (objgarante.IdGarante == 0)
            {
                int idgarantegenerado = new CNGarante().Registrar(objgarante, out mensaje);

                if (idgarantegenerado != 0)
                {
                    dgvDataGarante.Rows.Add(new object[] { "", idgarantegenerado, txtNombreGarante.Text, txtApellidoGarante.Text, txtTelefonoGarante.Text, txtMailGarante.Text, txtDireccionGarante.Text, cboInquilinoGarante.Text });

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }
            else
            {
                bool resultado = new CNGarante().Editar(objgarante, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvDataGarante.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["IdGarante"].Value = txtId.Text;
                    row.Cells["NombreGarante"].Value = txtNombreGarante.Text;
                    row.Cells["ApellidoGarante"].Value = txtApellidoGarante.Text;
                    row.Cells["TeléfonoGarante"].Value = txtTelefonoGarante.Text;
                    row.Cells["MailGarante"].Value = txtMailGarante.Text;
                    row.Cells["DireccionGarante"].Value = txtDireccionGarante.Text;
                    row.Cells["InquilinoGarante"].Value = cboInquilinoGarante.Text;

                    Limpiar();

                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }


            dgvDataGarante.Rows.Clear(); 

            List<Garante> listaGarante = new CNGarante().Listar();
            foreach (Garante item in listaGarante)
            {
                dgvDataGarante.Rows.Add(new object[] { "", item.IdGarante, item.Nombre, item.Apellido, item.Telefono, item.Mail, item.Direccion, item.Inquilino.Apellido });

            }
        }


        private void dgvDataGarante_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDataGarante.Columns[e.ColumnIndex].Name == "Boton")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {  // textbox name                          name de columnas dentro de dgv
                    txtIndice.Text = indice.ToString();
                    txtId.Text = dgvDataGarante.Rows[indice].Cells["IdGarante"].Value.ToString();
                    txtNombreGarante.Text = dgvDataGarante.Rows[indice].Cells["NombreGarante"].Value.ToString();
                    txtApellidoGarante.Text = dgvDataGarante.Rows[indice].Cells["ApellidoGarante"].Value.ToString();
                    txtTelefonoGarante.Text = dgvDataGarante.Rows[indice].Cells["TeléfonoGarante"].Value.ToString();
                    txtMailGarante.Text = dgvDataGarante.Rows[indice].Cells["MailGarante"].Value.ToString();
                    txtDireccionGarante.Text = dgvDataGarante.Rows[indice].Cells["DireccionGarante"].Value.ToString();
                    cboInquilinoGarante.Text = dgvDataGarante.Rows[indice].Cells["InquilinoGarante"].Value.ToString();
                }
            }
        }

        private void dgvDataGarante_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources._checked.Width;
                var h = Properties.Resources._checked.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;


                e.Graphics.DrawImage(Properties.Resources._checked, new Rectangle(x, y, w, h));
                e.Handled = true;

            }
        }

       

        private void btnLimpiarGarante_Click(object sender, EventArgs e)
        {
            txtBusquedaGarante.Text = "";

            foreach (DataGridViewRow row in dgvDataGarante.Rows)
            {
                row.Visible = true;
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnBuscarGarante_Click_1(object sender, EventArgs e)
        {

            if (cboBusquedaGarante.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un criterio de búsqueda.");
                return; 
            }

            string columnaFiltro = ((ComboBoxItem)cboBusquedaGarante.SelectedItem).Value;


            if (dgvDataGarante.Rows.Count > 0)
            {                                                         
                foreach (DataGridViewRow row in dgvDataGarante.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusquedaGarante.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }

                }
            }
        }

    }
}
    
