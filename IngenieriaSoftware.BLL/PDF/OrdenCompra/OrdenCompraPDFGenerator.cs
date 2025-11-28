using IngenieriaSoftware.BEL.OrdenDeCompra.ViewModels;
using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace IngenieriaSoftware.BLL.PDF
{
    public static class OrdenCompraPDFGenerator
    {
        public static string ObtenerRutaPDF(this int idOrden)
        {
            // Carpeta Documentos\Sitema\PDFs
            string documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string carpetaDestino = Path.Combine(documentos, "PuercoArana", "PDFs");

            if (!Directory.Exists(carpetaDestino))
                Directory.CreateDirectory(carpetaDestino);

            string archivo = Path.Combine(carpetaDestino, $"OrdenCompra_{idOrden}.pdf");
            return archivo;
        }

        public static void GenerarPDFOrdenCompra(this OrdenCompraWithDetalles orden, string rutaArchivo)
        {
            Document doc = new Document(PageSize.A4);

            using (var stream = new FileStream(rutaArchivo, FileMode.Create))
            {
                PdfWriter.GetInstance(doc, stream);
                doc.Open();

                #region Título de la orden
                var titulo = new Paragraph(
                    $"ORDEN DE COMPRA #{orden.NumOrdenCompra}",
                    new Font(Font.HELVETICA, 20, Font.BOLD)
                );
                titulo.Alignment = Element.ALIGN_CENTER;
                doc.Add(titulo);

                doc.Add(new Paragraph(" "));
                #endregion

                #region Datos generales de la orden
                doc.Add(new Paragraph($"Proveedor: {orden.RazonSocialProveedor}"));
                doc.Add(new Paragraph($"Fecha: {orden.Fecha:dd/MM/yyyy}"));
                doc.Add(new Paragraph($"Entrega Esperada: {orden.FechaEntregaEsperada?.ToString("dd/MM/yyyy") ?? "No especificada"}"));
                doc.Add(new Paragraph($"Moneda: {orden.Moneda}"));
                doc.Add(new Paragraph($"Condiciones de Pago: {orden.CondicionesPago}"));
                doc.Add(new Paragraph($"Estado: {orden.Estado}"));
                doc.Add(new Paragraph($"Observaciones: {orden.Observaciones}"));

                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                #endregion

                #region Tabla de detalles
                PdfPTable tabla = new PdfPTable(5); // 5 columnas
                tabla.WidthPercentage = 100;

                tabla.AddCell("Producto");
                tabla.AddCell("Cantidad");
                tabla.AddCell("Precio Unit.");
                tabla.AddCell("Descuento");
                tabla.AddCell("Subtotal");

                foreach (var det in orden.Detalles)
                {
                    tabla.AddCell(det.NombreProducto);
                    tabla.AddCell(det.Cantidad.ToString());
                    tabla.AddCell(det.PrecioUnitarioEsperado?.ToString("0.00") ?? "-");
                    tabla.AddCell(det.DescuentoLinea?.ToString("0.00") ?? "-");
                    tabla.AddCell(det.Subtotal?.ToString("0.00") ?? "0.00");
                }

                doc.Add(tabla);
                #endregion

                #region Total Final
                doc.Add(new Paragraph(" "));
                var total = new Paragraph(
                    $"TOTAL ESPERADO: {orden.TotalEsperado.ToString("0.00")}",
                    new Font(Font.HELVETICA, 14, Font.BOLD)
                );
                total.Alignment = Element.ALIGN_RIGHT;
                doc.Add(total);

                doc.Close();
                #endregion
            }
        }
    }
}
