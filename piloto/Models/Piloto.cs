using System.ComponentModel.DataAnnotations;

namespace piloto.Models
{
    public class Piloto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Equipe { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        public int Idade { get; set; }
    }
}
