namespace IngenieriaSoftware.BEL.Constantes
{
    public enum OrdenCompraEstadoEnum
    {
        // Estado inicial al crear la orden de compra
        Pendiente = 1,
        // Una vez que la orden de compra es aprobada por el gerente de compras
        Aprobada = 2,
        // Si la orden de compra es rechazada por el gerente de compras
        Rechazada = 3,
        // Una vez generada la factura a partir de la orden de compra, se marca como recibida
        Recibida = 4,
        // Si la orden de compra es cancelada por el usuario antes de ser aprobada
        Cancelada = 5,
        // Una vez se registro en el inventario el ingreso de los productos comprados, se marca la orden como registrada
        Registrada = 6
    }
    
}
