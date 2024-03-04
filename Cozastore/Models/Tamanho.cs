using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cozastore.Models;

 [Table("tamanho")]
    public class Tamanho
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id  { get; set; }

        [Required(ErrorMessage ="Por favor, Informe a sigla")]
        [StringLength(5, ErrorMessage ="A sigla deve possuir mo máximo 5")]
        public string Sigla {get; set; }

        [Required(ErrorMessage ="Por favor, informe o Nome")]
        [StringLength(30, ErrorMessage ="O Nome deve possuir no máximo 30 caracteres")]
        public string Nome {get; set;}

        public ICollection<Estoque> Estoque { get; set; }

}