using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos.Filme
{
    public class UpdateFilmeDto
    {
        [Required(ErrorMessage = "O titulo não pode ficar em branco")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo diretor é obrigatório")]
        public string Diretor { get; set; }
        [MaxLength(60, ErrorMessage = "O campo Genero não pode passar de 10 caracteres")]
        public string Genero { get; set; }
        [Range(1, 280, ErrorMessage = "O tempo tem que tre no minimo 1 e no maximo 280 minutos")]
        public int Duracao { get; set; }
    }
}
