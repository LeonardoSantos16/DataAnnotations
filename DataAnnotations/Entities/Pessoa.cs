using DataAnnotations.Validations;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotations.Entities
{
    public class Pessoa
    {


        public int Id { get; set; }

        [Required(ErrorMessage = "informe seu nome")] // Obriga a entrada de um campo especificado e define a mensagem de erro
        [PrimeiraLetraMaiuscula]
        [Display(Name = "Nome Completo")]
        public string? Nome { get; set; }

        [Range(18, int.MaxValue, ErrorMessage = "O usuário tem que ser maior de idade")]
        public int Idade { get; set;}
        public string? dataNascimento { get; set; }

        [EmailAddress] //  propriedade Email tenha um formato de endereço de e-mail válido, mas não verifica se o email é existente
        public string? Email { get; set; }
        [Range(7, 11)] // Define um intervalo para uma propriedade onde a validação será aplicada
        public int? Tamanho { get; set; }
       
        // Formatos aceitos pelo annotation [Phone] (123) 456-7890, 123-456-7890, 123.456.7890, 1234567890, +1234567890
        [Phone] //Valida a entrada para o formato telefone
        public string? Telefone { get; set; }

        // Formatos aceitos pelo annotation [CreditCard] 1234567812345670 //////////////// 1234-5678-1234-5670 /////////////// 1234 5678 1234 5670
        [CreditCard] //Valida a entrada oara o formato cartão
        public string? Cartao { get; set; }

        [Url] //Valida a entrada para o formato URL
        public string? Url { get; set; }
        [SenhaForte]
        public string? Senha { get; set; }
        [Compare("Senha")] // Permite comparar duas propriedades
        public string? ConfimarSenha { get; set; }
        [DataType(DataType.PostalCode)]// O objetivo principal da anotação [DataType] é fornecer uma maneira padronizada de indicar à interface do usuário ou a outros componentes do sistema como processar e exibir uma propriedade específica. 
        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "O CEP deve estar no formato 12345-678.")]
        public string? CPF { get; set; }

        /*
         * {
          "id": 0,
          "nome": "String",
          "idade": 19,
          "dataNascimento": "string",
          "email": "user@example.com",
          "tamanho": 11,
          "telefone": "123.456.7890",
          "cartao": "1234-5678-1234-5670",
          "url": "https://www.twitch.tv/rnakano",
          "senha": "String1@",
          "confimarSenha": "String1@",
          "cpf": "69117-329"
        }
         */
    }
}
