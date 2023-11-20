using System.ComponentModel.DataAnnotations;

namespace DataAnnotations.Entities
{
    public class ExemploRange
    {
        // NOVO DATA ANNOTATION DO .NET 8
        // ESPECIFICA SE OS LIMITES ESTÃO INCLUÍDOS NO INTERVALO PERMITIDO
        [Range(12,18, MinimumIsExclusive = true, MaximumIsExclusive = true)]
        public int Idade { get; set; }
    }
}
