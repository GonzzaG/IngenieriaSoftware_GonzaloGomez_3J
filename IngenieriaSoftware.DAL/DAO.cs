using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace IngenieriaSoftware.DAL
{
    public class DAO
    {
        private SqlConnection mCon;

        public string rutaBD = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\BD"));

        internal static string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringBD"].ConnectionString;
        public static string GetConnectionString()
        {
            if (_connectionString != null)
                return _connectionString;

            string instanceFile = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
                "SQLINSTANCE.txt"
            );

            if (!File.Exists(instanceFile))
                throw new FileNotFoundException("No se encontró el archivo con la instancia SQL.", instanceFile);

            //string sqlInstance2 = @"HUMBERTO2024\SQLEXPRESS";
            string sqlInstance = File.ReadAllText(instanceFile).Trim();

            // El resto del código se queda igual
            var baseConnStr = ConfigurationManager.ConnectionStrings["ConnectionStringBD"].ConnectionString;
            var builder = new SqlConnectionStringBuilder(baseConnStr)
            {
                DataSource = sqlInstance
            };

            _connectionString = builder.ConnectionString;

            MessageBox.Show(_connectionString); 

            return _connectionString;
        }

        public static bool TestConnection(out string errorMessage)
        {
            errorMessage = string.Empty;

            try
            {
                using (var conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open();
                }
                return true;
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 53: // No se encuentra el servidor
                        errorMessage = "No se puede localizar la instancia de SQL Server.\nVerifique que el servidor esté en ejecución y que el nombre de la instancia sea correcto.";
                        break;
                    case 4060: // No se puede abrir la base de datos
                        errorMessage = "No se puede abrir la base de datos especificada. Verifique que exista y tenga los permisos correctos.";
                        break;
                    case 18456: // Error de autenticación
                        errorMessage = "Error de autenticación. Verifique las credenciales y el tipo de seguridad configurado en la base de datos.";
                        break;
                    case 40: // No se puede abrir conexión con SQL
                        errorMessage = "No se pudo abrir una conexión con SQL Server. Compruebe que el servidor permite conexiones remotas y que los protocolos (TCP/IP o Named Pipes) estén habilitados.";
                        break;
                    default:
                        errorMessage = "Error de SQL Server: " + ex.Message;
                        break;
                }
                return false;
            }
            catch (Exception ex)
            {
                errorMessage = "Error general al conectarse a SQL Server: " + ex.Message;
                return false;
            }
        }

        public void Conectar()
        {
            string logPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "TuApp_connection_log.txt"
            );

            try
            {
                string connectionStringBD = _connectionString;

                // Registrar cadena
                File.WriteAllText(logPath, $"[{DateTime.Now}] ConnectionString usada NUEVONUEVONUEVO:\n{connectionStringBD}");

                if (string.IsNullOrEmpty(connectionStringBD))
                {
                    throw new Exception("La cadena de conexión no está definida.");
                }

                mCon = new SqlConnection(connectionStringBD);
                mCon.Open();

                File.AppendAllText(logPath, "\nConexión abierta correctamente.\n");
            }
            catch (Exception ex)
            {
                File.AppendAllText(logPath, $"\n[{DateTime.Now}] Error al conectar: {ex.Message}\n");
                throw new Exception("Error al conectar a la base de datos: " + ex.Message);
            }
        }



        public int Execute(string pCommandText)
        {
            try
            {
                Conectar(); // ya abre la conexión

                using (SqlCommand mComm = new SqlCommand(pCommandText, mCon))
                {
                    return mComm.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Execute: " + ex.Message, ex);
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

                using (SqlCommand mComm = new SqlCommand(pCommandText, mCon))
                {
                    mComm.CommandType = CommandType.StoredProcedure;

                    if (pParametros != null)
                        mComm.Parameters.AddRange(pParametros);

                    return mComm.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en ExecuteNonQuery: " + ex.Message, ex);
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

        /// <summary>
        /// Ejecutar varios procedures para cuando necesitamos hacer una transaccion
        /// </summary>
        /// <param name="procedureName"></param>
        /// <param name="parameters"></param>
        /// <param name="conn"></param>
        /// <param name="tran"></param>
        public void ExecuteStoredProcedure(string procedureName, SqlParameter[] parameters,SqlConnection conn, SqlTransaction tran)
        {
            using (SqlCommand cmd = new SqlCommand(procedureName, conn, tran))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                cmd.ExecuteNonQuery();
            }
        }

        // Inhabilitado para permitir el identity increment en la base de datos
        public int ObtenerUltimoId(string pTabla, string pColumnaId)
        {
            try
            {
                Conectar();

                using (SqlCommand mComm = new SqlCommand(
                    $"SELECT ISNULL(MAX({pColumnaId}),0) FROM {pTabla}", mCon))
                {
                    return (int)mComm.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en ObtenerUltimoId: " + ex.Message, ex);
            }
            finally
            {
                if (mCon.State != ConnectionState.Closed)
                    mCon.Close();
            }
        }

    }
}