using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Nguyenvanbac_231230717_de01.Models;

namespace Nguyenvanbac_231230717_de01.Controllers
{
    public class NvbHomeController : Controller
    {
        private readonly ILogger<NvbHomeController> _logger;

        public NvbHomeController(ILogger<NvbHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
