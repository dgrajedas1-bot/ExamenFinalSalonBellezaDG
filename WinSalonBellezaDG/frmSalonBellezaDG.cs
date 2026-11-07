using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using CapaEntidadesDG;

namespace WinSalonBellezaDG
{
    /// <summary>
    /// Formulario principal: captura los datos del cliente, llama al servicio web
    /// para calcular la cuenta y muestra el resultado y el historial.
    /// </summary>
    public partial class frmSalonBellezaDG : Form
    {
        /// <summary>Formato de moneda con 2 decimales.</summary>
        private const string cstrFormatoDG = "#,##0.00";

        /// <summary>Cultura para mostrar los números (coma de miles, punto decimal).</summary>
        private static readonly CultureInfo mobjCulturaDG = CultureInfo.GetCultureInfo("en-US");

        /// <summary>
        /// Inicializa el formulario.
        /// </summary>
        public frmSalonBellezaDG()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Al cargar: valores iniciales y consulta del historial.
        /// </summary>
        /// <param name="sender">Formulario.</param>
        /// <param name="e">Argumentos.</param>
        private void frmSalonBellezaDG_Load(object sender, EventArgs e)
        {
            txtNombreCompletoDG.Text = "Daniela Grajeda";
            ProMostrarResultadoVacioDG();
            ProCargarHistorialDG();
        }

