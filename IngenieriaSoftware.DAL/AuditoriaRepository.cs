using IngenieriaSoftware.BEL;
using IngenieriaSoftware.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace IngenieriaSoftware.DAL
{
    public class AuditoriaRepository
    {
        private DAO _dao = new DAO();

        public List<string> ObtenerTablasAuditadas()
        {
            try
            {
                List<string> tablas = new List<string>();

                using (var dt = _dao.ExecuteStoredProcedure("sp_ObtenerTablasAuditadas", null))
                {
                    foreach (DataRow row in dt.Tables[0].Rows)
                    {
                        tablas.Add(row["Tabla"].ToString());
                    }
                }

                return tablas;
            }
            catch
            {
                return new List<string>();
            }
        }

        public List<AuditoriaRegistro> ObtenerRegistroDeTabla(string nombreTabla)
        {
            try
            {
                List<AuditoriaRegistro> tablas = new List<AuditoriaRegistro>();

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter ("@NombreTabla", nombreTabla)
                };
                DataSet dt = _dao.ExecuteStoredProcedure("sp_ObtenerCambiosPorTabla", parametros);

                return new AuditoriaMapper().MapearDesdeDataSet(dt);
            }
            catch (InvalidCastException ex)
            {
                throw new Exception("La tabla no tiene cambios que mostrar");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<AuditoriaDetalle> ObtenerDetalleCambio(Guid idCambio)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdCambio", idCambio)
                };

                DataSet ds = _dao.ExecuteStoredProcedure("sp_ObtenerDetalleCambio", parametros);

                if (ds == null || ds.Tables.Count == 0)
                {
                    return new List<AuditoriaDetalle>();
                }

                return new AuditoriaDetalleMapper().MapearDetalleDesdeDataSet(ds);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<AuditoriaDetalle> ObtenerDetalleCambio(string tabla, int registro)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Tabla", tabla),
                    new SqlParameter("@Registro", registro)
                };

                DataSet ds = _dao.ExecuteStoredProcedure("sp_ObtenerEstadoActualRegistroPorTablaYRegistro", parametros);

                if (ds == null || ds.Tables.Count == 0)
                {
                    return new List<AuditoriaDetalle>();
                }

                return new AuditoriaDetalleMapper().MapearDetallesActualesDesdeDataSet(ds);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool SolicitarRestauracion(PeticionRestauracion peticion)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Tabla", peticion.Tabla),
                    new SqlParameter("@UsuarioSolicitante", peticion.UsuarioSolicitante),
                    new SqlParameter("@IdCambio", peticion.IdCambioOrigen),
                    new SqlParameter("@Registro", peticion.Registro),
                    new SqlParameter("@Comentario", peticion.Comentario)
                };

                _dao.ExecuteNonQuery("sp_CrearPeticionRestauracion", parametros);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool AceptarPeticionDeRestauracion(int idPeticion, string usuarioAutorizador)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdPeticion", idPeticion),
                    new SqlParameter("@UsuarioAutorizador", usuarioAutorizador)
                };

                _dao.ExecuteNonQuery("sp_AceptarPeticionRestauracionExtension", parametros);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool RechazarPeticionDeRestauracion(int idPeticion)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdPeticion", idPeticion),
                };

                _dao.ExecuteNonQuery("sp_RechazarPeticionRestauracion", parametros);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<PeticionRestauracion> ObtenerPeticionesPendientes()
        {
            try
            {
                DataSet ds = _dao.ExecuteStoredProcedure("sp_ObtenerPeticionesPendientes", null);

                if (ds == null || ds.Tables.Count == 0)
                {
                    return new List<PeticionRestauracion>();
                }
                return PeticionRestauracionMapper.MapearDesdeDataRow(ds);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}