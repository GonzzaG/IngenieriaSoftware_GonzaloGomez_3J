using IngenieriaSoftware.BEL.Common;
using IngenieriaSoftware.BEL.FacturaProveedor;
using IngenieriaSoftware.BEL.OrdenDeCompra.Models;
using IngenieriaSoftware.BLL.Gestion_Compras_Insumos;
using IngenieriaSoftware.DAL.FacturaProveedores.DataAccess;
using IngenieriaSoftware.DAL.ListSimpleDataAccess;
using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.Servicios.Tools;
using System;
using System.Collections.Generic;
using System.Transactions;

namespace IngenieriaSoftware.BLL.Facturas
{
    public class FacturaProveedorBusiness
    {
        private enum EstadoFacturaProveedor
        {
            Pendiente = 1,
            Pagada = 2,
            Cancelada = 3,
            Anulada = 4
        }

        /// <summary>
        /// Insertamos una nueva factura de proveedor junto con sus detalles
        /// </summary>
        /// <param name="facturaProveedor"></param>
        /// <returns>Id de la factura</returns>
        public int CrearFacturaProveedor(FacturaProveedor facturaProveedor)
        {
            #region Paso 1: Validaciones
            if (facturaProveedor.Detalles.Count == 0)
                throw new Exception("La factura de proveedor debe contener al menos un detalle.");

            if (!facturaProveedor.IdOrdenCompra.HasValue)
                throw new Exception("La factura de proveedor debe estar asociada a una orden de compra.");
            #endregion

            #region Paso 2: Colocar factura como pendiente
            //  Establecemos el estado inicial de la factura como Pendiente
            facturaProveedor.IdFacturaProveedorEstado = (int)EstadoFacturaProveedor.Pendiente;
            #endregion

            #region  Paso 2.1: Obtenemos el usuario actual
            facturaProveedor.IdUsuarioCreador = SessionManager.GetInstance.Usuario.Id;
            #endregion

            #region Paso 3: Insercion de Factura y detalles
            using (var transaccion = new TransactionScope())
            {
                //  Insertamos la factura y retornamos el id de la factura generada 
                facturaProveedor.IdFacturaProveedor = facturaProveedor.InsertFacturaProveedor();

                //  Insertamos los detalles de la factura
                facturaProveedor.InsertFacturaProveedorDetalles();

                // Colocamos la Orden de compra asociada a la factura como Recibida
                new OrdenCompraBussiness().SetOrdenCompraRecibida((int)facturaProveedor.IdOrdenCompra);

                transaccion.Complete();

                //  Devolvemos el Id de la factura
                return facturaProveedor.IdFacturaProveedor;
            }

            #endregion
        }

        #region Cambio estado de factura proveedor

        /// <summary>
        /// Cambia el estado de una factura de proveedor a Anulada.
        /// </summary>
        /// <param name="idFacturaProveedor"></param>
        public void CambiarEstadoFacturaProveedorAnulada(int idFacturaProveedor)
        {
            idFacturaProveedor.CambiarEstadoFacturaProveedorTo((int)EstadoFacturaProveedor.Anulada);
        }

        /// <summary>
        /// Cambia el estado de una factura de proveedor a Cancelada.
        /// </summary>
        /// <param name="idFacturaProveedor"></param>
        public void CambiarEstadoFacturaProveedorCancelada(int idFacturaProveedor)
        {
            idFacturaProveedor.CambiarEstadoFacturaProveedorTo((int)EstadoFacturaProveedor.Cancelada);
        }

        /// <summary>
        /// Cambia el estado de una factura de proveedor a Pagada.
        /// </summary>
        /// <param name="idFacturaProveedor"></param>
        public void CambiarEstadoFacturaProveedorPagada(int idFacturaProveedor)
        {
            idFacturaProveedor.CambiarEstadoFacturaProveedorTo((int)EstadoFacturaProveedor.Pagada);
        }

        /// <summary>
        /// Cambia el estado de una factura de proveedor a Pendiente.
        /// </summary>
        /// <param name="idFacturaProveedor"></param>
        public void CambiarEstadoFacturaProveedorPendiente(int idFacturaProveedor)
        {
            idFacturaProveedor.CambiarEstadoFacturaProveedorTo((int)EstadoFacturaProveedor.Pendiente);
        }

        #endregion

        /// <summary>
        /// Obtiene el detalle de las facturas pendientes de pago.
        /// </summary>
        /// <param name="idFacturaProveedor"></param>
        /// <returns></returns>
        public List<FacturaProveedorDetalle> GetListDetallesByIdFacturaProveedor(int idFacturaProveedor)
        {
            return idFacturaProveedor.GetListDetallesByIdFacturaProveedor();
        }

        /// <summary>
        /// Obtiene el nombre del estado de la factura de proveedor por su Id.
        /// </summary>
        /// <param name="idEstadoFacturaProveedor"></param>
        /// <returns></returns>
        public string GetEstadoFacturaProveedorById(int idEstadoFacturaProveedor)
        {
            return Enum.GetName(typeof(EstadoFacturaProveedor), idEstadoFacturaProveedor);
        }

        public FacturaProveedor GetFacturaProveedorByIdOrdenCompra(int idOrdenCompra)
        {
            return idOrdenCompra.GetFacturaProveedorByIdOrdenCompra() ??
                throw new Exception("No se encontró una factura asociada a la orden de compra.");
        }

        /// <summary>
        /// Obtiene una Factura de Proveedor por su Id.
        /// </summary>
        /// <param name="idFacturaProveedor"></param>
        /// <returns></returns>
        public FacturaProveedor GetFacturaProveedorById(int idFacturaProveedor)
        {
            return idFacturaProveedor.GetFacturaProveedorById()
                ?? throw new Exception("La factura no existe."); ;
        }


        #region Obtener Facturas por Estado
        public List<FacturaProveedorGetListModel> ObtenerFacturasPendientes()
        {
            return FacturaProveedorDataAccess.GetListFacturasPendientes(EstadoFacturaProveedor.Pendiente.ToString());
        }

        public List<FacturaProveedorGetListModel> ObtenerFacturasPagadas()
        {
            return FacturaProveedorDataAccess.GetListFacturasPagadas(EstadoFacturaProveedor.Pagada.ToString());
        }

        public List<FacturaProveedorGetListModel> ObtenerFacturasCanceladas()
        {
            return FacturaProveedorDataAccess.GetListFacturasCanceladas(EstadoFacturaProveedor.Cancelada.ToString());
        }

        public List<FacturaProveedorGetListModel> ObtenerFacturasAnuladas()
        {
            return FacturaProveedorDataAccess.GetListFacturasAnuladas(EstadoFacturaProveedor.Anulada.ToString());
        }

        public List<FacturaProveedorGetListFilterModel> GetListFacturas(ObjectQuery query)
        {
            PrepararQuery(query);
            return FacturaProveedorDataAccess.GetListFacturas(query);
        }

        private void PrepararQuery(ObjectQuery query)
        {
            if (query.IdEstado == 0) query.IdEstado = null;
            if (query.Numero.Empty()) query.Numero = null;
        }
        #endregion
    }
}
