using PCShop.Models;

namespace PCShop.ViewModels
{
    public class HardwareListViewModel
    {
        public IEnumerable<Hardware> Hardwares { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
