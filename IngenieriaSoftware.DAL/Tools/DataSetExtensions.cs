using System;
using System.Data;

namespace IngenieriaSoftware.DAL.Tools
{
    internal static class DataSetExtensions
    {
        internal static bool esValido(this DataSet mDs)
        {
            if (mDs is null)
                throw new ArgumentNullException(nameof(mDs), "El DataSet no puede ser nulo.");

            if (mDs.Tables.Count.Equals(0) || mDs.Tables[0].Rows.Count.Equals(0))
                throw new InvalidOperationException("No se encontraron filas en el DataSet.");

            return true;
        }
    }
}
