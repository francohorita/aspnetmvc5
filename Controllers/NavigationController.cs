using System;
using System.Linq;
using aspnetmvc5.Models;
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
            ViewBag.Section = "Carreras";
            SetViewDatas();
            
            var carrerasList = DbContext.Carreras.ToList();

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View(carrerasList);

        }
        
        public ActionResult Materias()
        {
            ViewData["Title"] = "Materias";
            ViewBag.Section = "Materias";
            SetViewDatas();
            
            var materialList = DbContext.Materias.ToList();

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View(materialList);

        }
        
        public ActionResult Profesores()
        {

            ViewData["Title"] = "Profesores";
            ViewBag.Section = "Profesores";
            SetViewDatas();
            
            /*1 admin 2 estudiante 3 profesor*/
            var profesoresList = DbContext.Usuarios.Where(user => user.Tipo == 3).ToList();

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View(profesoresList);

        }
        
        public ActionResult Alumnos()
        {

            ViewData["Title"] = "Alumnos";
            ViewBag.Section = "Alumnos";
            SetViewDatas();
            
            /*1 admin 2 estudiante 3 profesor*/
            var profesoresList = DbContext.Usuarios.Where(user => user.Tipo == 2).ToList();

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View(profesoresList);

        }
        
    }
}