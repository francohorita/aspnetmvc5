using System;
using System.Linq;
using aspnetmvc5.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnetmvc5.Controllers
{
    public class MateriaController : DefaultController
    {
        
        public ActionResult Create()
        {

            ViewData["Title"] = "Crear";
            ViewData["SubTitle"] = "Nueva Materia";
            ViewBag.Section = "Materias";
            SetViewDatas();

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View();

        }
        
        public ActionResult Edit()
        {

            ViewData["Title"] = "Editar";
            ViewData["SubTitle"] = "Materia";
            ViewBag.Section = "Materias";
            SetViewDatas();
            
            Materias materiaToEdit;
            
            materiaToEdit = DbContext.Materias.Find(Convert.ToInt32(Request.Query["Id"]));

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View(materiaToEdit);

        }
        
        public ActionResult Show()
        {

            ViewData["Title"] = "View";
            ViewData["SubTitle"] = "Materia";
            ViewBag.Section = "Materias";
            SetViewDatas();
            
            Materias materiaToView;
            
            materiaToView = DbContext.Materias.Find(Convert.ToInt32(Request.Query["Id"]));

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View(materiaToView);

        }
        
        public ActionResult Link()
        {

            ViewData["Title"] = "Link";
            ViewData["SubTitle"] = "Materia";
            ViewBag.Section = "Materias";
            SetViewDatas();
            
            var carrerasList = DbContext.Carreras.ToList();

            var carrerasConMateria = new CarrerasConMateria {Carreras = carrerasList, MateriaId = Request.Query["Id"]};

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View(carrerasConMateria);

        }
        
    }
}