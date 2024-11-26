using IngenieriaSoftware.Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL.EntityDAL
{
    public class EtiquetaDAL
    {
        private readonly DAO _dao;
        public List<EtiquetaDTO> _etiqutas;
        private EtiquetaMapper EtiquetaMapper = new EtiquetaMapper();
        public EtiquetaDAL()
        {
            _dao = new DAO();
           
        }

        public List<EtiquetaDTO> ObtenerTodasLasEtiquetas()
        {
            try
            {            
                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerTodasLasEtiquetas", null);
                _etiqutas = EtiquetaMapper.MapearEtiquetasDesdeDataSet(mDs);    

                return _etiqutas;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener traducciones por idioma.", ex);
            }
        }



    }
}
