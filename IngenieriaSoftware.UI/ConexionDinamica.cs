using System;
using System.Configuration;
using System.Data.Sql;

namespace IngenieriaSoftware.UI
{
    internal class ConexionDinamica
    {
        public static string BuscarInstanciaDisponible()
        {
            SqlDataSourceEnumerator instanceEnumerator = SqlDataSourceEnumerator.Instance;
            var table = instanceEnumerator.GetDataSources();

            foreach (System.Data.DataRow row in table.Rows)
            {
                string server = row["ServerName"]?.ToString() ?? "";
                string instance = row["InstanceName"]?.ToString() ?? "";

                string dataSource = string.IsNullOrEmpty(instance) ? server : $"{server}\\{instance}";

                // Probar si responde
                string connStr = $"Data Source={dataSource};Initial Catalog=ISProyecto;Integrated Security=True";
                using (var conn = new System.Data.SqlClient.SqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        return dataSource; // Primera que responda, la usamos
                    }
                    catch { continue; }
                }
            }

            return null;
        }

        public static void AplicarInstanciaDetectada()
        {
            string instancia = BuscarInstanciaDisponible();

            if (!string.IsNullOrEmpty(instancia))
            {
                var settings = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionStringBD"];
                var field = typeof(ConfigurationElement).GetField("_bReadOnly", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                field?.SetValue(settings, false);

                string nueva = $"Data Source={instancia};Initial Catalog=ISProyecto;Integrated Security=True";
                settings.ConnectionString = nueva;
            }
            else
            {
                Console.WriteLine("No se encontró una instancia de SQL Server compatible. Por favor, instale SQL Server Express o configure el acceso manualmente.", "Error");
                Environment.Exit(1);
            }
        }

    }
}
