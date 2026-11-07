using System;
using System.ComponentModel;
using System.Web.Services;
using System.Web.Services.Protocols;
using CapaEntidadesDG;
using CapaNegocioDG;

namespace WebServicioSalonDG
{
    /// <summary>
    /// Servicio web del Salón de Belleza: calcula la cuenta del cliente y consulta el historial.
    /// </summary>
    [WebService(Namespace = clsCuentaDG.cstrNamespaceDG, Name = "wsSalonBellezaDG", Description = "Servicio web del Salón de Belleza - Daniela Grajeda")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class wsSalonBellezaDG : WebService
    {
        /// <summary>Objeto de la capa de negocio.</summary>
        private readonly clsCuentaNegocioDG mobjNegocioDG = new clsCuentaNegocioDG();

        /// <summary>
        /// Calcula la cuenta (suma de servicios + otros), la guarda en SQL Server y la devuelve.
        /// </summary>
        /// <param name="pstrNombreCompletoDG">Nombre completo del cliente.</param>
        /// <param name="pdecServicioUnasDG">Total servicio de uñas.</param>
        /// <param name="pdecHonorariosDG">Total honorarios.</param>
        /// <param name="pdecPeinadoDG">Total peinado.</param>
        /// <param name="pdecAplicacionTinteDG">Total aplicación de tinte.</param>
        /// <param name="pdecBasesDG">Total bases.</param>
        /// <param name="pdecOtrosDG">Total otros.</param>
        /// <returns>Cuenta con totales calculados y redondeados a 2 decimales.</returns>
        [WebMethod(Description = "Calcula y guarda la cuenta del cliente.")]
        public clsCuentaDG FncCalcularCuentaDG(string pstrNombreCompletoDG, decimal pdecServicioUnasDG, decimal pdecHonorariosDG,
            decimal pdecPeinadoDG, decimal pdecAplicacionTinteDG, decimal pdecBasesDG, decimal pdecOtrosDG)
        {
            clsCuentaDG lobjCuentaDG = new clsCuentaDG
            {
                NombreCompletoDG = pstrNombreCompletoDG,
                ServicioUnasDG = pdecServicioUnasDG,
                HonorariosDG = pdecHonorariosDG,
                PeinadoDG = pdecPeinadoDG,
                AplicacionTinteDG = pdecAplicacionTinteDG,
                BasesDG = pdecBasesDG,
                OtrosDG = pdecOtrosDG
            };
            try
            {
                return mobjNegocioDG.FncCalcularYGuardarDG(lobjCuentaDG);
            }
            catch (ArgumentException lexcValidacionDG)
            {
                throw new SoapException(lexcValidacionDG.Message, SoapException.ClientFaultCode);
            }
            catch (Exception lexcErrorDG)
            {
                throw new SoapException("No se pudo guardar la cuenta en la base de datos: " + lexcErrorDG.Message, SoapException.ServerFaultCode);
            }
        }

        /// <summary>
        /// Devuelve las últimas cuentas registradas.
        /// </summary>
        /// <param name="pintCantidadDG">Cantidad máxima (1 a 100).</param>
        /// <returns>Arreglo de cuentas.</returns>
        [WebMethod(Description = "Lista las últimas cuentas registradas.")]
        public clsCuentaDG[] FncListarCuentasDG(int pintCantidadDG)
        {
            try
            {
                return mobjNegocioDG.FncListarDG(pintCantidadDG).ToArray();
            }
            catch (Exception lexcErrorDG)
            {
                throw new SoapException("No se pudo leer el historial: " + lexcErrorDG.Message, SoapException.ServerFaultCode);
            }
        }
    }
}
