using IngenieriaSoftware.BEL.Negocio;
using System;
using System.Data;
using System.Data.SqlClient;

namespace IngenieriaSoftware.DAL.EntityDAL
{
    public class ClienteDAL
    {
        private readonly DAO _dao = new DAO();

        public int InsertarCliente(Cliente cliente)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Nombre", cliente.Nombre),
                    new SqlParameter("@Apellido", cliente.Apellido),
                    new SqlParameter("@Email", cliente.Email),
                    new SqlParameter("@Telefono", cliente.Telefono),
                    new SqlParameter("@Direccion", cliente.Direccion)
                };

                DataSet ds = _dao.ExecuteStoredProcedure("sp_InsertarCliente", parametros);

                int clienteId = Convert.ToInt32(ds.Tables[0].Rows[0]["ClienteId"]);

                return clienteId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertarClienteConDatosBancarios(Cliente cliente)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Nombre", cliente.Nombre),
                    new SqlParameter("@Apellido", cliente.Apellido),
                    new SqlParameter("@Email", cliente.Email),
                    new SqlParameter("@Telefono", cliente.Telefono),
                    new SqlParameter("@Direccion", cliente.Direccion),
                    new SqlParameter("@NumeroTarjetaUltimos4", cliente.numeroTarjetaUltimos4),
                    new SqlParameter("@BancoEmisor", cliente.BancoEmisor),
                    new SqlParameter("@TipoTarjeta", cliente.TipoTarjeta),
                };

                DataSet ds = _dao.ExecuteStoredProcedure("sp_InsertarClienteConDatosBancarios", parametros);

                int clienteId = Convert.ToInt32(ds.Tables[0].Rows[0]["ClienteId"]);

                return clienteId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}