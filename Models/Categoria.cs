using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCShop.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [StringLength(100, ErrorMessage = "Maximum length: 100 characters.")]
        [Required(ErrorMessage = "Category name is required.")]
        [Display(Name = "Name")]
        public string CategoriaNome { get; set; }

        [StringLength(200, ErrorMessage = "Maximum length: 200 characters.")]
        [Required(ErrorMessage = "Enter a description for the category.")]
        [Display(Name = "Description")]
        public string Descricao { get; set; }

        public List<Hardware> Hardwares { get; set; }
    }
}
