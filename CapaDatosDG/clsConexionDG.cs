using System.Configuration;
using System.Data.SqlClient;

namespace CapaDatosDG
{
    /// <summary>
    /// Crea conexiones a SQL Server con la cadena "cnnSalonDG" del archivo de configuración.
    /// </summary>
    public static class clsConexionDG
    {
        /// <summary>Nombre de la cadena de conexión.</summary>
        public const string cstrNombreCadenaDG = "cnnSalonDG";

        /// <summary>
        /// Devuelve una conexión nueva (sin abrir).
        /// </summary>
        /// <returns>Conexión a la base de datos.</returns>
        /// <exception cref="ConfigurationErrorsException">Si la cadena no está configurada.</exception>
        public static SqlConnection FncObtenerConexionDG()
        {
            ConnectionStringSettings lobjCadenaDG = ConfigurationManager.ConnectionStrings[cstrNombreCadenaDG];
            if (lobjCadenaDG == null || string.IsNullOrWhiteSpace(lobjCadenaDG.ConnectionString))
            {
                throw new ConfigurationErrorsException("No se encontró la cadena de conexión '" + cstrNombreCadenaDG + "'.");
            }
            return new SqlConnection(lobjCadenaDG.ConnectionString);
        }
    }
}
