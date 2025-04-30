using IngenieriaSoftware.BEL.Negocio;
using IngenieriaSoftware.DAL.EntityDAL;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace IngenieriaSoftware.BLL
{
    public class ClienteBLL
    {
        public readonly ClienteDAL _clienteDAL = new ClienteDAL();

        public int InsertarCliente(Cliente cliente)
        {
            using(var transaccion = new TransactionScope())
            {
                int clienteId;
                if (cliente.numeroTarjetaUltimos4 != string.Empty)
                {
                   clienteId = _clienteDAL.InsertarClienteConDatosBancarios(cliente);

                    
                }
                else
                {
                    clienteId = _clienteDAL.InsertarCliente(cliente);
                    

                }
                // Realizamos backup para guardar los cambios
                new BackupManager().RealizarBackup();

                transaccion.Complete();

                return clienteId;
            }
        }


    }
}
