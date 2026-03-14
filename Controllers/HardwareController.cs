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
            ViewData["Titulo"] = "Hardwares";
            ViewData["Data"] = DateTime.Now;

            var hardware = _hardwareRepository.Hardwares;
            var totalHardwares = hardware.Count();

            ViewBag.Total = "Total hardware : ";
            ViewBag.TotalHardwares = totalHardwares;

            return View(hardware);
        }
    }
}
