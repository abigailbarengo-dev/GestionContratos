using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System.Text;
using Rectangle = System.Drawing.Rectangle;

namespace CapaPresentacion
{
    public partial class frmDetalleInquilino : Form
    {
        public frmDetalleInquilino()
        {
            InitializeComponent();
            ConfigurarFormulario();

            dgvReporte1.CellClick += dgvReporte1_CellClick;
            dgvReporte2.CellClick += dgvReporte2_CellClick;
            dgvReporte3.CellClick += dgvReporte3_CellClick;

        }

        private void ConfigurarFormulario()
        {
            this.Size = new Size(800, 640);
            this.MinimumSize = this.MaximumSize = new Size(800, 640);
            this.MaximizeBox = this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void frmDetalleInquilino_Load(object sender, EventArgs e)
        {
            dgvReporte1.Rows.Clear();
            dgvReporte2.Rows.Clear();
            dgvReporte3.Rows.Clear();


            // Cargar Inquilinos
            var listaInquilino = new CNInquilino().Listar()
                .Select(i => new { NombreCompleto = $"{i.Nombre.Trim()} {i.Apellido.Trim()}", DNI = i.DNI })
                .ToList();

            cboReporteInquilino.DataSource = listaInquilino;
            cboReporteInquilino.DisplayMember = "NombreCompleto";
            cboReporteInquilino.ValueMember = "DNI";

            // Cargar Servicios
            var tipoUnico = new HashSet<string>(new CNServicio().Listar().Select(s => s.Tipo.ToString()));
            cboTipoServicio.DataSource = tipoUnico.ToList();

            // Cargar Arreglos
            var arreglosUnicos = new HashSet<string>(new CNArreglo().Listar().Select(a => a.TipoArreglo.ToString()));
            cboReporteTipoArreglo.DataSource = arreglosUnicos.ToList();
        }

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            AgregarFila(dgvReporte1, cboReporteInquilino.Text, txtMontoAlquiler.Text);
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            AgregarFila(dgvReporte2, cboReporteTipoArreglo.Text, txtMontoArreglos.Text, cboTipoServicio.Text, txtMontoServicios.Text);
        }

        private void btnAgregar3_Click(object sender, EventArgs e)
        {
            AgregarFila(dgvReporte3, txtExpensas.Text, txtPorcentaje.Text, txtDetalles.Text.Trim());
        }



        private bool ExisteRegistroEnDGV(DataGridView dgv, string valor)
        {
            return dgv.Rows.Cast<DataGridViewRow>().Any(row => row.Cells[1].Value?.ToString() == valor);
        }


