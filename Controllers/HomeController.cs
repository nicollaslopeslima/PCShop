using PCShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.IdentityModel.Tokens;
using PCShop.Repositories.Interfaces;
using PCShop.ViewModels;

namespace PCShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHardwareRepository _hardwareRepository;

        public HomeController(IHardwareRepository hardwareRepository)
        {
            _hardwareRepository = hardwareRepository;
        }

        public IActionResult Index()
        { 
            var homeViewModel = new HomeViewModel
            {
                HardwaresPreferidos = _hardwareRepository.HardwaresPreferidos
            };
            return View(homeViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}