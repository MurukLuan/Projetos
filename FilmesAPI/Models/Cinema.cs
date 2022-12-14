using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FilmesAPI.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual Endereco Endereco { get; set; }
        public int EnderecoId { get; set; }
        [JsonIgnore]
        public virtual Gerente Gerente { get; set; }

        public int GerenteId { get; set; }

        [JsonIgnore]
        public virtual List<Sessao> Sessoes { get; set; }
    }
}
