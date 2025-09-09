using IngenieriaSoftware.BEL.Proveedor;
using IngenieriaSoftware.DAL.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace IngenieriaSoftware.DAL.Proveedores
{
    public class ProveedorDataAccess
    {
        private DAO _dao;

        public ProveedorDataAccess()
        {
            _dao = new DAO();
        }

        public List<Proveedor> GetAll()
        {
            var dt = _dao.ExecuteStoredProcedure("Proveedor.sp_Proveedor_ObtenerTodos", null);

            var proveedores = new List<Proveedor>();

            if (dt.Tables[0].Rows.Count == 0)
                return proveedores = null;

            foreach (DataRow row in dt.Tables[0].Rows)
            {
                Proveedor proveedor = ProveedorMapper.MappearDesdeDatarow(row);

                proveedores.Add(proveedor);
            }

            return proveedores;
        }

        public Proveedor GetById(int Id)
        {
            try
            {
                var parametros = new SqlParameter[]
                {
                    new SqlParameter("@Id", Id)

                };

                var dt = _dao.ExecuteStoredProcedure("Proveedor.sp_Proveedor_ObtenerPorId", parametros);

                dt.esValido();          

                var proveedor = ProveedorMapper.MappearDesdeDatarow(dt.Tables[0].Rows[0]);

                return proveedor;
            }
            catch(ArgumentNullException)
            {
                return new Proveedor();
            }

        }

        public List<Proveedor> GetByRazonSocial(string razonSocial)
        {
            try
            {
                var parametros = new SqlParameter[]
                {
                    new SqlParameter("@RazonSocial", razonSocial)

                };

                var dt = _dao.ExecuteStoredProcedure("Proveedor.sp_Proveedor_ObtenerPorNombre", parametros);

                var proveedores = new List<Proveedor>();

                if (dt.EstaVacio())
                    return new List<Proveedor>();   

                foreach (DataRow row in dt.Tables[0].Rows)
                {
                    Proveedor proveedor = ProveedorMapper.MappearDesdeDatarow(row);

                    proveedores.Add(proveedor);
                }

                return proveedores;
            }
            catch (ArgumentNullException)
            {
                return new List<Proveedor>();
            }

        }

        public void DeleteById(int Id)
        {
            var parametros = new SqlParameter[]
            {
                new SqlParameter("@Id", Id)

            };

            var dt = _dao.ExecuteStoredProcedure("Proveedor.sp_Proveedor_Eliminar", parametros);
        }

        public int SaveOrUpdate(Proveedor proveedor)
        {

            bool esInsert = proveedor.IdProveedor == 0 ? true : false;

            string procedure;
            SqlParameter output = null;

            if (esInsert)
            {
                output = new SqlParameter("@IdProveedor", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                };

                procedure = "Proveedor.sp_Proveedor_Insertar";
            }
            else
            {
                output = new SqlParameter("@IdProveedor", proveedor.IdProveedor);

                procedure = "Proveedor.sp_Proveedor_Actualizar";
            }

            var parametros = new SqlParameter[]
            {
                new SqlParameter("@Documento",proveedor.Documento),
                new SqlParameter("@RazonSocial",proveedor.RazonSocial),
                new SqlParameter("@Correo",proveedor.Correo),
                new SqlParameter("@Telefono",proveedor.Telefono),
                new SqlParameter("@ComandaEstado",proveedor.Estado),
                output
            };

            DataSet dt = _dao.ExecuteStoredProcedure(procedure, parametros);

            return (int)output.Value;
        }



    }
}
