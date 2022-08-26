using FilmesAPI.Models;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FilmesAPI.Data.Dtos.Gerente
{
    public class ReadGerenteDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        
        public object Cinemas { get; set; }
    }
}
