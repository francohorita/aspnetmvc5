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
        
        public ActionResult Alumnos()
        {

            ViewData["Title"] = "Alumnos";
            SetViewDatas();
            
            /*1 admin 2 estudiante 3 profesor*/
            var profesoresList = DbContext.Usuarios.Where(user => user.Tipo == 2).ToList();

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View(profesoresList);

        }
        
        public ActionResult CreateCarrera()
        {

            ViewData["Title"] = "Crear";
            ViewData["SubTitle"] = "Nueva Carrera";
            SetViewDatas();

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View();

        }
        
        public ActionResult EditCarrera()
        {

            ViewData["Title"] = "Editar";
            ViewData["SubTitle"] = "Carrera";
            SetViewDatas();
            
            Carreras carreraToEdit;
            
            carreraToEdit = DbContext.Carreras.Find(Convert.ToInt32(Request.Query["Id"]));

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View(carreraToEdit);

        }
        
        public ActionResult ShowCarrera()
        {

            ViewData["Title"] = "View";
            ViewData["SubTitle"] = "Carrera";
            SetViewDatas();
            
            Carreras carreraToView;
            
            carreraToView = DbContext.Carreras.Find(Convert.ToInt32(Request.Query["Id"]));

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View(carreraToView);

        }
        
        public ActionResult CreateMateria()
        {

            ViewData["Title"] = "Crear";
            ViewData["SubTitle"] = "Nueva Materia";
            SetViewDatas();

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View();

        }
        
        public ActionResult EditMateria()
        {

            ViewData["Title"] = "Editar";
            ViewData["SubTitle"] = "Materia";
            SetViewDatas();
            
            Materias materiaToEdit;
            
            materiaToEdit = DbContext.Materias.Find(Convert.ToInt32(Request.Query["Id"]));

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View(materiaToEdit);

        }
        
        public ActionResult ShowMateria()
        {

            ViewData["Title"] = "View";
            ViewData["SubTitle"] = "Materia";
            SetViewDatas();
            
            Materias materiaToView;
            
            materiaToView = DbContext.Materias.Find(Convert.ToInt32(Request.Query["Id"]));

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View(materiaToView);

        }
        
        public ActionResult CreateUsuario()
        {

            ViewData["Title"] = "Crear";
            ViewData["SubTitle"] = "Nuevo Usuario";
            SetViewDatas();

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View();

        }
        
        public ActionResult EditUsuario()
        {

            ViewData["Title"] = "Editar";
            ViewData["SubTitle"] = "Usuario";
            SetViewDatas();
            
            Usuarios usuarioToEdit;
            
            usuarioToEdit = DbContext.Usuarios.Find(Convert.ToInt32(Request.Query["Id"]));

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View(usuarioToEdit);

        }
        
        public ActionResult ShowUsuario()
        {

            ViewData["Title"] = "View";
            ViewData["SubTitle"] = "Usuario";
            SetViewDatas();
            
            Usuarios usuarioToView;
            
            usuarioToView = DbContext.Usuarios.Find(Convert.ToInt32(Request.Query["Id"]));

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View(usuarioToView);

        }
        
    }
}