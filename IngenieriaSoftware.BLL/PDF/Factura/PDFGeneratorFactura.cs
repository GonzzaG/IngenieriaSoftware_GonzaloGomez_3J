using IngenieriaSoftware.BEL.FacturaProveedor;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;

namespace IngenieriaSoftware.BLL.PDF.Factura
{
    public static class PDFGeneratorFactura
    {
        public static string ObtenerRutaPDF(this int idFactura)
        {
            string documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string carpetaDestino = Path.Combine(documentos, "PuercoArana", "PDFs");

            if (!Directory.Exists(carpetaDestino))
                Directory.CreateDirectory(carpetaDestino);

            string archivo = Path.Combine(carpetaDestino, $"FacturaProveedor_{idFactura}.pdf");
            return archivo;
        }

        public static void GenerarPDFFactura(this FacturaProveedorWithDetalles factura, string rutaArchivo)
        {
            Document doc = new Document(PageSize.A4);

            using (var stream = new FileStream(rutaArchivo, FileMode.Create))
            {
                PdfWriter.GetInstance(doc, stream);
                doc.Open();

                #region Título
                var titulo = new Paragraph(
                    $"FACTURA #{factura.NumeroFactura}",
                    new Font(Font.HELVETICA, 20, Font.BOLD)
                );
                titulo.Alignment = Element.ALIGN_CENTER;
                doc.Add(titulo);

                doc.Add(new Paragraph(" "));
                #endregion

                #region Datos generales
                doc.Add(new Paragraph($"Proveedor: {factura.RazonSocialProveedor}"));
                doc.Add(new Paragraph($"Fecha Emisión: {factura.FechaEmision:dd/MM/yyyy}"));
                doc.Add(new Paragraph($"Método de Pago: {factura.MetodoPago}"));
                doc.Add(new Paragraph($"Estado: {factura.NombreEstado}"));
                doc.Add(new Paragraph($"Observaciones: {factura.Observaciones}"));

                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                #endregion

                #region Tabla de detalles
                PdfPTable tabla = new PdfPTable(6); // columnas necesarias
                tabla.WidthPercentage = 100;

                tabla.AddCell("Producto");
                tabla.AddCell("Descripción");
                tabla.AddCell("Cantidad");
                tabla.AddCell("Precio Unit.");
                tabla.AddCell("Descuento");
                tabla.AddCell("Total Línea");

                foreach (var det in factura.Detalles)
                {
                    tabla.AddCell(det.NombreProducto);
                    tabla.AddCell(det.Descripcion);
                    tabla.AddCell(det.Cantidad.ToString("0.##"));
                    tabla.AddCell(det.PrecioUnitario.ToString("0.00"));
                    tabla.AddCell(det.Descuento.ToString("0.00"));
                    tabla.AddCell(det.TotalLinea.ToString("0.00"));
                }

                doc.Add(tabla);
                #endregion

                #region Totales
                doc.Add(new Paragraph(" "));

                doc.Add(new Paragraph($"Subtotal: {factura.Subtotal:0.00}"));
                doc.Add(new Paragraph($"Impuestos: {factura.Impuestos:0.00}"));
                doc.Add(new Paragraph($"Descuento: {factura.Descuento:0.00}"));

                var total = new Paragraph(
                    $"TOTAL: {factura.Total:0.00}",
                    new Font(Font.HELVETICA, 14, Font.BOLD)
                );
                total.Alignment = Element.ALIGN_RIGHT;
                doc.Add(total);

                #endregion

                doc.Close();
            }
        }

    }
}
