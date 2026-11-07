using System;
using System.Collections.Generic;
using CapaDatosDG;
using CapaEntidadesDG;

namespace CapaNegocioDG
{
    /// <summary>
    /// Reglas de negocio: valida los datos, calcula la cuenta y la guarda.
    /// </summary>
    public class clsCuentaNegocioDG
    {
        /// <summary>Importe máximo permitido por campo.</summary>
        public const decimal cdecMaximoDG = 9999999.99m;

        /// <summary>Objeto de la capa de datos.</summary>
        private readonly clsCuentaDatosDG mobjDatosDG = new clsCuentaDatosDG();

        /// <summary>
        /// Valida y calcula los totales sin guardar.
        /// </summary>
        /// <param name="pobjCuentaDG">Datos ingresados.</param>
        /// <returns>La misma cuenta con TotalServiciosDG y TotalCuentaDG calculados.</returns>
        /// <exception cref="ArgumentException">Si algún dato no es válido.</exception>
        public clsCuentaDG FncCalcularDG(clsCuentaDG pobjCuentaDG)
        {
            if (pobjCuentaDG == null)
            {
                throw new ArgumentException("No se recibieron datos de la cuenta.");
            }
            pobjCuentaDG.NombreCompletoDG = (pobjCuentaDG.NombreCompletoDG ?? string.Empty).Trim();
            if (pobjCuentaDG.NombreCompletoDG.Length == 0)
            {
                throw new ArgumentException("El nombre completo es obligatorio.");
            }
            if (pobjCuentaDG.NombreCompletoDG.Length > 150)
            {
                throw new ArgumentException("El nombre completo admite máximo 150 caracteres.");
            }

            pobjCuentaDG.ServicioUnasDG = FncValidarImporteDG(pobjCuentaDG.ServicioUnasDG, "Servicio de uñas");
            pobjCuentaDG.HonorariosDG = FncValidarImporteDG(pobjCuentaDG.HonorariosDG, "Honorarios");
            pobjCuentaDG.PeinadoDG = FncValidarImporteDG(pobjCuentaDG.PeinadoDG, "Peinado");
            pobjCuentaDG.AplicacionTinteDG = FncValidarImporteDG(pobjCuentaDG.AplicacionTinteDG, "Aplicación de tinte");
            pobjCuentaDG.BasesDG = FncValidarImporteDG(pobjCuentaDG.BasesDG, "Bases");
            pobjCuentaDG.OtrosDG = FncValidarImporteDG(pobjCuentaDG.OtrosDG, "Otros");

            pobjCuentaDG.TotalServiciosDG = FncRedondearDG(pobjCuentaDG.ServicioUnasDG + pobjCuentaDG.HonorariosDG
                + pobjCuentaDG.PeinadoDG + pobjCuentaDG.AplicacionTinteDG + pobjCuentaDG.BasesDG);
            pobjCuentaDG.TotalCuentaDG = FncRedondearDG(pobjCuentaDG.TotalServiciosDG + pobjCuentaDG.OtrosDG);
            pobjCuentaDG.FechaDG = DateTime.Now;
            return pobjCuentaDG;
        }

        /// <summary>
        /// Calcula la cuenta y la guarda en la base de datos.
        /// </summary>
        /// <param name="pobjCuentaDG">Datos ingresados.</param>
        /// <returns>Cuenta calculada con su Id asignado.</returns>
        public clsCuentaDG FncCalcularYGuardarDG(clsCuentaDG pobjCuentaDG)
        {
            clsCuentaDG lobjCuentaDG = FncCalcularDG(pobjCuentaDG);
            lobjCuentaDG.IdCuentaDG = mobjDatosDG.FncInsertarDG(lobjCuentaDG);
            return lobjCuentaDG;
        }

        /// <summary>
        /// Devuelve el historial de cuentas.
        /// </summary>
        /// <param name="pintCantidadDG">Cantidad máxima (1 a 100).</param>
        /// <returns>Lista de cuentas.</returns>
        public List<clsCuentaDG> FncListarDG(int pintCantidadDG)
        {
            if (pintCantidadDG < 1 || pintCantidadDG > 100)
            {
                pintCantidadDG = 20;
            }
            return mobjDatosDG.FncListarDG(pintCantidadDG);
        }

        /// <summary>
        /// Redondea a 2 decimales (mitad hacia arriba) y fija la escala a 2.
        /// </summary>
        /// <param name="pdecValorDG">Valor a redondear.</param>
        /// <returns>Valor con 2 decimales.</returns>
        public static decimal FncRedondearDG(decimal pdecValorDG)
        {
            return Math.Round(pdecValorDG, 2, MidpointRounding.AwayFromZero) + 0.00m;
        }

        /// <summary>
        /// Valida que un importe esté entre 0 y el máximo, y lo redondea.
        /// </summary>
        /// <param name="pdecValorDG">Importe.</param>
        /// <param name="pstrCampoDG">Nombre del campo para el mensaje.</param>
        /// <returns>Importe redondeado.</returns>
        private static decimal FncValidarImporteDG(decimal pdecValorDG, string pstrCampoDG)
        {
            if (pdecValorDG < 0)
            {
                throw new ArgumentException("El campo " + pstrCampoDG + " no puede ser negativo.");
            }
            if (pdecValorDG > cdecMaximoDG)
            {
                throw new ArgumentException("El campo " + pstrCampoDG + " supera el máximo permitido.");
            }
            return FncRedondearDG(pdecValorDG);
        }
    }
}
