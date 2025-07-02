using IngenieriaSoftware.DAL.Mapper;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace IngenieriaSoftware.DAL
{
    public class DigitoVerificadorHorizontalDAL
    {
        private readonly DAO _dao = new DAO();
        private readonly ObjetoDAL _objetoDAL = new ObjetoDAL();

        public List<string> ObtenerTablasConDVH()
        {
            try
            {
                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerTablasConDVH", null);
                List<string> tablas = new List<string>();
                foreach (DataRow row in mDs.Tables[0].Rows)
                {
                    tablas.Add(row["NombreTabla"].ToString());
                }

                return tablas;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el verificador horizontal: " + ex.Message, ex);
            }
        }

        public bool ActualizarDVHorizontalDeRegistro(string nombreTabla, string campoId, object valorId, string dvh)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Tabla", nombreTabla),
                    new SqlParameter("@CampoId", campoId),
                    new SqlParameter("@ValorId", valorId),
                    new SqlParameter("@DVH", dvh)
                };

                _dao.ExecuteStoredProcedure("sp_ActualizarDVH", parametros);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        /// <summary>
        /// Metodo que verifica la integridad de los registros de una tabla, comparando el DVH almacenado con el DVH generado.
        /// </summary>
        /// <param name="nombreTabla"></param>
        /// <returns>Lista de Digitos verificadores horizontales</returns>
        /// <exception cref="Exception"></exception>
        public List<string> VerificarIntegridadDeRegistrosDeTabla(string nombreTabla)
        {
            try
            {
                //voy a obtener los datos de la tabla parametro, voy a concatenar los valores de cada registro que no sea dvh, los sumo con generardv y los comparo con el campo DVH de cada registro

                DataSet mDs = _objetoDAL.ObtenerDatosDeTabla(nombreTabla);

                List<string> dvhGenerados = new List<string>();

                string dvhAlmacenado = string.Empty;

                foreach (DataRow row in mDs.Tables[0].Rows)
                {
                    dvhAlmacenado = (row["DVH"].ToString());

                    // Generar DVH de la fila
                    string dvhGenerado = DVMapper.GenerarDVH(row);
                    // Comparar con el DVH almacenado
                    if (dvhGenerado != dvhAlmacenado)
                    {
                        throw new Exception("El DVH almacenado no coincide con el DVH generado.");
                    }

                    dvhGenerados.Add(dvhGenerado);
                }
                if (dvhGenerados.Count > 0)
                {
                    return dvhGenerados;
                }
                else
                {
                    throw new Exception("No se pudo generar el DVH.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el verificador horizontal: " + ex.Message, ex);
            }
        }

        /// <summary>
        /// Agrega el DVH a todos los registros de la tabla que aún no lo tienen.
        /// </summary>
        public bool AgregarVerificadorHorizontal(string nombreTabla)
        {
            if (!TablasDVCamposId.TieneCampoId(nombreTabla))
                throw new Exception($"La tabla '{nombreTabla}' no tiene campo ID definido.");

            string campoId = TablasDVCamposId.ObtenerCampoId(nombreTabla);

            DataSet mDs = _objetoDAL.ObtenerDatosDeTabla(nombreTabla);
            DataTable tabla = mDs.Tables[0];

            foreach (DataRow row in tabla.Rows)
            {
                if (row["DVH"] != DBNull.Value && !string.IsNullOrEmpty(row["DVH"].ToString()))
                    continue;

                // Generar DVH usando el método que recibiste
                string dvh = DVMapper.GenerarDVH(row);

                object valorId = row[campoId];

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Tabla", nombreTabla),
                    new SqlParameter("@CampoId", campoId),
                    new SqlParameter("@ValorId", valorId),
                    new SqlParameter("@DVH", dvh)
                };

                _dao.ExecuteStoredProcedure("sp_InsertarDVH", parametros);
            }

            return true;
        }


    }
}