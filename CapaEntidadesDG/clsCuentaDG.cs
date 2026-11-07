using System;
using System.Xml.Serialization;

namespace CapaEntidadesDG
{
    /// <summary>
    /// Cuenta de un cliente del Salón de Belleza. Se usa en el servicio web y en el cliente Windows Forms.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = clsCuentaDG.cstrNamespaceDG)]
    public class clsCuentaDG
    {
        /// <summary>Espacio de nombres XML compartido por el servicio y el cliente.</summary>
        public const string cstrNamespaceDG = "http://danielagrajeda.dg/salonbelleza/";

        /// <summary>Identificador de la cuenta en la base de datos.</summary>
        public int IdCuentaDG { get; set; }

        /// <summary>Nombre completo del cliente.</summary>
        public string NombreCompletoDG { get; set; }

        /// <summary>Total del servicio de uñas.</summary>
        public decimal ServicioUnasDG { get; set; }

        /// <summary>Total de honorarios.</summary>
        public decimal HonorariosDG { get; set; }

        /// <summary>Total de peinado.</summary>
        public decimal PeinadoDG { get; set; }

        /// <summary>Total de aplicación de tinte.</summary>
        public decimal AplicacionTinteDG { get; set; }

        /// <summary>Total de bases.</summary>
        public decimal BasesDG { get; set; }

        /// <summary>Total de otros cargos (se presenta aparte).</summary>
        public decimal OtrosDG { get; set; }

        /// <summary>Suma de los cinco servicios.</summary>
        public decimal TotalServiciosDG { get; set; }

        /// <summary>Total a pagar: servicios más otros.</summary>
        public decimal TotalCuentaDG { get; set; }

        /// <summary>Fecha y hora del cálculo.</summary>
        public DateTime FechaDG { get; set; }
    }
}
