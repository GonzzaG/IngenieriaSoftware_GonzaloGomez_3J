﻿using IngenieriaSoftware.BEL.Constantes;
using System;
using System.Collections.Generic;

namespace IngenieriaSoftware.BEL
{
    public class Factura
    {
        public int FacturaId { get; set; }
        public string NumeroFactura { get; set; }
        public DateTime FechaEmision { get; set; }
        public int MesaId { get; set; }
        public int ComandaId { get; set; }
        public int? ClienteId { get; set; }
        public List<ProductoFactura> Productos { get; set; } = new List<ProductoFactura>();

        public decimal SubtotalGeneral { get; set; }
        public decimal DescuentoTotal { get; set; }
        public decimal ImpuestoTotal { get; set; }
        public decimal Propina { get; set; }
        public decimal TotalFinal { get; set; }

        public int MetodoPagoId { get; set; }
        public MedioDePago MetodoPago { get; set; }
        public EstadoFactura.Estado EstadoPago { get; set; }
        public decimal MontoPagado { get; set; }
        public decimal Cambio { get; set; }

        public string Notas { get; set; }
        public DateTime FechaCierre { get; set; }
        public bool DivisionPago { get; set; }

        public Factura()
        {
            FechaEmision = DateTime.Now;
            EstadoPago = EstadoFactura.Estado.Solicitada;
        }
    }
}