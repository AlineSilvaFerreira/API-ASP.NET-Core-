using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DonnaAgencia.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Informe o nome do cliente")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o telefone do cliente")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Informe o CPF do cliente")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Informe o estado")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Informe a cidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Informe o bairro")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Informe a rua")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "Informe o número")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Informe o CEP")]
        public string CEP { get; set; }
    }
}
