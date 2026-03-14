using Microsoft.AspNetCore.Mvc;
using PCShop.Models;
using PCShop.Repositories.Interfaces;
using PCShop.ViewModels;

namespace PCShop.Controllers
{
    public class HardwareController : Controller
    {
        private readonly IHardwareRepository _hardwareRepository;

        public HardwareController(IHardwareRepository hardwareRepository)
        {
            _hardwareRepository = hardwareRepository;
        }

        public IActionResult List()
        {
            //var hardware = _hardwareRepository.Hardwares;
            //return View(hardware);
            var hardwaresListViewModel = new HardwareListViewModel();
            hardwaresListViewModel.Hardwares = _hardwareRepository.Hardwares;
            hardwaresListViewModel.CategoriaAtual = "Categoria Atual";

            return View(hardwaresListViewModel);
        }
    }
}
