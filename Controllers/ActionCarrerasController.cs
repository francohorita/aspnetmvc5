using System;
using aspnetmvc5.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnetmvc5.Controllers
{
    public class ActionCarrerasController : DefaultController
    {
        
        public ActionResult Delete()
        {
            
            Carreras carreraToRemove;
            
            carreraToRemove = DbContext.Carreras.Find(Convert.ToInt32(Request.Query["Id"]));
            DbContext.Carreras.Remove(carreraToRemove);
            DbContext.SaveChanges();
            
            
            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : RedirectToAction("Carreras", "Navigation");

        }

        public ActionResult Create()
        {
            
            var carreraToCreate = new Carreras();
            
            carreraToCreate.Nombre = Request.Form["Nombre"];
            carreraToCreate.Creado = DateTime.Now;
            DbContext.Carreras.Add(carreraToCreate);
            DbContext.SaveChanges();
            
            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : RedirectToAction("Carreras", "Navigation");
            
        }
        
        public ActionResult Edit()
        {
            
            var carreraToEdit = new Carreras();
            carreraToEdit.Id = Convert.ToInt32(Request.Form["Id"]);
            carreraToEdit.Nombre = Request.Form["Nombre"];
            DbContext.Carreras.Update(carreraToEdit);
            DbContext.SaveChanges();
            
            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : RedirectToAction("Carreras", "Navigation");
            
        }
        
    }
}