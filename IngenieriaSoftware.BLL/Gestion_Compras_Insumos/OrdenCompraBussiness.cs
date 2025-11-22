using IngenieriaSoftware.BEL.Constantes;
using IngenieriaSoftware.BEL.OrdenDeCompra;
using IngenieriaSoftware.BEL.OrdenDeCompra.Models;
using IngenieriaSoftware.BEL.OrdenDeCompra.ViewModels;
using IngenieriaSoftware.DAL.Gestion_Compras_Insumos;
using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.Servicios.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace IngenieriaSoftware.BLL.Gestion_Compras_Insumos
{
    public class OrdenCompraBussiness
    {
        public void SetOrdenCompraAceptada(int idOrdenCompra)
        {
            idOrdenCompra.SetOrdenCompraAceptada(SessionManager.GetInstance.ToString());
        }

        public void SetOrdenCompraRechazada(int idOrdenCompra)
        {
            idOrdenCompra.SetOrdenCompraRechazada(SessionManager.GetInstance.ToString());
        }

        public void SetOrdenCompraRecibida(int idOrdenCompra)
        {
            idOrdenCompra.SetOrdenCompraRecibida(SessionManager.GetInstance.ToString());
        }

        /// <summary>
        /// Obtiene la lista de órdenes de compra.
        /// </summary>
        /// <returns></returns>
        public List<OrdenCompraGetListaModel> GetOrdenesCompra()
        {
            return OrdenCompraDataAccess.GetOrdenesCompra();
        }

        public OrdenCompraWithDetalles GetOrdenCompraByNumero(string numOrdenCompra)
        {
            return numOrdenCompra.GetOrdenCompraByNumero();
        }

        public OrdenCompraWithDetalles GetOrdenCompraById(int idOrdenCompra)
        {
             return idOrdenCompra.GetOrdenCompraById();
        }

        public List<OrdenCompraGetListaModel> GetOrdenesCompra(OrdenCompraQuery query)
        {
            PrepararQuery(query);

            return query.GetOrdenesCompraDataAccess();
        }

        private static void PrepararQuery(OrdenCompraQuery query)
        {
            if (query.IdEstado == 0) query.IdEstado = null;
            if (query.NumOrdenCompra.Empty()) query.NumOrdenCompra = null;
        }

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
            ordenCompra.Estado = OrdenCompraEstadoEnum.Pendiente;
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
            ordenCompra.NumOrdenCompra.OrdenCompraExist();
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

        private void ValidarDetalle(ConvertirDetallesAprobacionDataSet detalle)
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
