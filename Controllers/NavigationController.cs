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
            
            var carrerasList = DbContext.Carreras.ToList();

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View(carrerasList);

        }
        
        public ActionResult Materias()
        {
            ViewData["Title"] = "Materias";
            SetViewDatas();
            
            var materialList = DbContext.Materias.ToList();

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View(materialList);

        }
        
        public ActionResult Profesores()
        {

            ViewData["Title"] = "Profesores";
            SetViewDatas();
            
            /*1 admin 2 estudiante 3 profesor*/
            var profesoresList = DbContext.Usuarios.Where(user => user.Tipo == 3).ToList();

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View(profesoresList);

        }
        
        public ActionResult CrearCarrera()
        {

            ViewData["Title"] = "Crear";
            ViewData["SubTitle"] = "Nueva Carrera";
            SetViewDatas();

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View();

        }
        
    }
}