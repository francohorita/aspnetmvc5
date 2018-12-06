using System;
using aspnetmvc5.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnetmvc5.Controllers
{
    public class ActionUsuariosController : DefaultController
    {
        
        public ActionResult Delete()
        {
            var usuarioToRemove = DbContext.Usuarios.Find(Convert.ToInt32(Request.Query["Id"]));
            DbContext.Usuarios.Remove(usuarioToRemove);
            DbContext.SaveChanges();
            
            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : RedirectToAction("Materias", "Navigation");

        }

        public ActionResult Create()
        {
            
            var usuarioToCreate = new Usuarios();
            
            usuarioToCreate.Tipo = Convert.ToInt32(Request.Form["myUserType"]);
            usuarioToCreate.Nombre = Request.Form["Nombre"];
            usuarioToCreate.Apellido = Request.Form["Apellido"];
            usuarioToCreate.Dni = Convert.ToInt32(Request.Form["Dni"]);
            usuarioToCreate.Legajo = Convert.ToInt32(Request.Form["Legajo"]);
            usuarioToCreate.Mail = Request.Form["Mail"];
            usuarioToCreate.Password = Request.Form["Password"];
            usuarioToCreate.Fechanac = Convert.ToDateTime(Request.Form["Fechanac"]);
            usuarioToCreate.Ingreso = Convert.ToDateTime(Request.Form["Ingreso"]);
            
            usuarioToCreate.Sueldo = Request.Form["myUserType"] == "3" ? Convert.ToInt32(Request.Form["Sueldo"]) : 0;
            
            usuarioToCreate.Creado = DateTime.Now;
            
            DbContext.Usuarios.Add(usuarioToCreate);
            DbContext.SaveChanges();

            if (Request.Form["myUserType"] == "3")
                return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : RedirectToAction("Profesores", "Navigation");    
            else
                return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : RedirectToAction("Alumnos", "Navigation");
            
        }
        
        public ActionResult Edit()
        {
            
            var usuarioToCreate = new Usuarios();
            
            usuarioToCreate.Tipo = Convert.ToInt32(Request.Form["myUserType"]);
            usuarioToCreate.Nombre = Request.Form["Nombre"];
            usuarioToCreate.Apellido = Request.Form["Apellido"];
            usuarioToCreate.Dni = Convert.ToInt32(Request.Form["Dni"]);
            usuarioToCreate.Legajo = Convert.ToInt32(Request.Form["Legajo"]);
            usuarioToCreate.Mail = Request.Form["Mail"];
            usuarioToCreate.Password = Request.Form["Password"];
            usuarioToCreate.Fechanac = Convert.ToDateTime(Request.Form["Fechanac"]);
            usuarioToCreate.Ingreso = Convert.ToDateTime(Request.Form["Ingreso"]);
            
            usuarioToCreate.Sueldo = Request.Form["myUserType"] == "3" ? Convert.ToInt32(Request.Form["Sueldo"]) : 0;
            
            DbContext.Usuarios.Update(usuarioToCreate);
            DbContext.SaveChanges();
            
            if (Request.Form["myUserType"] == "3")
                return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : RedirectToAction("Profesores", "Navigation");    
            else
                return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : RedirectToAction("Alumnos", "Navigation");
            
        }
        
    }
}