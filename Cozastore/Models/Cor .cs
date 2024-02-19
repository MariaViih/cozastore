using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cozastore.Models;

[Table("Cor")]
    public class Cor 
   {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id  { get; set; }

        [Required(ErrorMessage ="Por favor, informe o Nome")]
        [StringLength(30, ErrorMessage ="O Nome deve possuir no máximo 30 caracteres")]
        public string Nome {get; set;}

        
        [Display(Name ="código Hexa", Prompt = "Ex. #000000")]
        [Required(ErrorMessage ="Por favor, informe o código Hexa ")]
        [StringLength(7, ErrorMessage ="O código hexa  deve possuir no máximo 7 caracteres")]
        public string codigoHexa {get; set;}
   } 
