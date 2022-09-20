using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ZodiacSign_.Models;
using Application.Models;
using Application.Services;

namespace ZodiacSign_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ZodiacSignServices _services = new();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(_services.GetZodiacSign());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(ZodiacSignModel data)
        {
            _services.ZodiacSign(data);
            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}