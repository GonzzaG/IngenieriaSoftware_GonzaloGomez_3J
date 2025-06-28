using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace IngenieriaSoftware.DAL
{
    public class DAO
    {
        private SqlConnection mCon;
        public string NombreBD { get; } = "ISProyecto";

        public string rutaBD = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\BD"));

        public void Conectar()
        {
            try
            {
                //string connectionString = ConfigurationManager.AppSettings["ConnectionString"];
                string connectionStringBD = ConfigurationManager.ConnectionStrings["ConnectionStringBD"].ConnectionString;

                if (string.IsNullOrEmpty(connectionStringBD))
                {
                    throw new Exception("La cadena de conexion no está definida.");
                }

                mCon = new SqlConnection(connectionStringBD);

            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar a la base de datos: " + ex.Message);
            }

        }

        public int Execute(string pCommandText)
        {
            try
            {
                Conectar();

                SqlCommand mComm = new SqlCommand(pCommandText, mCon);

                mCon.Open();

                return mComm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (mCon.State != ConnectionState.Closed)
                    mCon.Close();
            }
        }
        public int ExecuteNonQuery(string pCommandText, SqlParameter[] pParametros)
        {
            try
            {
                Conectar();

                SqlCommand mComm = new SqlCommand(pCommandText, mCon);
                mComm.CommandType = CommandType.StoredProcedure;

                if (pParametros != null)
                {
                    mComm.Parameters.AddRange(pParametros);
                }

                mCon.Open();
                return mComm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (mCon.State != ConnectionState.Closed)
                    mCon.Close();
            }
        }

        public DataSet ExecuteStoredProcedure(string pNombreStoreProcedure, SqlParameter[] pParametros)
        {
            try
            {
                Conectar();

                SqlCommand mComm = new SqlCommand(pNombreStoreProcedure, mCon)
                {
                    CommandType = CommandType.StoredProcedure
                };

                if (pParametros != null)
                {
                    mComm.Parameters.AddRange(pParametros);
                }

                SqlDataAdapter mDa = new SqlDataAdapter(mComm);
                DataSet mDs = new DataSet();
                mDa.Fill(mDs);

                return mDs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (mCon.State != ConnectionState.Closed)
                    mCon.Close();
            }
        }


        // Inhabilitado para permitir el identity increment en la base de datos
        public int ObtenerUltimoId(string pTabla, string pColumnaId)
        {
            try
            {
                Conectar();
                SqlCommand mComm = new SqlCommand("SELECT ISNULL(MAX(" + pColumnaId + "),0) FROM " + pTabla, mCon);

                mCon.Open();

                return (int)mComm.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (mCon.State != ConnectionState.Closed)
                    mCon.Close();
            }
        }

        public void CrearBaseSiNoExiste()
        {
            // La conexión actual usa la BD ya definida en connection string,
            // pero si la BD no existe, falla la conexión.
            // Por eso acá armamos una conexión SOLO al servidor sin DB para chequear o crear.

            // Extraemos el Data Source (servidor) de la connection string
            var builder = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings["ConnectionStringBD"].ConnectionString);
            string servidor = builder.DataSource;

            // Cadena conexión sin DB
            string connSinDB = $"Data Source={servidor};Initial Catalog=master;Integrated Security=True";

            using (var conexion = new SqlConnection(connSinDB))
            {
                conexion.Open();

                // Verificamos si la BD existe
                string queryCheck = $"SELECT db_id('{NombreBD}')";
                using (var cmdCheck = new SqlCommand(queryCheck, conexion))
                {
                    object result = cmdCheck.ExecuteScalar();
                    if (result == DBNull.Value || result == null)
                    {
                        // BD no existe, la creamos
                        string script = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "puercoscript.sql"));

                        using (var cmdCreate = new SqlCommand(script, conexion))
                        {
                            cmdCreate.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
    }
}