using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Constantes;
using IngenieriaSoftware.BEL.Negocio;
using IngenieriaSoftware.DAL.EntityDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Transactions;

namespace IngenieriaSoftware.BLL
{
    public class FacturaBLL
    {
        private readonly FacturaDAL _facturaDAL = new FacturaDAL();
        private readonly ComandaBLL _comandaBLL = new ComandaBLL();
        private readonly MedioDePagoBLL _medioDePagoBLL = new MedioDePagoBLL();

        private Factura Factura;

        public FacturaBLL()
        {
            Factura = new Factura();
        }

        public Factura GenerarFactura(int comandaId, int mesaId, decimal propina, decimal descuento, int metodoPagoId, int clienteId)
        {
            List<ComandaProducto> productosComanda = _comandaBLL.ObtenerComandaProductoProductoPorComandaId(comandaId);

            if (productosComanda == null || !productosComanda.Any())
            {
                throw new Exception("No se encontraron productos para la comanda especificada.");
            }

            List<ProductoFactura> productosFactura = productosComanda.Select(p => new ProductoFactura
            {
                ProductoId = p.ProductoId,
                NombreProducto = p.Nombre,
                Cantidad = p.Cantidad,
                PrecioUnitario = p.PrecioUnitario
            }).ToList();

            decimal subtotalGeneral = productosFactura.Sum(p => p.Subtotal);
            decimal descuentoTotal = subtotalGeneral * (descuento / 100);
            decimal impuestoTotal = (subtotalGeneral - descuentoTotal) * 0.21m;
            decimal totalFinal = subtotalGeneral - descuentoTotal + impuestoTotal + propina;

            MedioDePago medioDePago = _medioDePagoBLL.ObtenerMedioDePagoPorId(metodoPagoId);

            if (medioDePago == null)
            {
                throw new Exception("El medio de pago especificado no existe.");
            }

            Factura factura = new Factura
            {
                NumeroFactura = GenerarNumeroFactura(),
                FechaEmision = DateTime.Now,
                MesaId = mesaId,
                ComandaId = comandaId,
                ClienteId = clienteId,
                Productos = productosFactura,
                SubtotalGeneral = subtotalGeneral,
                DescuentoTotal = descuentoTotal,
                ImpuestoTotal = impuestoTotal,
                Propina = propina,
                TotalFinal = totalFinal,
                MetodoPagoId = medioDePago.MedioDePagoId,
                MetodoPago = medioDePago,
                EstadoPago = EstadoFactura.Estado.PendienteDePago,
                MontoPagado = 0,
                Cambio = 0,
                Notas = "Generada automáticamente",
                DivisionPago = false
            };

            using (var transaction = new TransactionScope())
            {
                try
                {
                    //si es 0, es porque fue en efectivo, no vamos a guardar clienteIdFactura
                    if (factura.ClienteId == 0)
                    {
                    }
                    int facturaId = _facturaDAL.GuardarFactura(factura);

                    _facturaDAL.GuardarProductosFactura(facturaId, productosFactura);

                    new BackupManager().RealizarBackup();

                    transaction.Complete();
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocurrió un error al generar la factura. Transacción revertida.", ex);
                }
            }

            return factura;
        }

        private string GenerarNumeroFactura()
        {
            return $"FAC-{DateTime.Now:yyyyMMddHHmmss}";
        }

        #region Facturas por estado

        public List<Factura> ObtenerFacturasSolicitadas()
        {
            using (var transaction = new TransactionScope())
            {
                var facturas = _facturaDAL.ObtenerFacturasPorEstado((int)EstadoFactura.Estado.Solicitada);
                transaction.Complete();
                return facturas;
            }
        }

        public List<Factura> ObtenerFacturasPenditesDePago()
        {
            using (var transaction = new TransactionScope())
            {
                var facturas = _facturaDAL.ObtenerFacturasPorEstado((int)EstadoFactura.Estado.PendienteDePago);
                transaction.Complete();
                return facturas;
            }
        }

        public List<Factura> ObtenerFacturasPagadas()
        {
            using (var transaction = new TransactionScope())
            {
                var facturas = _facturaDAL.ObtenerFacturasPorEstado((int)EstadoFactura.Estado.Pagada);
                transaction.Complete();
                return facturas;
            }
        }

        public List<Factura> ObtenerFacturasEntregadas()
        {
            using (var transaction = new TransactionScope())
            {
                var facturas = _facturaDAL.ObtenerFacturasPorEstado((int)EstadoFactura.Estado.Entregada);
                transaction.Complete();
                return facturas;
            }
        }

        #endregion Facturas por estado

        public List<string> ObtenerEstadosFactura()
        {
            var estados = new List<string>();

            estados.Add(EstadoFactura.Estado.Solicitada.ToString());
            estados.Add(EstadoFactura.Estado.PendienteDePago.ToString());
            estados.Add(EstadoFactura.Estado.Pagada.ToString());
            estados.Add(EstadoFactura.Estado.Entregada.ToString());

            return estados;
        }

        public bool FacturaPendienteDePago(int facturaId)
        {
            using (var transaction = new TransactionScope())
            {
                var factura = _facturaDAL.ObtenerFacturaPorFacturaId(facturaId);

                if (factura != null &&
                   factura.EstadoPago is EstadoFactura.Estado.PendienteDePago)
                {
                    transaction.Complete();
                    return true;
                }
                else
                {
                    transaction.Complete();
                    return false;
                }
            }
        }

        public bool FacturaSolicitada(int facturaId)
        {
            using (var transaction = new TransactionScope())
            {
                var factura = _facturaDAL.ObtenerFacturaPorFacturaId(facturaId);

                if (factura != null &&
                   factura.EstadoPago is EstadoFactura.Estado.Solicitada)
                {
                    transaction.Complete();
                    return true;
                }
                else
                {
                    transaction.Complete();
                    return false;
                }
            }
        }

        public void CambiarEstadoFacturaPagada(int facturaId)
        {
            using (var transaction = new TransactionScope())
            {
                _facturaDAL.CambiarEstadoFactura(facturaId, (int)EstadoFactura.Estado.Pagada);

                transaction.Complete();
            }
        }

        public void CambiarEstadoFacturaPendienteDePago(int facturaId)
        {
            using (var transaction = new TransactionScope())
            {
                _facturaDAL.CambiarEstadoFactura(facturaId, (int)EstadoFactura.Estado.PendienteDePago);

                transaction.Complete();
            }
        }

        public void CambiarEstadoFacturaEntregada(int facturaId)
        {
            using (var transaction = new TransactionScope())
            {
                _facturaDAL.CambiarEstadoFactura(facturaId, (int)EstadoFactura.Estado.Entregada);

                transaction.Complete();
            }
        }

        public List<ProductoFactura> ObtenerProductosPorFacturaId(int facturaId)
        {
            using (var transaction = new TransactionScope())
            {
                var productosFactura = _facturaDAL.ObtenerProductosPorFacturaId(facturaId);
                transaction.Complete();
                return productosFactura;
            }
        }

        public Factura ObtenerFacturaPorMesaYComanda(int mesaId, int comandaId)
        {
            using (var transaction = new TransactionScope())
            {
                var factura = _facturaDAL.ObtenerFacturaPorMesaYComanda(mesaId, comandaId);
                if (factura.EstadoPago != EstadoFactura.Estado.Pagada)
                {
                    factura = null;
                }
                transaction.Complete();
                return factura;
            }
        }
    }
}