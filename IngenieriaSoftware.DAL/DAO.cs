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
            string connectionString = ConfigurationManager.AppSettings["ConnectionString"];

            // Validar si la variable está definida
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new Exception("La cadena de conexion no está definida.");
            }

            // Crear la conexión
            mCon = new SqlConnection(connectionString);
        }

        public int ExecuteNonQuery(string pNombreStoredProcedure, SqlParameter[] pParametros)
        {
            try
            {
                Conectar();

                SqlCommand mComm = new SqlCommand(pNombreStoredProcedure, mCon)
                {
                    CommandType = CommandType.StoredProcedure
                };

                if (pParametros != null)
                {
                    mComm.Parameters.AddRange(pParametros);
                }

                mCon.Open();
                return mComm.ExecuteNonQuery();
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
    }
}