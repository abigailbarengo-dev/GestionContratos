using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmArreglo : Form
    {
        public frmArreglo()
        {
            InitializeComponent();
            this.Size = new Size(850, 600);
            this.MinimumSize = new Size(850, 600);
            this.MaximumSize = new Size(850, 600);

            // Bloquear maximizar y minimizar
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Fijar el borde para que no se pueda redimensionar
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void frmArreglo_Load(object sender, EventArgs e)
        {

            List<Contrato> listaContrato = new CNContrato().Listar();

            // Crear una lista de inquilinos únicos a partir de los contratos
            var listaInquilinos = listaContrato
                .Where(c => c.Inquilino != null) // Asegurar que el contrato tiene un inquilino
                .Select(c => new { c.Inquilino.IdInquilino, Nombre = c.Inquilino.Apellido })
                .Distinct()
                .ToList();

            cboContratoArreglo.DataSource = listaInquilinos;
            cboContratoArreglo.DisplayMember = "Nombre"; // Mostrará el nombre y apellido del inquilino
            cboContratoArreglo.ValueMember = "IdInquilino"; // Guardará el ID del inquilino

            foreach (DataGridViewColumn column in dgvDataArreglo.Columns)
            {                                                                           
                if (column.Visible == true && column.Name != "Boton")
                {
                    cboBusquedaArreglo.Items.Add(new ComboBoxItem(column.HeaderText, column.Name));               
                }
            }

            List<Arreglo> listaArreglo = new CNArreglo().Listar();
            foreach (Arreglo item in listaArreglo)                  
            {
                dgvDataArreglo.Rows.Add(new object[]
                {
                    "",
                    item.IdArreglo,
                    item.TipoArreglo,
                    item.Costo,
                    item.Contrato.Inquilino.Apellido // Agregar el nombre y apellido
                });
            }



        }

        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtTipo.Text = "";
            txtCosto.Text = "";
            cboContratoArreglo.SelectedIndex = 0;

            txtTipo.Select();

        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            if (!decimal.TryParse(txtCosto.Text, out decimal costo))
            {
                MessageBox.Show("Debe ingresar un costo válido.");
                return;
            }

            int idInquilinoSeleccionado = Convert.ToInt32(cboContratoArreglo.SelectedValue);

            // Buscar el contrato asociado al inquilino seleccionado
            Contrato contratoAsociado = new CNContrato().Listar()
                .FirstOrDefault(c => c.Inquilino.IdInquilino == idInquilinoSeleccionado);

            if (contratoAsociado == null)
            {
                MessageBox.Show("No se encontró un contrato asociado a este inquilino.");
                return;
            }

            Arreglo objArreglo = new Arreglo()
            {
                IdArreglo = Convert.ToInt32(txtId.Text),
                TipoArreglo = txtTipo.Text,
                Costo = costo,
                Contrato = new Contrato()
                {
                    IdContrato = contratoAsociado.IdContrato,
                    Inquilino = new Inquilino() { IdInquilino = idInquilinoSeleccionado } // <-- Asegurar que se pasa el inquilino
                }
            };

            if (objArreglo.IdArreglo == 0)
            {
                int idArreglogenerado = new CNArreglo().Registrar(objArreglo, out mensaje);

                if (idArreglogenerado != 0)
                {
                    dgvDataArreglo.Rows.Add(new object[] {"", idArreglogenerado, txtTipo.Text, txtCosto.Text, contratoAsociado.Inquilino.Apellido});

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado = new CNArreglo().Editar(objArreglo, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvDataArreglo.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["IdArreglo"].Value = txtId.Text;
                    row.Cells["TipoArreglo"].Value = txtTipo.Text;
                    row.Cells["CostoArreglo"].Value = txtCosto.Text;
                    row.Cells["NombreInquilino"].Value = cboContratoArreglo.Text;

                    Limpiar();

                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }


            dgvDataArreglo.Rows.Clear();

            List<Arreglo> listaArreglo = new CNArreglo().Listar();
            foreach (Arreglo item in listaArreglo)
            {
                dgvDataArreglo.Rows.Add(new object[] { "", item.IdArreglo, item.TipoArreglo, item.Costo, item.Contrato.Inquilino.Apellido });

            }
        }
        



        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void eliminarbtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el Arreglo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;

                    Arreglo objArreglo = new Arreglo()
                    {
                        IdArreglo = Convert.ToInt32(txtId.Text)
                    };

                    bool respuesta = new CNArreglo().Eliminar(objArreglo, out mensaje);

                    if (respuesta)
                    {
                        dgvDataArreglo.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        private void btnBuscarArreglo_Click(object sender, EventArgs e)
        {
            if (cboBusquedaArreglo.SelectedItem == null)                        // clase ComBoxItem para poder 
            {
                MessageBox.Show("Debe seleccionar un criterio de búsqueda.");
                return;
            }

            string columnaFiltro = ((ComboBoxItem)cboBusquedaArreglo.SelectedItem).Value;

            if (dgvDataArreglo.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDataArreglo.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusquedaArreglo.Text.Trim().ToUpper()))
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

        private void btnLimpiarArreglo_Click(object sender, EventArgs e)
        {
            txtBusquedaArreglo.Text = "";

            foreach (DataGridViewRow row in dgvDataArreglo.Rows)
            {
                row.Visible = true;
            }
        }

        private void dgvDataArreglo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDataArreglo.Columns[e.ColumnIndex].Name == "Boton")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {  // textbox name                          name de columnas dentro de dgv
                    txtIndice.Text = indice.ToString();
                    txtId.Text = dgvDataArreglo.Rows[indice].Cells["IdArreglo"].Value.ToString();
                    txtTipo.Text = dgvDataArreglo.Rows[indice].Cells["TipoArreglo"].Value.ToString();
                    txtCosto.Text = dgvDataArreglo.Rows[indice].Cells["CostoArreglo"].Value.ToString();
                    cboContratoArreglo.Text = dgvDataArreglo.Rows[indice].Cells["NombreInquilino"].Value.ToString();
                }
            }
        }

        private void dgvDataArreglo_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
    }
}
