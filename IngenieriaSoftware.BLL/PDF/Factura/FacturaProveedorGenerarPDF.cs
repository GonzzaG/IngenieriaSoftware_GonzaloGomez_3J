using IngenieriaSoftware.BEL.FacturaProveedor;
using System;

namespace IngenieriaSoftware.BLL.PDF.Factura
{
    public static class FacturaProveedorGenerarPDF
    {
        public static string GenerarPdf(this FacturaProveedorWithDetalles factura)
        {
            try
            {
                string rutaFinal = factura.IdFacturaProveedor.ObtenerRutaPDF();

                factura.GenerarPDFFactura(rutaFinal);

                return rutaFinal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
