using CapaDatos;
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
    public partial class frmInquilino : Form
    {
        public frmInquilino()
        {
            InitializeComponent();
            this.Size = new Size(900, 550);
            this.MinimumSize = new Size(900, 550);
            this.MaximumSize = new Size(900, 550);

            // Bloquear maximizar y minimizar
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Fijar el borde para que no se pueda redimensionar
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtTelefonoInquilino.Text))
            {
                MessageBox.Show("El número de teléfono es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefonoInquilino.Focus();
                return;
            }

            if (!Regex.IsMatch(txtTelefonoInquilino.Text, @"^[0-9\s\-\(\)]+$"))
            {
                MessageBox.Show("Número de teléfono inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefonoInquilino.Focus();
                return; // Detener la ejecución
            }

            if (string.IsNullOrEmpty(txtDniInquilino.Text))
            {
                MessageBox.Show("El DNI es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDniInquilino.Focus();
                return;
            }

            if (!Regex.IsMatch(txtDniInquilino.Text, @"^\d+$"))
            {
                MessageBox.Show("DNI inválido. Debe contener solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDniInquilino.Focus();
                return;
            }


            string mensaje = string.Empty;

            Inquilino objinquilino = new Inquilino()
            {
               IdInquilino = Convert.ToInt32(txtId.Text),
               Nombre = txtNombreInquilino.Text,
               Apellido = txtApellidoInquilino.Text,
               Telefono = txtTelefonoInquilino.Text,
               DNI = txtDniInquilino.Text
            };


            if (objinquilino.IdInquilino == 0)
            {
                int idinquilinogenerado = new CNInquilino().Registrar(objinquilino, out mensaje);

                if (idinquilinogenerado != 0)
                {
                    dgvDataInquilino.Rows.Add(new object[] { "", idinquilinogenerado, txtNombreInquilino.Text, txtApellidoInquilino.Text, txtTelefonoInquilino.Text, txtDniInquilino.Text });

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }
            else 
            { 
                bool resultado = new CNInquilino().Editar(objinquilino, out mensaje);

                if(resultado)
                {
                    DataGridViewRow row = dgvDataInquilino.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["IdInquilino"].Value = txtId.Text;
                    row.Cells["NombreInquilino"].Value = txtNombreInquilino.Text;
                    row.Cells["ApellidoInquilino"].Value = txtApellidoInquilino.Text;
                    row.Cells["TeléfonoInquilino"].Value = txtTelefonoInquilino.Text;
                    row.Cells["DniInquilino"].Value = txtDniInquilino.Text;

                    Limpiar();

                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }


            dgvDataInquilino.Rows.Clear();

            List<Inquilino> listaInquilino = new CNInquilino().Listar();
            foreach (Inquilino item in listaInquilino)
            {
                dgvDataInquilino.Rows.Add(new object[] { "", item.IdInquilino, item.Nombre, item.Apellido, item.Telefono, item.DNI });

            }
            
        }


        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtNombreInquilino.Text = "";
            txtApellidoInquilino.Text = "";
            txtTelefonoInquilino.Text = "";
            txtDniInquilino.Text = "";

            txtDniInquilino.Select();

        }


        private void frmInquilino_Load(object sender, EventArgs e)
        {
            foreach(DataGridViewColumn column in dgvDataInquilino.Columns)
            {
                if(column.Visible == true && column.Name != "Boton")
                {
                    cboBusquedaInquilino.Items.Add(new ComboBoxItem(column.HeaderText, column.Name));   // (antes era column.HeaderText)
                }                                   // NombreInquilino, ApellidoInquilino, TeléfonoInquilino, DniInquilino...
            }


            List<Inquilino> listaInquilino = new CNInquilino().Listar();

            foreach(Inquilino item in listaInquilino)
            {
                dgvDataInquilino.Rows.Add(new object[] { "", item.IdInquilino, item.Nombre, item.Apellido, item.Telefono, item.DNI });
            }


        }


        // metodo de check

        private void dgvDataInquilino_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if(e.RowIndex < 0)
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


        private void dgvDataInquilino_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDataInquilino.Columns[e.ColumnIndex].Name == "Boton")
            {
                int indice = e.RowIndex;

                if(indice >= 0)
                {  // textbox name                          name de columnas dentro de dgv
                    txtIndice.Text = indice.ToString();
                    txtId.Text = dgvDataInquilino.Rows[indice].Cells["IdInquilino"].Value.ToString();
                    txtNombreInquilino.Text = dgvDataInquilino.Rows[indice].Cells["NombreInquilino"].Value.ToString();
                    txtApellidoInquilino.Text = dgvDataInquilino.Rows[indice].Cells["ApellidoInquilino"].Value.ToString();
                    txtTelefonoInquilino.Text = dgvDataInquilino.Rows[indice].Cells["TeléfonoInquilino"].Value.ToString();
                    txtDniInquilino.Text = dgvDataInquilino.Rows[indice].Cells["DniInquilino"].Value.ToString();
                } 
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txtId.Text) != 0)
            {
                if(MessageBox.Show("¿Desea eliminar al inquilino?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;

                    Inquilino objinquilino = new Inquilino()
                    {
                        IdInquilino = Convert.ToInt32(txtId.Text)
                    };

                    bool respuesta = new CNInquilino().Eliminar(objinquilino, out mensaje);

                    if(respuesta) {
                        dgvDataInquilino.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }
         

        private void btnBuscarInquilino_Click(object sender, EventArgs e)
        {
            if (cboBusquedaInquilino.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un criterio de búsqueda.");
                return; 
            }

            string columnaFiltro = ((ComboBoxItem)cboBusquedaInquilino.SelectedItem).Value;

            if (dgvDataInquilino.Rows.Count > 0)
            {                                                        
                foreach(DataGridViewRow row in dgvDataInquilino.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusquedaInquilino.Text.Trim().ToUpper()))
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


        private void btnLimpiarInquilino_Click(object sender, EventArgs e)
        {
            txtBusquedaInquilino.Text = "";

            foreach(DataGridViewRow row in dgvDataInquilino.Rows)
            {
                row.Visible = true;
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

    }
}
