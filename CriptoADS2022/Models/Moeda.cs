using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CriptoADS2022.Models
{
    [Table("Moedas")]
    public class Moeda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name ="Id: ")]
        public int id { get; set; }

        [StringLength(35)]
        [Required(ErrorMessage ="campo descrição é obrigatório...")]
        [Display(Name = "Descrição: ")]
        public string descricao { get; set; }

        [Display(Name = "Compra: ")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public float compra { get; set; }

        [Display(Name = "Venda")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public float venda { get; set; }
    }
}
