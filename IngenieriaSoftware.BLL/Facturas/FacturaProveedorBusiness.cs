using IngenieriaSoftware.BEL.FacturaProveedor;
using IngenieriaSoftware.DAL.FacturaProveedores.DataAccess;
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
            if (facturaProveedor.IdFacturaProveedor == 0)
                throw new Exception("El Id de la factura proveedor no puede ser 0.");

            if (facturaProveedor.Detalles.Count == 0)
                throw new Exception("La factura de proveedor debe contener al menos un detalle.");


            for(int i=0; i < facturaProveedor.Detalles.Count; i++)
            {

            }
            

            using (var transaccion = new TransactionScope())
            {
                //  Insertamos la factura
                int idFacturaProveedor = facturaProveedor.InsertFacturaProveedor();

                //  Insertamos los detalles de la factura
                facturaProveedor.InsertFacturaProveedorDetalles();

                transaccion.Complete();

                //  Devolvemos el Id de la factura
                return idFacturaProveedor;
            }
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
        #endregion
    }
}
