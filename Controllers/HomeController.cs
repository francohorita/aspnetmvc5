using System.Linq;
using Microsoft.AspNetCore.Mvc;
using aspnetmvc5.Models;
using Newtonsoft.Json;

namespace aspnetmvc5.Controllers
{
    public class HomeController : DefaultController
    {
        private readonly MySqlDbContext dbContext = new MySqlDbContext();

        public ActionResult Index()
        {
            ViewData["Title"] = "Sistema";
            
            var carreras = dbContext.Carreras.ToList();
            foreach (var c in carreras)
            {
                System.Console.WriteLine($"ID:{c.Id} Nombre:{c.Nombre} Creado:{c.Creado}");
            }

            SetViewDatas();

            return View();
        }

        public ActionResult Home()
        {
            var loginUser = dbContext.Usuarios.FirstOrDefault(usr => usr.Mail == Request.Form["email"] && usr.Password == Request.Form["password"]);

            if (loginUser != null)
            {
                DefaultController.miUsuario.Mail = loginUser.Mail;
                ViewData["Title"] = "Contacto";
                ViewData["Message"] = "Your contact page.";

                SetViewDatas();

                return View();
                
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }

    }
}
