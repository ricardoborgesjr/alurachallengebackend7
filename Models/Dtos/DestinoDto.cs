
using System.ComponentModel.DataAnnotations;

namespace alurachallengebackend7.Models.Dtos
{
    public class DestinoDto
    {
        [Required(ErrorMessage = "Nome deve ser obrigatório")]
        [MaxLength(100, ErrorMessage = "O tamanho máximo para o nome de ver ser 100 caracteres")]
        public string Nome { get; set; }
        [Range(0.0, Double.MaxValue, ErrorMessage = "O valor dever ser maior ou igual a zero")]
        public double Preco { get; set; }
        public string Foto { get; set; }
    }
}