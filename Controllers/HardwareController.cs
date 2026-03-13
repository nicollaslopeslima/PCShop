using Microsoft.AspNetCore.Mvc;
using PCShop.Models;
using PCShop.Repositories.Interfaces;

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
            var hardware = _hardwareRepository.Hardwares;
            return View(hardware);
        }
    }
}
