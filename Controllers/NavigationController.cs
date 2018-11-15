using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace aspnetmvc5.Controllers
{
    public class NavigationController : DefaultController
    {
        
        public ActionResult Login()
        {
            ViewData["Title"] = "Login";
            SetViewDatas();

            return View();
        }
        
        public ActionResult Carreras()
        {
            ViewData["Title"] = "Carreras";
            SetViewDatas();
            
            var carrerasList = dbContext.Carreras.ToList();

            return miUsuario.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View(carrerasList);

        }
        
        public ActionResult Materias()
        {
            ViewData["Title"] = "Materias";
            SetViewDatas();
            
            var materialList = dbContext.Materias.ToList();

            return miUsuario.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View(materialList);

        }
        
        public ActionResult Profesores()
        {

            ViewData["Title"] = "Profesores";
            SetViewDatas();
            
            /*1 admin 2 estudiante 3 profesor*/
            var profesoresList = dbContext.Usuarios.Where(user => user.Tipo == 3).ToList();

            return miUsuario.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View(profesoresList);

        }
    }
}