using System.ComponentModel.DataAnnotations;

namespace DataAnnotations.Entities
{
    public class Length
    {
        // NOVO DATA ANNOTATION DO .NET 8
        // ESPECIFICA O LIMITE INFERIOR E SUPERIOR PARA STRINGS E COLEÇÕES
        [Length(1, 3)]
        public ICollection<string> EstadosRegiaoSul {  get; set; } = Array.Empty<string>();

        [Length(8, 16)]
        public string senha {  get; set; } = string.Empty;

    }
}
