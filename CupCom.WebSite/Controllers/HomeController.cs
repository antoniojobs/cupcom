using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CupCom.WebSite.Models;

namespace CupCom.WebSite.Controllers
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
            return View();
        }
        //https://localhost:44331/Home/TimeCadastro?Nome=Brasil&TotalPontos=5
        public IActionResult TimeCadastro(Time time)
        {
            return View(time);
        }
        public IActionResult ListarTimes()
        {
            return View();
        }
        public IActionResult CriarDisputas()
        {
            return View();
        }
        public IActionResult ListarDisputa()
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
