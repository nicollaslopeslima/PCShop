namespace PCShop.Models
{
    public class Hardware
    {
        public int HardwareId { get; set; }
        public string Nome { get; set; }
        public string DescricaoCurta { get; set; }
        public string DescricaoDetalhada { get; set; }
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }
        public string ImagemThumbnailUrl { get; set; }
        public bool IsHardwarePreferido { get; set; }
        public bool EmEstoque { get; set; }

        public int CategoraId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
