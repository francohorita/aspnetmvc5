using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspnetmvc5.Models;
using Microsoft.AspNetCore.Authorization;

namespace aspnetmvc5.Controllers
{
    public class HomeController : DefaultController
    {
        private readonly MySqlDbContext dbContext = new MySqlDbContext();

        public ActionResult Index()
        {
            ViewData["Title"] = "Login";

            SetViewDatas();

            return View();
        }
        

        public ActionResult Carreras()
        {

            ViewData["Title"] = "Carreras";
                
            List<Carreras> carrerasList = dbContext.Carreras.ToList();
            
                SetViewDatas();

                return View(carrerasList);

        }
        
        
        
        [HttpPost]
        public ActionResult Login()
        {
            var loginUser = dbContext.Usuarios.First(
                user => user.Mail == Request.Form["email"] && user.Password == Request.Form["password"]);

            if (loginUser != null)
            {
                DefaultController.miUsuario.Mail = loginUser.Mail;
                
                /*foreach (var c in carreras)
                {
                    System.Console.WriteLine($"ID:{c.Id} Nombre:{c.Nombre} Creado:{c.Creado}");
                }*/

                return RedirectToAction("Carreras", "Home");
                
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            
        }

    }
}
