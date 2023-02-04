using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Para o comando Required funcione, precisamos adicionar referência. 
using System.Text;

namespace CursoWindowsFormsBiblioteca.Classes
{
    public class Cliente
    {
        public class Unit
        {
            [Required(ErrorMessage = "Código do cliente é obrigatório!")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Código do cliente somente aceita valores numéricos!")]
            [StringLength(6, MinimumLength = 6, ErrorMessage = "Código do cliente deve ter 6 dígitos!")] // 6, significa largura maxima
            public string Id { get; set; }

            [Required(ErrorMessage = "Nome do cliente é obrigatório!")]
            [StringLength(50, ErrorMessage = "Nome do cliente deve ter no máximo 50 caracteres!")]
            public string Nome { get; set; }

            [StringLength(50, ErrorMessage = "Nome do Pai do cliente deve ter no máximo 50 caracteres!")]
            public string NomePai { get; set; }

            [Required(ErrorMessage = "Nome da mãe é obrigatório!")]
            [StringLength(50, ErrorMessage = "Nome da mãe do cliente deve ter no máximo 50 caracteres!")]
            public string NomeMae { get; set; }
            public bool NaoTemPai { get; set; }

            [Required(ErrorMessage = "CPF é obrigatório!")]
            [RegularExpression("([0-9])+", ErrorMessage = "O CPF deve ter somente números!")]
            [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF deve ter 11 dígitos!")]
            public string CPF { get; set; }

            [Required(ErrorMessage = "Gênero deve ser preenchido!")]
            public int Genero { get; set; }

            [Required(ErrorMessage = "CEP é obrigatório!")]
            [RegularExpression("([0-9])+", ErrorMessage = "O CEP deve ter somente números!")]
            [StringLength(8, MinimumLength = 8, ErrorMessage = "O CEP deve ter 8 dígitos!")]
            public string CEP { get; set; }

            [Required(ErrorMessage = "Logradouro é obrigatório!")]
            [StringLength(100, ErrorMessage = "O logradouro deve ter no máximo, 100 caracteres!")]
            public string Logradouro { get; set; }
            public string Complemento { get; set; }

            [Required(ErrorMessage = "Bairro é obrigatório!")]
            [StringLength(50, ErrorMessage = "O bairro deve ter no máximo, 50 caracteres!")]
            public string Bairro { get; set; }

            [Required(ErrorMessage = "Cidade é obrigatório!")]
            [StringLength(20, ErrorMessage = "O Cidade deve ter no máximo, 20 caracteres!")]
            public string Cidade { get; set; }

            [Required(ErrorMessage = "Estado é obrigatório!")]
            [StringLength(50, ErrorMessage = "O Estado deve ter no máximo, 05 caracteres!")]
            public string Estado { get; set; }

            [Required(ErrorMessage = "Telefone é obrigatório!")]
            [RegularExpression("([0-9])+", ErrorMessage = "O Telefone deve ter somente números!")]
            [StringLength(12, MinimumLength = 8, ErrorMessage = "O Telefone deve ter 8 dígitos no mínimo!")]
            public string Telefone { get; set; }
            public string Profissao { get; set; }

            [Required(ErrorMessage = "Renda Familiar é obrigatório!")]
            [Range(0, double.MaxValue, ErrorMessage = "O valor deve ser positivo")]
            public double RendaFamiliar { get; set; }

            public void ValidaClasse()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();

                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new ValidationException(sbrErrors.ToString());
                }
            }

            public void ValidaComplemento()
            {
                if (this.NomePai == this.NomeMae)
                {
                    throw new Exception("Nome do Pai igual ao Nome da Mãe!");
                }

                if (this.NaoTemPai == false)
                {
                    if (this.NomePai == "")
                    {
                        throw new Exception("Nome do pai não pode estar vazio!");
                    }
                }

                bool validaCPF = Cls_Uteis.Valida(this.CPF);

                if (validaCPF == false)
                {
                    throw new Exception("CPF inválido!");
                }
            }


        }

        public class List
        {
            public List<Unit> ListUnit { get; set; }
        }

        public static string SerializedClassUnit(Unit unit)
        {
            return JsonConvert.SerializeObject(unit);
        }

        public static Unit DesSerializedClassUnit(string vJson)
        {
            return JsonConvert.DeserializeObject<Unit>(vJson);
        }

    }
}
