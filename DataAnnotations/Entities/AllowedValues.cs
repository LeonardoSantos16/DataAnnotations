using System.ComponentModel.DataAnnotations;

namespace DataAnnotations.Entities
{
    public class AllowedValues
    {
        // NOVO DATA ANNOTATION DO .NET 8
        // ESPEFICICA LISTAS DE PERMISSÕES  
        [AllowedValues("PR", "SC", "RS")]
        public string EstadosRegiaoSul { get; set; } = string.Empty;
    }
}
