using IngenieriaSoftware.BEL;
using IngenieriaSoftware.DAL.Mapper;
using IngenieriaSoftware.Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    new SqlParameter("@fecha_reserva", mesa.FechaReserva),
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
        public void ModificarMesa(Mesa mesa)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@mesa_id", mesa.MesaId),
                    new SqlParameter("@capacidadMaxima", mesa.CapacidadMaxima),
                    new SqlParameter("@estado_mesa", (int)mesa.EstadoMesa)
                };
                _dao.ExecuteNonQuery("sp_ModificarMesa", parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
