using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos.Filme
{

    public class CreateCinemaDto
    {
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="Id de endereço necessario")]
        public int EnderecoId { get; set; }
        [Required(ErrorMessage = "Id de gerente necessario")]
        public int GerenteId { get; set; }
    }

}
