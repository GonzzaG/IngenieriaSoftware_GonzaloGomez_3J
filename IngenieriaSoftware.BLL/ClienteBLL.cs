using IngenieriaSoftware.BEL.Negocio;
using IngenieriaSoftware.DAL.EntityDAL;
using System.Transactions;

namespace IngenieriaSoftware.BLL
{
    public class ClienteBLL
    {
        public readonly ClienteDAL _clienteDAL = new ClienteDAL();

        public int InsertarCliente(Cliente cliente)
        {
            int clienteId;

            using (var transaccion = new TransactionScope())
            {
                if (cliente.numeroTarjetaUltimos4 != string.Empty)
                {
                    clienteId = _clienteDAL.InsertarClienteConDatosBancarios(cliente);
                }
                else
                {
                    clienteId = _clienteDAL.InsertarCliente(cliente);
                }

                transaccion.Complete();

            }
            new BackupManager().Backup();

            return clienteId;
        }
    }
}