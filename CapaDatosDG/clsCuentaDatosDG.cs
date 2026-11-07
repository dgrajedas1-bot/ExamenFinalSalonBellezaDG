using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidadesDG;

namespace CapaDatosDG
{
    /// <summary>
    /// Acceso a la tabla dbo.tblCuentaDG con consultas parametrizadas.
    /// </summary>
    public class clsCuentaDatosDG
    {
        /// <summary>
        /// Inserta una cuenta calculada.
        /// </summary>
        /// <param name="pobjCuentaDG">Cuenta con totales ya calculados.</param>
        /// <returns>Id generado.</returns>
        public int FncInsertarDG(clsCuentaDG pobjCuentaDG)
        {
            const string lstrSqlDG = "INSERT INTO dbo.tblCuentaDG (NombreCompletoDG, ServicioUnasDG, HonorariosDG, PeinadoDG, AplicacionTinteDG, BasesDG, OtrosDG, TotalServiciosDG, TotalCuentaDG) " +
                                     "VALUES (@NombreDG, @UnasDG, @HonorariosDG, @PeinadoDG, @TinteDG, @BasesDG, @OtrosDG, @TotalServiciosDG, @TotalCuentaDG); SELECT CAST(SCOPE_IDENTITY() AS INT);";
            using (SqlConnection lcnnConexionDG = clsConexionDG.FncObtenerConexionDG())
            using (SqlCommand lcmdComandoDG = new SqlCommand(lstrSqlDG, lcnnConexionDG))
            {
                lcmdComandoDG.Parameters.Add("@NombreDG", SqlDbType.NVarChar, 150).Value = pobjCuentaDG.NombreCompletoDG;
                ProAgregarDecimalDG(lcmdComandoDG, "@UnasDG", pobjCuentaDG.ServicioUnasDG);
                ProAgregarDecimalDG(lcmdComandoDG, "@HonorariosDG", pobjCuentaDG.HonorariosDG);
                ProAgregarDecimalDG(lcmdComandoDG, "@PeinadoDG", pobjCuentaDG.PeinadoDG);
                ProAgregarDecimalDG(lcmdComandoDG, "@TinteDG", pobjCuentaDG.AplicacionTinteDG);
                ProAgregarDecimalDG(lcmdComandoDG, "@BasesDG", pobjCuentaDG.BasesDG);
                ProAgregarDecimalDG(lcmdComandoDG, "@OtrosDG", pobjCuentaDG.OtrosDG);
                ProAgregarDecimalDG(lcmdComandoDG, "@TotalServiciosDG", pobjCuentaDG.TotalServiciosDG);
                ProAgregarDecimalDG(lcmdComandoDG, "@TotalCuentaDG", pobjCuentaDG.TotalCuentaDG);
                lcnnConexionDG.Open();
                return Convert.ToInt32(lcmdComandoDG.ExecuteScalar());
            }
        }

        /// <summary>
        /// Lista las últimas cuentas registradas.
        /// </summary>
        /// <param name="pintCantidadDG">Cantidad máxima de registros.</param>
        /// <returns>Cuentas ordenadas de la más reciente a la más antigua.</returns>
        public List<clsCuentaDG> FncListarDG(int pintCantidadDG)
        {
            List<clsCuentaDG> llstCuentasDG = new List<clsCuentaDG>();
            const string lstrSqlDG = "SELECT TOP (@CantidadDG) IdCuentaDG, NombreCompletoDG, ServicioUnasDG, HonorariosDG, PeinadoDG, AplicacionTinteDG, BasesDG, OtrosDG, TotalServiciosDG, TotalCuentaDG, FechaDG " +
                                     "FROM dbo.tblCuentaDG ORDER BY IdCuentaDG DESC;";
            using (SqlConnection lcnnConexionDG = clsConexionDG.FncObtenerConexionDG())
            using (SqlCommand lcmdComandoDG = new SqlCommand(lstrSqlDG, lcnnConexionDG))
            {
                lcmdComandoDG.Parameters.Add("@CantidadDG", SqlDbType.Int).Value = pintCantidadDG;
                lcnnConexionDG.Open();
                using (SqlDataReader ldrLectorDG = lcmdComandoDG.ExecuteReader())
                {
                    while (ldrLectorDG.Read())
                    {
                        llstCuentasDG.Add(new clsCuentaDG
                        {
                            IdCuentaDG = ldrLectorDG.GetInt32(0),
                            NombreCompletoDG = ldrLectorDG.GetString(1),
                            ServicioUnasDG = ldrLectorDG.GetDecimal(2),
                            HonorariosDG = ldrLectorDG.GetDecimal(3),
                            PeinadoDG = ldrLectorDG.GetDecimal(4),
                            AplicacionTinteDG = ldrLectorDG.GetDecimal(5),
                            BasesDG = ldrLectorDG.GetDecimal(6),
                            OtrosDG = ldrLectorDG.GetDecimal(7),
                            TotalServiciosDG = ldrLectorDG.GetDecimal(8),
                            TotalCuentaDG = ldrLectorDG.GetDecimal(9),
                            FechaDG = ldrLectorDG.GetDateTime(10)
                        });
                    }
                }
            }
            return llstCuentasDG;
        }

        /// <summary>
        /// Agrega un parámetro DECIMAL(12,2).
        /// </summary>
        /// <param name="pcmdComandoDG">Comando destino.</param>
        /// <param name="pstrNombreDG">Nombre del parámetro.</param>
        /// <param name="pdecValorDG">Valor.</param>
        private static void ProAgregarDecimalDG(SqlCommand pcmdComandoDG, string pstrNombreDG, decimal pdecValorDG)
        {
            SqlParameter lprmParametroDG = pcmdComandoDG.Parameters.Add(pstrNombreDG, SqlDbType.Decimal);
            lprmParametroDG.Precision = 12;
            lprmParametroDG.Scale = 2;
            lprmParametroDG.Value = pdecValorDG;
        }
    }
}
