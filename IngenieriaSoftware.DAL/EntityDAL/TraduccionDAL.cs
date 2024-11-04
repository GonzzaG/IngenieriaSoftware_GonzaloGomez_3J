using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL
{
    public class TraduccionDAL 
    {
        private readonly DAO _dao;
        public Dictionary<string, string> _traducciones;



        public TraduccionDAL()
        {
            _dao = new DAO();
            _traducciones = new Dictionary<string, string>();
        }

        #region Traduccion

        public Dictionary<string, string> ObtenerTraduccionesPorIdioma(int idiomaId)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@idiomaId", idiomaId)
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerTraduccionesPorIdioma", parametros);
                _traducciones = new TraduccionMapper().MapearTraduccionesPorIdiomaDesdeDataSet(mDs);


                return _traducciones;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener traducciones por idioma.", ex);
            }
        }

        #endregion


    }
}
