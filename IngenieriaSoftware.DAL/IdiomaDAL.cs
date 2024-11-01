using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IngenieriaSoftware.BEL;

namespace IngenieriaSoftware.DAL
{
    public class IdiomaDAL
    {
        DAO _dao;
    
        public IdiomaDAL()
        {
            _dao = new DAO();
        }

        public int AgregarEtiqueta(List<string> etiquetasMemoria)
        {
            List<Etiqueta> etiquetasBD = ObtenerTodasLasEtiquetasEnBD();

            // Llamar al método que compara y modifica etiquetasMemoria
            CompararEtiquetas(etiquetasMemoria, etiquetasBD);

            // Guardar las etiquetas restantes en la base de datos
            foreach (string etiqueta in etiquetasMemoria)
            {
                if (etiqueta.Length > 0)
                    AgregarEtiquetaEnBD(etiqueta);
            }

            return etiquetasMemoria.Count; // O el número de etiquetas que se agregaron a la base de datos
        }

        private void CompararEtiquetas(List<string> etiquetasMemoria, List<Etiqueta> etiquetasBD)
        {
            // Obtener una lista de los nombres de las etiquetas en la base de datos
            var nombresEtiquetasBD = etiquetasBD.Select(e => e.Nombre).ToList();

            // Remover etiquetas de memoria que ya existen en la base de datos
            etiquetasMemoria.RemoveAll(etiqueta => nombresEtiquetasBD.Contains(etiqueta));
        }


        private int AgregarEtiquetaEnBD(string nombre)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                new SqlParameter("@Nombre", nombre)
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_AgregarEtiqueta", parametros);
                int id = int.Parse(mDs.Tables[0].Rows[0]["etiqueta_id"].ToString());

                return id;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<Etiqueta> ObtenerTodasLasEtiquetasEnBD()
        {
            try
            {
                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerTodasLasEtiquetas", null);
               
                return new EtiquetaMapper().MapearEtiquetasDesdeDataSet(mDs); ; 
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }

    }
}
