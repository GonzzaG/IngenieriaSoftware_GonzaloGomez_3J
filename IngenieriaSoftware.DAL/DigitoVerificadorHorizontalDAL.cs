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
        /// Recalcula y actualiza el DVH de todos los registros.
        /// </summary>
        public bool AgregarVerificadorHorizontal(string nombreTabla)
        {
            if (!TablasDVCamposId.TieneCampoId(nombreTabla))
                throw new Exception($"La tabla '{nombreTabla}' no tiene campo ID definido.");

            string campoId = TablasDVCamposId.ObtenerCampoId(nombreTabla);

            // Obtenemos todos los datos
            DataSet mDs = _objetoDAL.ObtenerDatosDeTabla(nombreTabla);
            DataTable tabla = mDs.Tables[0];

            foreach (DataRow row in tabla.Rows)
            {
                // 1. Calculamos el DVH que DEBERÍA tener el registro
                string dvhCalculado = DVMapper.GenerarDVH(row);

                // 2. Obtenemos el DVH que tiene ACTUALMENTE (si tiene)
                string dvhActual = "";
                if (row["DVH"] != DBNull.Value)
                {
                    dvhActual = row["DVH"].ToString();
                }

                // 3. LÓGICA DE ACTUALIZACIÓN:
                // Si el DVH actual es igual al calculado, no hacemos nada (ahorramos conexión a DB)
                // Si son distintos (o el actual es nulo), actualizamos.
                if (dvhActual == dvhCalculado)
                {
                    continue;
                }

                // Si llegamos aquí, es porque hay que actualizar/insertar
                object valorId = row[campoId];

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Tabla", nombreTabla),
                    new SqlParameter("@CampoId", campoId),
                    new SqlParameter("@ValorId", valorId),
                    new SqlParameter("@DVH", dvhCalculado)
                };

                // OJO: Asegúrate que este SP haga un UPDATE, no solo un INSERT
                _dao.ExecuteStoredProcedure("sp_InsertarDVH", parametros);
            }

            return true;
        }


    }
}