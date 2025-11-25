using IngenieriaSoftware.BEL.OrdenDeCompra.ViewModels;
using System;

namespace IngenieriaSoftware.BLL.PDF.OrdenCompra
{
    public static class OrdenCompraGenerarPDF
    {
        public static string GenerarPdf(this OrdenCompraWithDetalles orden)
        {
            try
            {
                string rutaFinal = orden.IdOrdenCompra.ObtenerRutaPDF();

                orden.GenerarPDFOrdenCompra(rutaFinal);

                return $"PDF generado en:\n{rutaFinal}";

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
