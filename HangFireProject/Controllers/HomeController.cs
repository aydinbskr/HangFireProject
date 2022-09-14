using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HangFireProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            MyHangFire.MyHangFire.MyTxtJobs($"İlk Method {DateTime.Now:U}");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}