using System.Linq;
using Microsoft.AspNetCore.Mvc;
using aspnetmvc5.Models;

namespace aspnetmvc5.Controllers
{
    public class HomeController : DefaultController
    {

        public IActionResult Index()
        {
            var dbContext = new MySqlDbContext();
            var carreras = dbContext.Carreras.ToList();
            foreach (var c in carreras)
            {
                System.Console.WriteLine($"ID:{c.Id} Nombre:{c.Nombre} Creado:{c.Creado}");
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
