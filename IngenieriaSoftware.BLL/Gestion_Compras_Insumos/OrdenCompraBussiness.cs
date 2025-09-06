using IngenieriaSoftware.BEL.OrdenDeCompra;
using IngenieriaSoftware.DAL.Gestion_Compras_Insumos;
using System;
using System.Text;

namespace IngenieriaSoftware.BLL.Gestion_Compras_Insumos
{
    public class OrdenCompraBussiness
    {
        public void Guardar(OrdenDeCompraModel ordenCompra)
        {
            Validar(ordenCompra);   
            ordenCompra. Guardar();
        }

        #region Validaciones
        private void Validar(OrdenDeCompraModel ordenCompra)
        {
            ValidarOrdenCompra(ordenCompra);

            foreach(var detalle in ordenCompra.Detalles)
                ValidarDetalle(detalle);
        }
        private void ValidarOrdenCompra (OrdenDeCompraModel ordenCompra)
        {
            StringBuilder sb = new StringBuilder();
            if (ordenCompra.IdProveedor <= 0)
                sb.AppendLine("El proveedor es obligatorio.");
            if (ordenCompra.FechaEntregaEsperada < ordenCompra.Fecha)
                sb.AppendLine("La fecha de entrega esperada no puede ser menor a la fecha de la orden de compra.");
            if (string.IsNullOrWhiteSpace(ordenCompra.CondicionesPago))
                sb.AppendLine("Las condiciones de pago son obligatorias.");
            if (string.IsNullOrWhiteSpace(ordenCompra.Moneda))
                sb.AppendLine("La moneda es obligatoria.");
            if (ordenCompra.TipoCambio <= 0)
                sb.AppendLine("El tipo de cambio debe ser mayor a cero.");
            if (ordenCompra.TotalEsperado <= 0)
                sb.AppendLine("El total esperado debe ser mayor a cero.");
            if (sb.Length > 0)
                throw new Exception(sb.ToString());
        }   

        private void ValidarDetalle(OrdenDeCompraDetalleModel detalle)
        {
            StringBuilder sb = new StringBuilder();
            if (detalle.IdProducto <= 0)
                sb.AppendLine("El producto es obligatorio.");
            if (detalle.Cantidad <= 0)
                sb.AppendLine($"La cantidad del producto {detalle.IdProducto} debe ser mayor a cero.");
            if (detalle.PrecioUnitarioEsperado <= 0)
                sb.AppendLine($"El precio unitario de {detalle.IdProducto} debe ser mayor a cero.");
            if (detalle.DescuentoLinea < 0)
                sb.AppendLine("El descuento de línea no puede ser negativo.");
            if (sb.Length > 0)
                throw new Exception(sb.ToString());
        }   
        #endregion
    }
}
