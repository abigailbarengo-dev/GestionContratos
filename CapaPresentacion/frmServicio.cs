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
    public partial class frmServicio : Form
    {
        public frmServicio()
        {
            InitializeComponent();
            this.Size = new Size(900, 600);
            this.MinimumSize = new Size(900, 600);
            this.MaximumSize = new Size(900, 600);

            // Bloquear maximizar y minimizar
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Fijar el borde para que no se pueda redimensionar
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void frmServicio_Load(object sender, EventArgs e)
        {
            List<Contrato> listaContrato2 = new CNContrato().Listar();

            // Crear una lista de inquilinos únicos a partir de los contratos
            var listaInquilinos2 = listaContrato2
                .Where(c => c.Inquilino != null) // Asegurar que el contrato tiene un inquilino
                .Select(c => new { c.Inquilino.IdInquilino, Nombre = c.Inquilino.Apellido })
                .Distinct()
                .ToList();

            cboContratoServicio.DataSource = listaInquilinos2;
            cboContratoServicio.DisplayMember = "Nombre"; // Mostrará el nombre y apellido del inquilino
            cboContratoServicio.ValueMember = "IdInquilino"; // Guardará el ID del inquilino

            foreach (DataGridViewColumn column in dgvDataServicio.Columns)
            {                                                                           // ARREGLAR FILTRO DE BUSQUEDA
                if (column.Visible == true && column.Name != "Boton")
                {
                    cboBusquedaServicio.Items.Add(new ComboBoxItem(column.HeaderText, column.Name));
                }
            }


            List<Servicio> listaServicio = new CNServicio().Listar();
            foreach (Servicio item in listaServicio)                                               
            {
                dgvDataServicio.Rows.Add(new object[] { "",
                item.IdServicio,
                item.Tipo,
                item.Costo,
                item.Contrato.Inquilino.Apellido });
            }
        }


        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtTipo.Text = "";
            txtCosto.Text = "";
            cboContratoServicio.SelectedIndex = 0;

            txtTipo.Select();

        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            if (!decimal.TryParse(txtCosto.Text, out decimal costo))
            {
                MessageBox.Show("Debe ingresar un costo de servicio");
                return;
            }


            int idInquilinoSeleccionado2 = Convert.ToInt32(cboContratoServicio.SelectedValue);

            // Buscar el contrato asociado al inquilino seleccionado
            Contrato contratoAsociado2 = new CNContrato().Listar()
                .FirstOrDefault(c => c.Inquilino.IdInquilino == idInquilinoSeleccionado2);

            if (contratoAsociado2 == null)
            {
                MessageBox.Show("No se encontró un contrato asociado a este inquilino.");
                return;
            }


            Servicio objServicio = new Servicio()
            {
                IdServicio = Convert.ToInt32(txtId.Text),
                Tipo = txtTipo.Text,                          
                Costo = Convert.ToDecimal(txtCosto.Text),
                Contrato = new Contrato()
                {
                    IdContrato = contratoAsociado2.IdContrato,
                    Inquilino = new Inquilino() { IdInquilino = idInquilinoSeleccionado2 } 
                }
            
            };


            if (objServicio.IdServicio == 0)
            {
                int idServiciogenerado = new CNServicio().Registrar(objServicio, out mensaje);

                if (idServiciogenerado != 0)
                {
                    dgvDataServicio.Rows.Add(new object[] { "", idServiciogenerado, txtTipo.Text, txtCosto.Text, contratoAsociado2.Inquilino.Apellido });

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }
            else
            {
                bool resultado = new CNServicio().Editar(objServicio, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvDataServicio.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["IdServicio"].Value = txtId.Text;
                    row.Cells["TipoServicio"].Value = txtTipo.Text;
                    row.Cells["CostoServicio"].Value = txtCosto.Text;
                    row.Cells["NombreInquilino"].Value = cboContratoServicio.Text;

                    Limpiar();

                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }


            dgvDataServicio.Rows.Clear();

            List<Servicio> listaServicio = new CNServicio().Listar();
            foreach (Servicio item in listaServicio)
            {
                dgvDataServicio.Rows.Add(new object[] { "", item.IdServicio, item.Tipo, item.Costo, item.Contrato.Inquilino.Apellido});

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
                if (MessageBox.Show("¿Desea eliminar el servicio?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;

                    Servicio objServicio = new Servicio()
                    {
                        IdServicio = Convert.ToInt32(txtId.Text)
                    };

                    bool respuesta = new CNServicio().Eliminar(objServicio, out mensaje);

                    if (respuesta)
                    {
                        dgvDataServicio.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        private void btnBuscarServicio_Click(object sender, EventArgs e)
        {
            if (cboBusquedaServicio.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un criterio de búsqueda.");
                return;
            }

            string columnaFiltro = ((ComboBoxItem)cboBusquedaServicio.SelectedItem).Value;

            if (dgvDataServicio.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDataServicio.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusquedaServicio.Text.Trim().ToUpper()))
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

        private void btnLimpiarServicio_Click(object sender, EventArgs e)
        {
            txtBusquedaServicio.Text = "";

            foreach (DataGridViewRow row in dgvDataServicio.Rows)
            {
                row.Visible = true;
            }
        }

        private void dgvDataServicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDataServicio.Columns[e.ColumnIndex].Name == "Boton")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {  // textbox name                          name de columnas dentro de dgv
                    txtIndice.Text = indice.ToString();
                    txtId.Text = dgvDataServicio.Rows[indice].Cells["IdServicio"].Value.ToString();
                    txtTipo.Text = dgvDataServicio.Rows[indice].Cells["TipoServicio"].Value.ToString();
                    txtCosto.Text = dgvDataServicio.Rows[indice].Cells["CostoServicio"].Value.ToString();
                    cboContratoServicio.Text = dgvDataServicio.Rows[indice].Cells["NombreInquilino"].Value.ToString();
                }
            }
        }

        private void dgvDataServicio_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
