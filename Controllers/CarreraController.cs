using System;
using aspnetmvc5.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnetmvc5.Controllers
{
    public class CarreraController : DefaultController
    {
        
        public ActionResult Create()
        {

            ViewData["Title"] = "Crear";
            ViewData["SubTitle"] = "Nueva Carrera";
            ViewBag.Section = "Carreras";
            SetViewDatas();

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View();

        }
        
        public ActionResult Edit()
        {

            ViewData["Title"] = "Editar";
            ViewData["SubTitle"] = "Carrera";
            ViewBag.Section = "Carreras";
            SetViewDatas();
            
            Carreras carreraToEdit;
            
            carreraToEdit = DbContext.Carreras.Find(Convert.ToInt32(Request.Query["Id"]));

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View(carreraToEdit);

        }
        
        public ActionResult Show()
        {

            ViewData["Title"] = "View";
            ViewData["SubTitle"] = "Carrera";
            ViewBag.Section = "Carreras";
            SetViewDatas();
            
            Carreras carreraToView;
            
            carreraToView = DbContext.Carreras.Find(Convert.ToInt32(Request.Query["Id"]));

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View(carreraToView);

        }
        
    }
}