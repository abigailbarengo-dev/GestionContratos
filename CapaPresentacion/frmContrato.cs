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
    public partial class frmContrato : Form
    {
        public frmContrato()
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

        private void frmContrato_Load(object sender, EventArgs e)
        {
            List<Inquilino> listaInquilino = new CNInquilino().Listar();
            foreach (Inquilino item in listaInquilino)
            {
                // cboInquilinoGarante.Items.Add(item.Apellido);   // (antes era column.HeaderText)                   foreach para cbo inquilino                         
                cboInquilinoContrato.DataSource = listaInquilino;
                cboInquilinoContrato.DisplayMember = "Apellido";
                cboInquilinoContrato.ValueMember = "IdInquilino";
            }



            foreach (DataGridViewColumn column in dgvDataContrato.Columns)
            {
                if (column.Visible == true && column.Name != "Boton")
                {                                                                                                   // foreach para filtro
                    cboBusquedaContrato.Items.Add(new ComboBoxItem(column.HeaderText, column.Name));
                }
            }                                            // APARECE 0 EN EL DATAGRIDVIEW PERO EN BASE DE DATOS FIGURA ID BIEN
                                                         // APELLIDO-

            List<Contrato> listaContrato = new CNContrato().Listar();

            foreach (Contrato item in listaContrato)                                                          // no tendria que ser apellido de inquilino???
            {
                dgvDataContrato.Rows.Add(new object[] { "",
                item.IdContrato,
                item.FechaInicio.ToString("dd/MM/yyyy"),
                item.FechaFin.ToString("dd/MM/yyyy"),
                item.Monto,
                item.Inquilino.Apellido });
            }

        }


        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtFechaInicio.Text = "";
            txtFechaFin.Text = "";
            txtMonto.Text = "";
            cboInquilinoContrato.SelectedIndex = 0;

            txtFechaInicio.Select();

        }

        private void Guardarbtn_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            if (!decimal.TryParse(txtMonto.Text, out decimal monto))
            {
                MessageBox.Show("Debe ingresar un monto para el contrato de alquiler");
                return;
            }


            Contrato objcontrato = new Contrato()
            {
                IdContrato = Convert.ToInt32(txtId.Text),
                FechaInicio = Convert.ToDateTime(txtFechaInicio.Text),                          // .text????????
                FechaFin = Convert.ToDateTime(txtFechaFin.Text),
                Monto = Convert.ToDecimal(txtMonto.Text),
                Inquilino = new Inquilino() { IdInquilino = Convert.ToInt32(cboInquilinoContrato.SelectedValue) }
            };



            if (objcontrato.IdContrato == 0)
            {
                int idcontratogenerado = new CNContrato().Registrar(objcontrato, out mensaje);

                if (idcontratogenerado != 0)
                {
                    dgvDataContrato.Rows.Add(new object[] { "", idcontratogenerado, txtFechaInicio.Text, txtFechaFin.Text, txtMonto.Text, cboInquilinoContrato.Text });

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }
            else
            {
                bool resultado = new CNContrato().Editar(objcontrato, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvDataContrato.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["IdContrato"].Value = txtId.Text;
                    row.Cells["FechaInicio"].Value = txtFechaInicio.Text;
                    row.Cells["FechaFin"].Value = txtFechaFin.Text;
                    row.Cells["MontoContrato"].Value = txtMonto.Text;
                    row.Cells["InquilinoContrato"].Value = cboInquilinoContrato.Text;

                    Limpiar();

                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }


            dgvDataContrato.Rows.Clear();

            List<Contrato> listaContrato = new CNContrato().Listar();
            foreach (Contrato item in listaContrato)
            {
                dgvDataContrato.Rows.Add(new object[] { "", item.IdContrato, item.FechaInicio.ToString("dd/MM/yyyy"), item.FechaFin.ToString("dd/MM/yyyy"), item.Monto, item.Inquilino.Apellido });

            }
        }

        private void Limpiarbtn_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el contrato?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;

                    Contrato objcontrato = new Contrato()
                    {
                        IdContrato = Convert.ToInt32(txtId.Text)
                    };

                    bool respuesta = new CNContrato().Eliminar(objcontrato, out mensaje);

                    if (respuesta)
                    {
                        dgvDataContrato.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        private void btnBuscarContrato_Click(object sender, EventArgs e)
        {
            if (cboBusquedaContrato.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un criterio de búsqueda.");
                return;
            }


            string columnaFiltro = ((ComboBoxItem)cboBusquedaContrato.SelectedItem).Value;

            if (dgvDataContrato.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDataContrato.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusquedaContrato.Text.Trim().ToUpper()))
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

        private void btnLimpiarContrato_Click(object sender, EventArgs e)
        {
            txtBusquedaContrato.Text = "";

            foreach (DataGridViewRow row in dgvDataContrato.Rows)
            {
                row.Visible = true;
            }
        }

        private void dgvDataContrato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDataContrato.Columns[e.ColumnIndex].Name == "Boton")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {  // textbox name                          name de columnas dentro de dgv
                    txtIndice.Text = indice.ToString();
                    txtId.Text = dgvDataContrato.Rows[indice].Cells["IdContrato"].Value.ToString(); 
                    txtFechaInicio.Text = Convert.ToDateTime(dgvDataContrato.Rows[indice].Cells["FechaInicio"].Value).ToString("dd/MM/yyyy");
                    txtFechaFin.Text = Convert.ToDateTime(dgvDataContrato.Rows[indice].Cells["FechaFin"].Value).ToString("dd/MM/yyyy");
                    txtMonto.Text = dgvDataContrato.Rows[indice].Cells["MontoContrato"].Value.ToString();
                    cboInquilinoContrato.Text = dgvDataContrato.Rows[indice].Cells["InquilinoContrato"].Value.ToString();
                }
            }
        }

        private void dgvDataContrato_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
