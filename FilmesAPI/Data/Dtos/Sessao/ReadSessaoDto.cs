using FilmesAPI.Models;
using System;

namespace FilmesAPI.Data.Dtos.Sessao
{
    public class ReadSessaoDto
    {
        public int Id { get; set; }
        public Models.Filme Filme { get; set; }
        public Cinema Cinema { get; set; }

        public DateTime HorarioEncerramento { get; set; }
        public DateTime HorarioInicio { get; set; }

    }
}
