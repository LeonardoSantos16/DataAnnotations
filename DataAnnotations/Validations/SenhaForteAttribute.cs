using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace DataAnnotations.Validations
{
    public class SenhaForteAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }
            var letraMinuscula = value.ToString().ToLower();
            var letraMaiuscula = value.ToString().ToUpper();


            if (TemNumeroEspecial(value.ToString()) & letraMaiuscula != value.ToString() & letraMinuscula != value.ToString()){
                return ValidationResult.Success;
            }
            return new ValidationResult("A senha precisa ter pelo menos uma letra maiúscula, uma letra minúscula, um número e um caractere especial.");
        }

        static bool TemNumeroEspecial(string input)
        {
            // A expressão regular verifica se há pelo menos um número (\d) e um caractere especial (pontuações e símbolos).
            string padrao = @"^(?=.*\d)(?=.*[^\da-zA-Z]).+$";

            // Testa se a string atende ao padrão.
            return Regex.IsMatch(input, padrao);
        }

    }
}