        /// <summary>
        /// Envía los datos al servicio web y muestra la cuenta calculada.
        /// </summary>
        /// <param name="sender">Botón Calcular Cuenta.</param>
        /// <param name="e">Argumentos.</param>
        private void btnCalcularCuentaDG_Click(object sender, EventArgs e)
        {
            string lstrNombreDG = txtNombreCompletoDG.Text.Trim();
            if (lstrNombreDG.Length == 0)
            {
                MessageBox.Show("Ingrese el nombre completo del cliente.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreCompletoDG.Focus();
                return;
            }

            Cursor = Cursors.WaitCursor;
            btnCalcularCuentaDG.Enabled = false;
            try
            {
                using (clsProxySalonBellezaDG lobjServicioDG = new clsProxySalonBellezaDG())
                {
                    clsCuentaDG lobjCuentaDG = lobjServicioDG.FncCalcularCuentaDG(lstrNombreDG,
                        nudServicioUnasDG.Value, nudHonorariosDG.Value, nudPeinadoDG.Value,
                        nudAplicacionTinteDG.Value, nudBasesDG.Value, nudOtrosDG.Value);
                    ProMostrarResultadoDG(lobjCuentaDG);
                }
                ProCargarHistorialDG();
            }
            catch (SoapException lexcSoapDG)
            {
                MessageBox.Show(FncMensajeSoapDG(lexcSoapDG), "Servicio web", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (WebException lexcWebDG)
            {
                MessageBox.Show("No se pudo conectar con el servicio web. Verifique que WebServicioSalonDG esté en ejecución.\n\nDetalle: " + lexcWebDG.Message, "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception lexcErrorDG)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + lexcErrorDG.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnCalcularCuentaDG.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Limpia los campos para un nuevo cliente.
        /// </summary>
        /// <param name="sender">Botón Limpiar.</param>
        /// <param name="e">Argumentos.</param>
        private void btnLimpiarDG_Click(object sender, EventArgs e)
        {
            txtNombreCompletoDG.Clear();
            foreach (NumericUpDown lnudCampoDG in new[] { nudServicioUnasDG, nudHonorariosDG, nudPeinadoDG, nudAplicacionTinteDG, nudBasesDG, nudOtrosDG })
            {
                lnudCampoDG.Value = 0;
            }
            ProMostrarResultadoVacioDG();
            txtNombreCompletoDG.Focus();
        }

        /// <summary>
        /// Vuelve a consultar el historial al servicio web.
        /// </summary>
        /// <param name="sender">Botón Actualizar.</param>
        /// <param name="e">Argumentos.</param>
        private void btnActualizarDG_Click(object sender, EventArgs e)
        {
            ProCargarHistorialDG();
        }

        /// <summary>
        /// Muestra la cuenta con el formato solicitado.
        /// </summary>
        /// <param name="pobjCuentaDG">Cuenta devuelta por el servicio.</param>
        private void ProMostrarResultadoDG(clsCuentaDG pobjCuentaDG)
        {
            lblCuentaTituloDG.Text = "CUENTA " + pobjCuentaDG.NombreCompletoDG.ToUpper(CultureInfo.CurrentCulture);
            lblTotalServiciosValorDG.Text = pobjCuentaDG.TotalServiciosDG.ToString(cstrFormatoDG, mobjCulturaDG);
            lblTotalOtrosValorDG.Text = pobjCuentaDG.OtrosDG.ToString(cstrFormatoDG, mobjCulturaDG);
            lblSuCuentaValorDG.Text = pobjCuentaDG.TotalCuentaDG.ToString(cstrFormatoDG, mobjCulturaDG);
        }

        /// <summary>
        /// Deja el panel de resultado en cero.
        /// </summary>
        private void ProMostrarResultadoVacioDG()
        {
            lblCuentaTituloDG.Text = "CUENTA";
            lblTotalServiciosValorDG.Text = 0m.ToString(cstrFormatoDG, mobjCulturaDG);
            lblTotalOtrosValorDG.Text = 0m.ToString(cstrFormatoDG, mobjCulturaDG);
            lblSuCuentaValorDG.Text = 0m.ToString(cstrFormatoDG, mobjCulturaDG);
        }

        /// <summary>
        /// Consulta el historial al servicio web y lo muestra en la tabla.
        /// </summary>
        private void ProCargarHistorialDG()
        {
            try
            {
                using (clsProxySalonBellezaDG lobjServicioDG = new clsProxySalonBellezaDG())
                {
                    clsCuentaDG[] larrCuentasDG = lobjServicioDG.FncListarCuentasDG(20) ?? new clsCuentaDG[0];
                    dgvHistorialDG.DataSource = larrCuentasDG.Select(lobjC => new
                    {
                        Fecha = lobjC.FechaDG.ToString("dd/MM/yyyy HH:mm"),
                        Cliente = lobjC.NombreCompletoDG,
                        Servicios = lobjC.TotalServiciosDG.ToString(cstrFormatoDG, mobjCulturaDG),
                        Otros = lobjC.OtrosDG.ToString(cstrFormatoDG, mobjCulturaDG),
                        Total = lobjC.TotalCuentaDG.ToString(cstrFormatoDG, mobjCulturaDG)
                    }).ToList();
                }
                lblEstadoDG.Text = "Conectado al servicio web.";
            }
            catch (Exception lexcErrorDG)
            {
                dgvHistorialDG.DataSource = null;
                lblEstadoDG.Text = "Historial no disponible: " + (lexcErrorDG is SoapException ? FncMensajeSoapDG((SoapException)lexcErrorDG) : lexcErrorDG.Message);
            }
        }

        /// <summary>
        /// Extrae un mensaje legible de una excepción SOAP.
        /// </summary>
        /// <param name="pexcSoapDG">Excepción recibida.</param>
        /// <returns>Mensaje sin la traza del servidor.</returns>
        private static string FncMensajeSoapDG(SoapException pexcSoapDG)
        {
            string lstrMensajeDG = pexcSoapDG.Message ?? string.Empty;
            int lintPosDG = lstrMensajeDG.IndexOf("--->", StringComparison.Ordinal);
            if (lintPosDG >= 0)
            {
                lstrMensajeDG = lstrMensajeDG.Substring(lintPosDG + 4);
            }
            int lintFinDG = lstrMensajeDG.IndexOf("\n   at ", StringComparison.Ordinal);
            if (lintFinDG > 0)
            {
                lstrMensajeDG = lstrMensajeDG.Substring(0, lintFinDG);
            }
            lstrMensajeDG = lstrMensajeDG.Replace("System.Web.Services.Protocols.SoapException:", string.Empty).Trim();
            return lstrMensajeDG.Length == 0 ? "El servicio devolvió un error." : lstrMensajeDG;
        }
    }
}
