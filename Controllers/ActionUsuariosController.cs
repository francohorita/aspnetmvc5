using System;
using aspnetmvc5.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnetmvc5.Controllers
{
    public class ActionUsuariosController : DefaultController
    {
        
        public ActionResult Delete()
        {
            
            Usuarios usuarioToRemove;
            
            usuarioToRemove = DbContext.Usuarios.Find(Convert.ToInt32(Request.Query["Id"]));
            DbContext.Usuarios.Remove(usuarioToRemove);
            DbContext.SaveChanges();
            
            
            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : RedirectToAction("Materias", "Navigation");

        }

        public ActionResult Create()
        {
            
            var usuarioToCreate = new Usuarios();
            
            usuarioToCreate.Nombre = Request.Form["Nombre"];
            usuarioToCreate.Creado = DateTime.Now;
            DbContext.Usuarios.Add(usuarioToCreate);
            DbContext.SaveChanges();
            
            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : RedirectToAction("Materias", "Navigation");
            
        }
        
        public ActionResult Edit()
        {
            
            var usuarioToEdit = new Usuarios();
            usuarioToEdit.Id = Convert.ToInt32(Request.Form["Id"]);
            usuarioToEdit.Nombre = Request.Form["Nombre"];
            DbContext.Usuarios.Update(usuarioToEdit);
            DbContext.SaveChanges();
            
            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : RedirectToAction("Materias", "Navigation");
            
        }
        
    }
}