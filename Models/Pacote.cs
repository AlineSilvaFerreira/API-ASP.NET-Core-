using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DonnaAgencia.Models
{
    [Table("Pacote")]
    public class Pacote
    {
        [Key]
        public int PacoteId { get; set; }

        [Required(ErrorMessage = "Informe a origem do voo")]
        public string Origem { get; set; }

        [Required(ErrorMessage = "Informe o destino do voo")]
        public string Destino { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataIda { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataVolta { get; set; }

        [Required(ErrorMessage = "Informeo que está incluso no pacote")]
        public string Incluso { get; set; }

        [Required(ErrorMessage = "Informe a quantidade de diárias")]
        public int Diarias { get; set; }

        [Required(ErrorMessage = "Informe o valor do pacote")]
        public double Valor { get; set; }

        public int Desconto { get; set; }
       
    }
}
