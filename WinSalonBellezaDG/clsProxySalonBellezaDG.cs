using System.ComponentModel;
using System.Configuration;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using CapaEntidadesDG;

namespace WinSalonBellezaDG
{
    /// <summary>
    /// Proxy SOAP 1.1 (document/literal) del servicio wsSalonBellezaDG.asmx.
    /// Los nombres de métodos, parámetros y el namespace coinciden con el servicio.
    /// </summary>
    [DesignerCategory("code")]
    [WebServiceBinding(Name = "wsSalonBellezaDGSoap", Namespace = clsCuentaDG.cstrNamespaceDG)]
    public class clsProxySalonBellezaDG : SoapHttpClientProtocol
    {
        /// <summary>Llave de App.config con la dirección del servicio.</summary>
        public const string cstrLlaveUrlDG = "UrlServicioSalonDG";

        /// <summary>
        /// Crea el proxy usando la dirección configurada en App.config.
        /// </summary>
        public clsProxySalonBellezaDG()
        {
            string lstrUrlDG = ConfigurationManager.AppSettings[cstrLlaveUrlDG];
            Url = string.IsNullOrWhiteSpace(lstrUrlDG) ? "http://localhost:51250/wsSalonBellezaDG.asmx" : lstrUrlDG.Trim();
            Timeout = 15000;
        }

        /// <summary>
        /// Llama al método FncCalcularCuentaDG del servicio web.
        /// </summary>
        /// <param name="pstrNombreCompletoDG">Nombre completo del cliente.</param>
        /// <param name="pdecServicioUnasDG">Total servicio de uñas.</param>
        /// <param name="pdecHonorariosDG">Total honorarios.</param>
        /// <param name="pdecPeinadoDG">Total peinado.</param>
        /// <param name="pdecAplicacionTinteDG">Total aplicación de tinte.</param>
        /// <param name="pdecBasesDG">Total bases.</param>
        /// <param name="pdecOtrosDG">Total otros.</param>
        /// <returns>Cuenta calculada por el servicio.</returns>
        [SoapDocumentMethod("http://danielagrajeda.dg/salonbelleza/FncCalcularCuentaDG", RequestNamespace = clsCuentaDG.cstrNamespaceDG, ResponseNamespace = clsCuentaDG.cstrNamespaceDG, Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public clsCuentaDG FncCalcularCuentaDG(string pstrNombreCompletoDG, decimal pdecServicioUnasDG, decimal pdecHonorariosDG,
            decimal pdecPeinadoDG, decimal pdecAplicacionTinteDG, decimal pdecBasesDG, decimal pdecOtrosDG)
        {
            object[] larrResultadoDG = Invoke("FncCalcularCuentaDG", new object[]
            {
                pstrNombreCompletoDG, pdecServicioUnasDG, pdecHonorariosDG, pdecPeinadoDG, pdecAplicacionTinteDG, pdecBasesDG, pdecOtrosDG
            });
            return (clsCuentaDG)larrResultadoDG[0];
        }

        /// <summary>
        /// Llama al método FncListarCuentasDG del servicio web.
        /// </summary>
        /// <param name="pintCantidadDG">Cantidad máxima de cuentas.</param>
        /// <returns>Historial de cuentas.</returns>
        [SoapDocumentMethod("http://danielagrajeda.dg/salonbelleza/FncListarCuentasDG", RequestNamespace = clsCuentaDG.cstrNamespaceDG, ResponseNamespace = clsCuentaDG.cstrNamespaceDG, Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public clsCuentaDG[] FncListarCuentasDG(int pintCantidadDG)
        {
            object[] larrResultadoDG = Invoke("FncListarCuentasDG", new object[] { pintCantidadDG });
            return (clsCuentaDG[])larrResultadoDG[0];
        }
    }
}
