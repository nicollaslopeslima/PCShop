using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCShop.Models
{
    [Table("Hardwares")]
    public class Hardware
    {
        [Key]
        public int HardwareId { get; set; }

        [Required(ErrorMessage = "Hardware name is required.")]
        [Display(Name = "Hardware Name")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "Hardware name must be between 10 and 80 characters.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Hardware description is required.")]
        [Display(Name = "Hardware Description")]
        [MinLength(20, ErrorMessage = "Hardware description must be at least 20 characters long.")]
        [MaxLength(200, ErrorMessage = "Hardware description cannot exceed 200 characters.")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "The detailed description of the hardware must be provided")]
        [Display(Name = "Detailed Hardware Description.")]
        [MinLength(20, ErrorMessage = "Hardware description must be at least 20 characters long.")]
        [MaxLength(200, ErrorMessage = "Hardware description cannot exceed 200 characters.")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "Hardware price is required.")]
        [Display(Name = "Price")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 9999999.99, ErrorMessage = "The price must be between 1 and 9999999.99.")]
        public decimal Preco { get; set; }

        [Display(Name = "Image URL")]
        [StringLength(200, ErrorMessage = "Maximum length: 200 characters.")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Thumbnail Image URL")]
        [StringLength(200, ErrorMessage = "Maximum length: 200 characters.")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Is Preferred Hardware?")]
        public bool IsHardwarePreferido { get; set; }

        [Display(Name = "Stock")]
        public bool EmEstoque { get; set; }

        public int CategoraId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
