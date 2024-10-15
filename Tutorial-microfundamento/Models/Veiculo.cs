using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tutorial_microfundamento.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage = "Obrigatório informar nome!")]
        public string Nome { get; set; }
        
        [Required (ErrorMessage = "Obrigatório informar placa!")]
        public string Placa  { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar Ano de fabricação!")]
        public int AnoFabricacao { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar Ano do modelo!")]
        public int AnoModelo { get; set; }
    }
}
