using System.ComponentModel.DataAnnotations;

namespace DataAnnotations.Entities
{
    public class Base64String
    {
        // NOVO DATA ANNOTATION DO .NET 8
        // VERIFICA SE UM SEQUÊNCIA DE CARACTERES É UMA REPRESENTAÇÃO VÁLIDA EM BASE 64
        [Base64String]
        public string Valor { get; set; } = string.Empty;
    }
}
