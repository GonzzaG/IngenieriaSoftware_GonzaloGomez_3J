using IngenieriaSoftware.BEL;
using IngenieriaSoftware.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace IngenieriaSoftware.DAL.EntityDAL
{
    public class MesaDAL
    {
        private readonly DAO _dao = new DAO();
        private readonly MesaMapper _mesaMapper = new MesaMapper();

        public List<Mesa> GuardarMesa(Mesa mesa)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@mesa_id", mesa.MesaId),
                    new SqlParameter("@capacidadMaxima", mesa.CapacidadMaxima),
                    new SqlParameter("@estado_mesa", (int)mesa.EstadoMesa)
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_GuardarMesa", parametros);

                return _mesaMapper.MapearMesasDesdeDataSet(mDs);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Mesa> ObtenerTodasLasMesas()
        {
            try
            {
                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerTodasLasMesas", null);
                return _mesaMapper.MapearMesasDesdeDataSet(mDs);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Mesa> ObtenerMesasDisponibles(int estadoFueraDeServicio)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@estadoMesa", estadoFueraDeServicio)
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerMesasDisponibles", parametros);
                return _mesaMapper.MapearMesasDesdeDataSet(mDs);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Mesa> ObtenerMesasPorEstado(int estado)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@estadoMesa", estado)
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerMesasPorEstado", parametros);
                return _mesaMapper.MapearMesasDesdeDataSet(mDs);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Mesa ObtenerMesaDisponiblePorId(int mesaId, int estadoFueraDeServicio)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@mesa_id", mesaId),
                    new SqlParameter("@estadoMesa", estadoFueraDeServicio)
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerMesaDisponiblePorId", parametros);
                return _mesaMapper.MapearMesasDesdeDataSet(mDs).FirstOrDefault(m => m.MesaId == mesaId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarMesa(int mesaId)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@mesa_id", mesaId)
                };

                _dao.ExecuteNonQuery("sp_EliminarMesa", parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int AsignarMesa(int mesaId)
        {
            try
            {
                SqlParameter retornoParametro = new SqlParameter();
                retornoParametro.Direction = ParameterDirection.ReturnValue;
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@mesa_id", mesaId),
                    new SqlParameter("@numero_estado_asignado", (int)EstadoMesa.Estado.Ocupada),
                    retornoParametro
                };

                _dao.ExecuteNonQuery("sp_AsignarMesa", parametros);
                return (int)retornoParametro.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CambiarEstadoMesaCerrada(int mesaId)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@mesa_id", mesaId),
                };

                _dao.ExecuteNonQuery("sp_CambiarEstadoMesaCerrada", parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CambiarEstadoMesa(int mesaId, int estado)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@MesaId ", mesaId),
                    new SqlParameter("@EstadoMesa ", estado),
                };

                _dao.ExecuteNonQuery("sp_CambiarEstadoMesa", parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}