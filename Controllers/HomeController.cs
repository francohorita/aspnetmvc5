using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspnetmvc5.Models;

namespace aspnetmvc5.Controllers
{
    public class HomeController : Controller
    {
        private void SetViewDatas()
        {
            ViewData["AppName"] = "FNF";
        }

        public IActionResult Index()
        {
            var dbContext = new Sql10253958Context();
            var facturas = dbContext.Facturas.ToList();
            foreach (var f in facturas)
            {
                System.Console.WriteLine($"ID:{f.Id} Fecha:{f.Fecha} Cliente:{f.Cliente} Usuario:{f.Usuario}");
            }

            SetViewDatas();

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            SetViewDatas();

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            SetViewDatas();

            return View();
        }

        public IActionResult Privacy()
        {
            SetViewDatas();
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
