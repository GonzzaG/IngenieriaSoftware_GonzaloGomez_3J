namespace IngenieriaSoftware.BEL.Constantes
{
     public enum FacturaEstadoEnum
    {
        // Estado inicial al crear la factura
        Pendiente = 1,
        // Se puede pagar la factura
        Pagada = 2,
        // Se puede cancelar la factura en caso de que esta no haya sido pagada
        Cancelada = 3,
        // Se puede marcar como anulada una factura si esta se encuentra pagada y se anulo
        Anulada = 4,
    }
}
