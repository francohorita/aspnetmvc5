using System;
using aspnetmvc5.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnetmvc5.Controllers
{
    public class ActionMateriasController : DefaultController
    {
        
        public ActionResult Delete()
        {
            
            Materias materiaToRemove;
            
            materiaToRemove = DbContext.Materias.Find(Convert.ToInt32(Request.Query["Id"]));
            DbContext.Materias.Remove(materiaToRemove);
            DbContext.SaveChanges();
            
            
            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : RedirectToAction("Materias", "Navigation");

        }

        public ActionResult Create()
        {
            
            var materiaToCreate = new Materias();
            
            materiaToCreate.Nombre = Request.Form["Nombre"];
            materiaToCreate.Creado = DateTime.Now;
            DbContext.Materias.Add(materiaToCreate);
            DbContext.SaveChanges();
            
            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : RedirectToAction("Materias", "Navigation");
            
        }
        
        public ActionResult Edit()
        {
            
            var materiaToEdit = new Materias();
            materiaToEdit.Id = Convert.ToInt32(Request.Form["Id"]);
            materiaToEdit.Nombre = Request.Form["Nombre"];
            DbContext.Materias.Update(materiaToEdit);
            DbContext.SaveChanges();
            
            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : RedirectToAction("Materias", "Navigation");
            
        }
        
    }
}