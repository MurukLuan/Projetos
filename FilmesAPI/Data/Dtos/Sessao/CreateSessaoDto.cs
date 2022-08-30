using System;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos.Sessao
{
    public class CreateSessaoDto
    {
        [Key]
        [Required]
        public int CinemaId { get; set; }
        public int FilmeId { get; set; }
        public DateTime HorarioEncerramento { get; set; }
    }
}
