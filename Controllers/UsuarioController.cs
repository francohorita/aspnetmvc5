using System;
using System.Linq;
using aspnetmvc5.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnetmvc5.Controllers
{
    public class UsuarioController : DefaultController
    {
        
        public ActionResult Create()
        {
            
            if (Request.Query["Tipo"] == "2")
            {
                ViewData["SubTitle"] = "Nuevo Alumno";
                ViewBag.Section = "Alumnos";
            }
            else
            {
                ViewData["SubTitle"] = "Nuevo Profesor";
                ViewBag.Section = "Profesores";
            }
            
            ViewBag.MyUserType = Request.Query["Tipo"];
            
            ViewData["Title"] = "Crear";            
            SetViewDatas();

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View();

        }
        
        public ActionResult Edit()
        {

            if (Request.Query["Tipo"] == "2")
            {
                ViewData["SubTitle"] = "Editar Alumno";
                ViewBag.Section = "Alumnos";
            }
            else
            {
                ViewData["SubTitle"] = "Editar Profesor";
                ViewBag.Section = "Profesores";
            }
            
            ViewBag.MyUserType = Request.Query["Tipo"];
            
            ViewData["Title"] = "Editar";
            SetViewDatas();

            Usuarios usuarioToEdit = DbContext.Usuarios.Find(Convert.ToInt32(Request.Query["Id"]));

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View(usuarioToEdit);

        }
        
        public ActionResult Show()
        {

            if (Request.Query["Tipo"] == "2")
            {
                ViewData["SubTitle"] = "Alumno";
                ViewBag.Section = "Alumnos";
            }
            else
            {
                ViewData["SubTitle"] = "Profesor";
                ViewBag.Section = "Profesores";
            }
            
            ViewBag.MyUserType = Request.Query["Tipo"];
            
            ViewData["Title"] = "View";
            SetViewDatas();

            Usuarios usuarioToView = DbContext.Usuarios.Find(Convert.ToInt32(Request.Query["Id"]));

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View(usuarioToView);

        }
        
        public ActionResult Link()
        {

            if (Request.Query["Tipo"] == "2")
            {
                ViewData["SubTitle"] = "Asociar Alumno";
                ViewBag.Section = "Alumnos";
            }
            else
            {
                ViewData["SubTitle"] = "Asociar Profesor";
                ViewBag.Section = "Profesores";
            }
            
            ViewBag.MyUserType = Request.Query["Tipo"];
            
            ViewData["Title"] = "Link";
            SetViewDatas();
            
            var materialList = DbContext.Materias.ToList();

            var materiasConUsuario = new MateriasConUsuario {Materias = materialList, UserId = Request.Query["Id"]};

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View(materiasConUsuario);

        }
        
    }
}