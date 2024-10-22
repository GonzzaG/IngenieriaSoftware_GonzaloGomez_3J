using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL
{
    public class DAO
    {
        private SqlConnection mCon = new SqlConnection(@"Data Source=HUMBERTO2024\SQLEXPRESS;Initial Catalog=ISProyecto;Integrated Security=True");

        public DataSet ExecuteDataSet(string pCommandText)
        {
            try
            {
                SqlDataAdapter mDa = new SqlDataAdapter(pCommandText, mCon);

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

        public int ExecuteNonQuery(string pCommandText)
        {
            try
            {
                SqlCommand mComm = new SqlCommand(pCommandText, mCon);

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

        public int ObtenerUltimoId(string pTabla, string pColumnaId)
        {
            try
            {
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
