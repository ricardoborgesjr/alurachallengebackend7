using System.ComponentModel.DataAnnotations;


namespace alurachallengebackend7.Models
{
    public class Depoimento
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Foto obrigatoria")]        
        public string Foto { get; set; }
        [Required(ErrorMessage = "Depoimento obrigatorio")]
        [MaxLength(2000, ErrorMessage = "O tamanho máximo do depoimento é de 2000 carcteres")]
        public string Texto { get; set; }
        [Required(ErrorMessage = "Depoimento obrigatorio")]
        [MaxLength(100, ErrorMessage = "O tamanho máximo do nome é de 100 carcteres")]
        public string Nome { get; set; }
    }
}