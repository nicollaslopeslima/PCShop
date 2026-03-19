using Microsoft.AspNetCore.Mvc;
using PCShop.Models;
using PCShop.Repositories.Interfaces;
using PCShop.ViewModels;

namespace PCShop.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly IHardwareRepository _hardwareRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraController(IHardwareRepository hardwareRepository,
            CarrinhoCompra carrinhoCompra)
        {
            _hardwareRepository = hardwareRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        public IActionResult Index()
        {
            var itens = _carrinhoCompra.GetCarrinhoCompraItens();

            _carrinhoCompra.CarrinhoCompraItems = itens;
            var carrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
            };
            return View(carrinhoCompraVM);
        }

        public IActionResult AdicionarItemNoCarrinhoCompra(int hardwareId)
        {
            var hardwareSelecionado = _hardwareRepository.Hardwares.
                                      FirstOrDefault(p => p.HardwareId == hardwareId);

            if (hardwareSelecionado != null)
            {
                _carrinhoCompra.AdicionarAoCarrinho(hardwareSelecionado);
            }
            return RedirectToAction("Index");
        }

        public IActionResult RemoverItemDoCarrinhoCompra(int hardwareId)
        {
            var hardwareSelecionado = _hardwareRepository.Hardwares.
                                      FirstOrDefault(p => p.HardwareId == hardwareId);
            if (hardwareSelecionado != null)
            {
                _carrinhoCompra.RemoverDoCarrinho(hardwareSelecionado);
            }
            return RedirectToAction("Index");
        }
    }
}