        private void AgregarFila(DataGridView dgv, string valor1, string valor2, string valor3 = "", string valor4 = "")
        {
            if (dgv == dgvReporte2) // Lógica específica para dgvReporte2
            {
                if (string.IsNullOrWhiteSpace(valor1) && string.IsNullOrWhiteSpace(valor2) &&
                    string.IsNullOrWhiteSpace(valor3) && string.IsNullOrWhiteSpace(valor4))
                {
                    MessageBox.Show("Debe completar al menos un campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal monto1 = 0;
                decimal monto2 = 0;

                // Validación y conversión para monto arreglos
                object montoArreglos = null; // Inicializar como null
                if (!string.IsNullOrWhiteSpace(valor2))
                {
                    if (decimal.TryParse(valor2, out monto1))
                    {
                        montoArreglos = monto1.ToString(); // Asignar el valor convertido
                    }
                    else
                    {
                        MessageBox.Show("El monto de arreglos debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Validación y conversión para monto servicios
                object montoServicios = null; // Inicializar como null
                if (!string.IsNullOrWhiteSpace(valor4))
                {
                    if (decimal.TryParse(valor4, out monto2))
                    {
                        montoServicios = monto2.ToString(); // Asignar el valor convertido
                    }
                    else
                    {
                        MessageBox.Show("El monto de servicios debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                dgv.Rows.Add("", valor1, montoArreglos, valor3, montoServicios);
            }
            else // Lógica para otros DataGridViews (dgvReporte1 y dgvReporte3)
            {
                if (ExisteRegistroEnDGV(dgv, valor1))
                {
                    MessageBox.Show("Este registro ya existe.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (string.IsNullOrWhiteSpace(valor1) || string.IsNullOrWhiteSpace(valor2))
                {
                    MessageBox.Show("Debe completar los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(valor2, out decimal monto1))
                {
                    MessageBox.Show("El primer monto debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dgv == dgvReporte3)
                {
                    dgv.Rows.Add("", valor1, valor2, valor3);
                }
                else
                {
                    dgv.Rows.Add("", valor1, monto1.ToString("0.00"));
                }
            }

            LimpiarCamposPorDGV(dgv);
            CalcularTotal();
        }


        private void LimpiarCamposPorDGV(DataGridView dgv)
        {
            if (dgv.Name == "dgvReporte1")
            {
                txtMontoAlquiler.Clear();
            }
            else if (dgv.Name == "dgvReporte3")
            {
                txtPorcentaje.Clear();
                txtExpensas.Clear();
                txtDetalles.Clear();
            }
            else if (dgv.Name == "dgvReporte2")
            {
                cboReporteTipoArreglo.Text = "";
                cboTipoServicio.Text = "";
                txtMontoArreglos.Clear();
                txtMontoServicios.Clear();
            }
        }


        private void CalcularTotal()
        {
            decimal total = 0;

                total = dgvReporte1.Rows.Cast<DataGridViewRow>()
                    .Sum(row => Convert.ToDecimal(row.Cells[2].Value ?? 0)) // de cada dgv, castea las celdas con ingresos numericos
                    + dgvReporte2.Rows.Cast<DataGridViewRow>()
                    .Sum(row => Convert.ToDecimal(row.Cells[2].Value ?? 0) + Convert.ToDecimal(row.Cells[4].Value ?? 0))
                    + dgvReporte3.Rows.Cast<DataGridViewRow>()
                    .Sum(row => Convert.ToDecimal(row.Cells[0].Value ?? 0) + Convert.ToDecimal(row.Cells[1].Value ?? 0));
            

            lblTotal.Text = $"Total: ${total:0.00}";
        }


        private void btnPdf_Click(object sender, EventArgs e)
        {
            // Verificar si TODOS los DataGridView están vacíos
            if (dgvReporte1.Rows.Count == 0 && dgvReporte2.Rows.Count == 0 && dgvReporte3.Rows.Count == 0)
            {
                MessageBox.Show("Debe completar al menos un campo antes de generar el PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            SaveFileDialog save = new SaveFileDialog
            {
                Filter = "Archivos PDF (*.pdf)|*.pdf",
                Title = "Guardar archivo PDF",
                FileName = $"ReciboTotales_{cboReporteInquilino.SelectedItem}_.pdf"
            };

            if (save.ShowDialog() != DialogResult.OK)
                return;

            string plantilla = Properties.Resources.plantilla_html.ToString();
            string dniInquilino = cboReporteInquilino.SelectedValue?.ToString() ?? "No especificado";

            // Generar las tablas HTML con los datos de cada DataGridView
            string tablaServicios = ConvertirDGVaHTML(dgvReporte2, "servicios");
            string tablaArreglos = ConvertirDGVaHTML(dgvReporte2, "arreglos");

            // Extraer datos de dgvReporte1 y dgvReporte3
            string gastoExpensas = dgvReporte3.Rows.Count > 0 ? dgvReporte3.Rows[0].Cells[1].Value.ToString() : "0.00";
            string gastoComision = dgvReporte3.Rows.Count > 0 ? dgvReporte3.Rows[0].Cells[2].Value.ToString() : "0.00";
            string gastoAlquiler = dgvReporte1.Rows.Count > 0 ? dgvReporte1.Rows[0].Cells[2].Value.ToString() : "0.00";

            string nombreInquilinoValor = dgvReporte1.Rows.Count > 0 ? dgvReporte1.Rows[0].Cells["nombreInquilino"].Value?.ToString() ?? "" : "";
            string detallesValor = dgvReporte3.Rows.Count > 0 ? dgvReporte3.Rows[0].Cells["Detalles"].Value?.ToString() ?? "" : "";

            // Reemplazar los marcadores en la plantilla HTML
            plantilla = plantilla.Replace("@Nombre", nombreInquilinoValor);
            plantilla = plantilla.Replace("@DNI", dniInquilino);
            plantilla = plantilla.Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"));
            plantilla = plantilla.Replace("@tablaServicios", tablaServicios);
            plantilla = plantilla.Replace("@tablaArreglos", tablaArreglos);
            plantilla = plantilla.Replace("@gastoExpensas", gastoExpensas);
            plantilla = plantilla.Replace("@gastoComision", gastoComision);
            plantilla = plantilla.Replace("@gastoAlquiler", gastoAlquiler);
            plantilla = plantilla.Replace("@Detalles", detallesValor);
            plantilla = plantilla.Replace("@TOTAL", lblTotal.Text.Replace("Total: $", ""));

            try
            {
                using (FileStream stream = new FileStream(save.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    using (StringReader sr = new StringReader(plantilla))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                }

                MessageBox.Show("PDF generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private string ConvertirDGVaHTML(DataGridView dgv, string tipoTabla)
        {
            StringBuilder html = new StringBuilder();
            html.Append("<table border='1'>");

            // Encabezados
            html.Append("<tr>");
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                if (tipoTabla == "servicios" && dgv.Columns[i].HeaderText.ToLower().Contains("arreglo"))
                {
                    continue; // Omitir columna de arreglos en tabla servicios
                }
                else if (tipoTabla == "arreglos" && dgv.Columns[i].HeaderText.ToLower().Contains("servicio"))
                {
                    continue; // Omitir columna de servicios en tabla arreglos
                }

                html.Append($"<th>{dgv.Columns[i].HeaderText}</th>");
            }
            html.Append("</tr>");

            // Datos
            foreach (DataGridViewRow fila in dgv.Rows)
            {
                // Lógica para omitir filas con ambos valores vacíos
                if (tipoTabla == "servicios")
                {
                    string valorArreglo = fila.Cells["TipoArreglo"]?.Value?.ToString() ?? "";
                    string montoArreglo = fila.Cells["gastoArreglos"]?.Value?.ToString() ?? "";

                    if (string.IsNullOrWhiteSpace(valorArreglo) && string.IsNullOrWhiteSpace(montoArreglo))
                    {
                        // Verifica si al menos uno de los valores de servicio está lleno
                        string valorServicio = fila.Cells["TipoServicio"]?.Value?.ToString() ?? "";
                        string montoServicio = fila.Cells["gastoServicios"]?.Value?.ToString() ?? "";

                        if (string.IsNullOrWhiteSpace(valorServicio) && string.IsNullOrWhiteSpace(montoServicio))
                        {
                            continue; // Omitir fila si ambos arreglos y servicios están vacíos
                        }
                    }
                }
                else if (tipoTabla == "arreglos")
                {
                    string valorServicio = fila.Cells["TipoServicio"]?.Value?.ToString() ?? "";
                    string montoServicio = fila.Cells["gastoServicios"]?.Value?.ToString() ?? "";

                    if (string.IsNullOrWhiteSpace(valorServicio) && string.IsNullOrWhiteSpace(montoServicio))
                    {
                        // Verifica si al menos uno de los valores de arreglo está lleno
                        string valorArreglo = fila.Cells["TipoArreglo"]?.Value?.ToString() ?? "";
                        string montoArreglo = fila.Cells["gastoArreglos"]?.Value?.ToString() ?? "";

                        if (string.IsNullOrWhiteSpace(valorArreglo) && string.IsNullOrWhiteSpace(montoArreglo))
                        {
                            continue; // Omitir fila si ambos servicios y arreglos están vacíos
                        }
                    }
                }

                // Generar la fila HTML
                html.Append("<tr>");
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    if (tipoTabla == "servicios" && dgv.Columns[i].HeaderText.ToLower().Contains("arreglo"))
                    {
                        continue; // Omitir columna de arreglos en tabla servicios
                    }
                    else if (tipoTabla == "arreglos" && dgv.Columns[i].HeaderText.ToLower().Contains("servicio"))
                    {
                        continue; // Omitir columna de servicios en tabla arreglos
                    }

                    string valor = fila.Cells[i].Value?.ToString() ?? "";
                    html.Append($"<td>{valor}</td>");
                }
                html.Append("</tr>");
            }

            html.Append("</table>");
            return html.ToString();
        }


        private void dgvReporte1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReporte1.Columns[e.ColumnIndex].Name == "Boton1")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {  // textbox name                          name de columnas dentro de dgv

                    cboReporteInquilino.Text = dgvReporte1.Rows[indice].Cells["nombreInquilino"].Value.ToString();
                    txtMontoAlquiler.Text = dgvReporte1.Rows[indice].Cells["gastoAlquiler"].Value.ToString();
                }
            }
        }

        private void dgvReporte3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReporte3.Columns[e.ColumnIndex].Name == "Boton3")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {  // textbox name                          name de columnas dentro de dgv

                    txtPorcentaje.Text = dgvReporte3.Rows[indice].Cells["gastoComision"].Value.ToString();
                    txtExpensas.Text = dgvReporte3.Rows[indice].Cells["gastoExpensas"].Value.ToString();
                    txtDetalles.Text = dgvReporte3.Rows[indice].Cells["Detalles"].Value.ToString();

                }
            }
        }

        private void dgvReporte2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

             if (dgvReporte2.Columns[e.ColumnIndex].Name == "Boton2")
             {
                 int indice = e.RowIndex;

                 if (indice >= 0)
                 {
                     cboReporteTipoArreglo.Text = dgvReporte2.Rows[indice].Cells["tipoArreglo"].Value != null
                         ? dgvReporte2.Rows[indice].Cells["tipoArreglo"].Value.ToString()
                         : "";

                     cboTipoServicio.Text = dgvReporte2.Rows[indice].Cells["tipoServicio"].Value != null
                         ? dgvReporte2.Rows[indice].Cells["tipoServicio"].Value.ToString()
                         : "";

                     txtMontoArreglos.Text = dgvReporte2.Rows[indice].Cells["gastoArreglos"].Value != null
                         ? dgvReporte2.Rows[indice].Cells["gastoArreglos"].Value.ToString()
                         : "0"; // Si es un número, puedes poner "0"

                     txtMontoServicios.Text = dgvReporte2.Rows[indice].Cells["gastoServicios"].Value != null
                         ? dgvReporte2.Rows[indice].Cells["gastoServicios"].Value.ToString()
                         : "0"; // También puedes asignar "0" si esperas un número
                 }
             }

        }


        private void dgvReporte1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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


        private void dgvReporte3_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgvReporte2_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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


        private void dgvReporte1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EliminarFilaPorBoton(dgvReporte1, e);
        }

        private void dgvReporte2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EliminarFilaPorBoton(dgvReporte2, e);
        }

        private void dgvReporte3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EliminarFilaPorBoton(dgvReporte3, e);
        }


        private void EliminarFilaPorBoton(DataGridView dgv, DataGridViewCellEventArgs e)
        {
            // Verificar que se hizo clic en una celda válida y en la primera columna (botón)
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                if (MessageBox.Show("¿Desea eliminar esta fila?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dgv.Rows.RemoveAt(e.RowIndex);
                    CalcularTotal(); // Recalcular total después de eliminar
                }
            }
        }

        
    }
}
