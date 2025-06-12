using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Auditoria;
using IngenieriaSoftware.DAL.Auditoria;
using IngenieriaSoftware.DAL.Auditoria.Auditoria_Usuarios;
using IngenieriaSoftware.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;

namespace IngenieriaSoftware.DAL
{
    public class AuditoriaRepositoryViejo
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
                        tablas.Add(row["NombreTabla"].ToString());
                    }
                }

                return tablas;
            }
            catch
            {
                return new List<string>();
            }
        }

        public List<IAuditableModel> ObtenerRegistroDeTabla(string nombreTabla)
        {
            try
            {
                List<IAuditableModel> registros = new List<IAuditableModel>();

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter ("@NombreTabla", nombreTabla)
                };

                DataSet ds = _dao.ExecuteStoredProcedure("sp_ObtenerCambiosPorTabla", parametros);

                string[] nombreTablaSplit = nombreTabla.Split('.');
                string nombreTablaSinEsquema = "";

                if (nombreTablaSplit.Length > 1)
                    nombreTablaSinEsquema = nombreTablaSplit[nombreTablaSplit.Length - 1];

                if(nombreTablaSinEsquema.Length == 0)
                    throw new Exception("El nombre de la tabla no es válido.");

                if ( !AuditoriaMapperRegistry.TryGetMapper(nombreTablaSinEsquema, out var mapper))
                    throw new Exception($"No se encontró un mapper para la tabla '{nombreTabla}'.");

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    var registro = mapper.ConvertirDesdeRow(row);
                    if (registro != null)
                        registros.Add(registro);
                }

                return registros;
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

        public List<PeticionRestauracionModel> ObtenerPeticionesPendientes()
        {
            try
            {
                DataSet ds = _dao.ExecuteStoredProcedure("audit.sp_ObtenerPeticionesDeRestauracionPendientes", null);

                if (ds == null || ds.Tables.Count == 0)
                {
                    return new List<PeticionRestauracionModel>();
                }


                return Auditoria.PeticionRestauracionMapper.MappearDesdeDataSet(ds);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}