using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos.Filme
{
    public class CreateEnderecoDto
    {
        [Required (ErrorMessage ="O campo logradouro é obrigatorio!")]
        
        [MaxLength(100, ErrorMessage ="O logradouro deve conter menos que 100 caracteres")]
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        [Required(ErrorMessage ="Campo bairro deve ser preenchido")]
        [MaxLength(100, ErrorMessage ="O campo deve ter no máximo 100")]
        public string Bairro { get; set; }
    }
}
