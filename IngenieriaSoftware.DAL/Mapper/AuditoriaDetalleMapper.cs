using IngenieriaSoftware.BEL;
using System;
using System.Collections.Generic;
using System.Data;

namespace IngenieriaSoftware.DAL.Mapper
{
    public class AuditoriaDetalleMapper
    {
        public List<AuditoriaDetalle> MapearDetalleDesdeDataSet(DataSet ds)
        {
            try
            {
                List<AuditoriaDetalle> lista = new List<AuditoriaDetalle>();

                if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                    return lista;

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    var detalle = new AuditoriaDetalle
                    {
                        IdAuditoria = row["IdAuditoria"] != DBNull.Value ? Convert.ToInt32(row["IdAuditoria"]) : 0,
                        Tipo = row["Tipo"] != DBNull.Value ? row["Tipo"].ToString() : null,
                        Tabla = row["Tabla"] != DBNull.Value ? row["Tabla"].ToString() : null,
                        Registro = row["Registro"] != DBNull.Value ? Convert.ToInt32(row["Registro"]) : 0,
                        Campo = row["Campo"] != DBNull.Value ? row["Campo"].ToString() : null,
                        ValorAntes = row["ValorAntes"] != DBNull.Value ? row["ValorAntes"].ToString() : null,
                        ValorDespues = row["ValorDespues"] != DBNull.Value ? row["ValorDespues"].ToString() : null,
                        Fecha = row["Fecha"] != DBNull.Value ? Convert.ToDateTime(row["Fecha"]) : DateTime.MinValue,
                        Usuario = row["Entidad"] != DBNull.Value ? row["Entidad"].ToString() : null,
                        PC = row["PC"] != DBNull.Value ? row["PC"].ToString() : null,
                        IdCambio = row["id_cambio"] != DBNull.Value ? (Guid)row["id_cambio"] : Guid.Empty
                    };

                    lista.Add(detalle);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<AuditoriaDetalle> MapearDetallesActualesDesdeDataSet(DataSet ds)
        {
            try
            {
                List<AuditoriaDetalle> lista = new List<AuditoriaDetalle>();

                if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                    return lista;

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    var detalle = new AuditoriaDetalle
                    {
                        Tipo = row["Tipo"] != DBNull.Value ? row["Tipo"].ToString() : null,
                        Campo = row["Campo"] != DBNull.Value ? row["Campo"].ToString() : throw new Exception(),
                        ValorDespues = row["ValorActual"] != DBNull.Value ? row["ValorActual"].ToString() : null,
                        Fecha = row["Fecha"] != DBNull.Value ? Convert.ToDateTime(row["Fecha"]) : DateTime.MinValue,
                        Usuario = row["Entidad"] != DBNull.Value ? row["Entidad"].ToString() : null,
                        PC = row["PC"] != DBNull.Value ? row["PC"].ToString() : null,
                    };

                    lista.Add(detalle);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}