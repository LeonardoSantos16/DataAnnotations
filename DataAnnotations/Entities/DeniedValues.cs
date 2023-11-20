using System.ComponentModel.DataAnnotations;

namespace DataAnnotations.Entities
{
    public class DeniedValues
    {
        // NOVO DATA ANNOTATION DO.NET 8
        // ESPEFICICA LISTAS DE NEGAÇÕES,
        [DeniedValues("Brasil","Argentina")]
        public string Paises { get; set; } = string.Empty;
    }
}
