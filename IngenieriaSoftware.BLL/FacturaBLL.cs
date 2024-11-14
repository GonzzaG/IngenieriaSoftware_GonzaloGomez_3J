using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Constantes;
using IngenieriaSoftware.BEL.Negocio;
using IngenieriaSoftware.DAL.EntityDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public Factura GenerarFactura(int comandaId, int mesaId, decimal propina, decimal descuento, int metodoPagoId)
        {
            List<ComandaProducto> productosComanda = _comandaBLL.ObtenerComandaProductoPorComandaId(comandaId);

            if (productosComanda == null || !productosComanda.Any())
            {
                throw new Exception("No se encontraron productos para la comanda especificada.");
            }

            List<ProductoFactura> productosFactura = productosComanda.Select(p => new ProductoFactura
            {
                ProductoId = p.ProductoId,
                NombreProducto = p.Producto.Nombre,
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

            // Crear la instancia de Factura
            Factura factura = new Factura
            {
                NumeroFactura = GenerarNumeroFactura(),
                FechaEmision = DateTime.Now,
                MesaId = mesaId,
                ComandaId = comandaId,
                Productos = productosFactura,
                SubtotalGeneral = subtotalGeneral,
                DescuentoTotal = descuentoTotal,
                ImpuestoTotal = impuestoTotal,
                Propina = propina,
                TotalFinal = totalFinal,
                MetodoPagoId = medioDePago.MedioDePagoId,  
                MetodoPago = medioDePago, 
                EstadoPago = EstadoFactura.Estado.Solicitada,
                MontoPagado = 0,
                Cambio = 0,
                Notas = "Generada automáticamente",
                DivisionPago = false
            };

            _facturaDAL.GuardarFactura(factura);

            return factura;
        }
        private string GenerarNumeroFactura()
        {
            return $"FAC-{DateTime.Now:yyyyMMddHHmmss}";
        }

    }
}
