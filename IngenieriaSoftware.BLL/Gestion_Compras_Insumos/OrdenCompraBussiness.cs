using IngenieriaSoftware.BEL.Constantes;
using IngenieriaSoftware.BEL.OrdenDeCompra;
using IngenieriaSoftware.DAL.Gestion_Compras_Insumos;
using IngenieriaSoftware.Servicios;
using System;
using System.Text;

namespace IngenieriaSoftware.BLL.Gestion_Compras_Insumos
{
    public class OrdenCompraBussiness
    {
        public void Guardar(OrdenDeCompraModel ordenCompra)
        {
            Validar(ordenCompra);
            SetDatosExtra(ordenCompra);
            ordenCompra.Guardar();
        }

        private static void SetDatosExtra(OrdenDeCompraModel ordenCompra)
        {
            ordenCompra.FechaCreacion = DateTime.Now;
            ordenCompra.UsuarioCreacion = SessionManager.GetInstance.Usuario.Username;
            ordenCompra.Estado = OrdenCompraEstado.Pendiente;
        }

        #region Validaciones
        private void Validar(OrdenDeCompraModel ordenCompra)
        {
            OrdenCompraIsValid(ordenCompra);

            DetallesIsValid(ordenCompra);

            ValidarOrdenCompraExists(ordenCompra);
        }

        private void DetallesIsValid(OrdenDeCompraModel ordenCompra)
        {
            if(ordenCompra.Detalles.Count == 0)
                throw new Exception("La orden de compra debe tener al menos un detalle.");  

            for (int i = 0; i < ordenCompra.Detalles.Count; i++)
                ValidarDetalle(ordenCompra.Detalles[i]);
        }

        private static void ValidarOrdenCompraExists(OrdenDeCompraModel ordenCompra)
        {
            OrdenCompraDataAccess.OrdenCompraExist(ordenCompra.NumOrdenCompra);
        }

        private void OrdenCompraIsValid (OrdenDeCompraModel ordenCompra)
        {
            StringBuilder sb = new StringBuilder();
            if(ordenCompra.NumOrdenCompra.Equals(string.Empty))
                sb.AppendLine("- El número de orden de compra es obligatorio.");
            if (ordenCompra.IdProveedor <= 0)
                sb.AppendLine("- El proveedor es obligatorio.");
            if (ordenCompra.FechaEntregaEsperada < ordenCompra.Fecha)
                sb.AppendLine("- La fecha de entrega esperada no puede ser menor a la fecha de la orden de compra.");
            if (string.IsNullOrWhiteSpace(ordenCompra.Moneda))
                sb.AppendLine("- La moneda es obligatoria.");
            if (ordenCompra.TotalEsperado <= 0)
                sb.AppendLine("- El total esperado debe ser mayor a cero.");
            if (sb.Length > 0)
                throw new Exception(sb.ToString());
        }   

        private void ValidarDetalle(OrdenDeCompraDetalleModel detalle)
        {
            StringBuilder sb = new StringBuilder();
            if (detalle.IdProducto <= 0)
                sb.AppendLine("- El producto es obligatorio.");
            if (detalle.Cantidad <= 0)
                sb.AppendLine($"- La cantidad del producto {detalle.IdProducto} debe ser mayor a cero.");
            if (detalle.PrecioUnitarioEsperado <= 0)
                sb.AppendLine($"- El precio unitario de {detalle.IdProducto} debe ser mayor a cero.");
            if (detalle.DescuentoLinea < 0)
                sb.AppendLine("- El descuento de línea no puede ser negativo.");
            if (sb.Length > 0)
                throw new Exception(sb.ToString());
        }   
        #endregion
    }
}
