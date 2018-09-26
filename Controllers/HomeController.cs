using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using aspnetmvc5.Models;

namespace aspnetmvc5.Controllers
{
    public class HomeController : DefaultController
    {

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

        public IActionResult Login()
        {
            ViewData["Message"] = "Por ingrese sus datos.";

            SetViewDatas();

            return View();
        }
        
        public IActionResult Register()
        {
            SetViewDatas();
            
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            SetViewDatas();

            return View();
        }

        public IActionResult Test()
        {
            SetViewDatas();
            
            return View();
        }

    }
}
