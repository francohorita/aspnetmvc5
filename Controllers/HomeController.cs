using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using aspnetmvc5.Models;

namespace aspnetmvc5.Controllers
{
    public class HomeController : DefaultController
    {
        private readonly MySqlDbContext dbContext = new MySqlDbContext();

        public ActionResult Index()
        {
            ViewData["Title"] = "Sistema";

            SetViewDatas();

            return View();
        }

        public ActionResult Carreras()
        {
            var loginUser = dbContext.Usuarios.FirstOrDefault(usr => usr.Mail == Request.Form["email"] && usr.Password == Request.Form["password"]);

            if (loginUser != null)
            {
                DefaultController.miUsuario.Mail = loginUser.Mail;
                ViewData["Title"] = "Carreras";
                
                List<Carreras> carreras = dbContext.Carreras.ToList();
                /*foreach (var c in carreras)
                {
                    System.Console.WriteLine($"ID:{c.Id} Nombre:{c.Nombre} Creado:{c.Creado}");
                }*/

                SetViewDatas();

                return View(carreras);
                
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }

    }
}
