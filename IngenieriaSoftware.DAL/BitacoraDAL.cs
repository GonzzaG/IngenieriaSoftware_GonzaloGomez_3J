using IngenieriaSoftware.BEL;
using IngenieriaSoftware.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace IngenieriaSoftware.DAL
{
    public class BitacoraDAL
    {
        private DAO _dao = new DAO();

        public bool RegistrarActividad(Bitacora bitacora)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@FechaHora", bitacora.FechaHora),
                    new SqlParameter("@Usuario", bitacora.Usuario),
                    new SqlParameter("@Actividad", bitacora.Actividad),
                    new SqlParameter("@InfoAdicional", bitacora.InfoAdicional),
                    new SqlParameter("@Controller", bitacora.Controller),
                    new SqlParameter("@Url", bitacora.Url),
                    new SqlParameter("@Area", bitacora.Area)
                };
                _dao.ExecuteNonQuery("sp_InsertarBitacora", parametros);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Bitacora> ObtenerRegistros(DateTime desde, DateTime hasta, string area = null)
        {
            try
            {
                DataSet ds;
                //if(area != null)
                //{
                SqlParameter[] parametros = new SqlParameter[]
                {
                        new SqlParameter("@Desde", desde),
                        new SqlParameter("@Hasta", hasta),
                        new SqlParameter("@Area", area)
                };
                ds = _dao.ExecuteStoredProcedure("sp_ConsultarBitacoraPorModulo", parametros);

                //}
                //else
                ////{
                //    SqlParameter[] parametros = new SqlParameter[]
                //    {
                //        new SqlParameter("@Desde", desde),
                //        new SqlParameter("@Hasta", hasta)
                //    };
                //    ds = _dao.ExecuteStoredProcedure("sp_ConsultarBitacora", parametros);

                ////}

                if (ds == null || ds.Tables.Count == 0)
                {
                    return new List<Bitacora>();
                }

                return new BitacoraMapper().MapearBitacoraDesdeDataSet(ds);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener registros de la bitácora: " + ex.Message, ex);
            }
        }
    }
}