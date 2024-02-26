using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Cozastore.Models;

[Table("Categoria")]

public class Categoria
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id  { get; set; }

        [Required(ErrorMessage ="Por favor, informe o Nome")]
        [StringLength(30, ErrorMessage ="O Nome deve possuir no máximo 30 caracteres")]

        public string Nome {get; set;}

        [StringLength(300)]

        public string Foto { get; set; }

        [Display(Name ="Exibir com Filtro?")]

        public bool Filtrar { get; set; } = false;

        public bool Banner { get; set; } = false;
        [Display(Name = "Exibir como Banner?")]

        public int? CategoriaPaiId { get; set; }
        [ForeignKey("CategoriaPaiId")]

        public Categoria CategoriaPai { get; set; }
}
