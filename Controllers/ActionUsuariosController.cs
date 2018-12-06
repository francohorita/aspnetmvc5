using System;
using System.Linq;
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

            if (Request.Query["Tipo"] == "3")
                return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : RedirectToAction("Profesores", "Navigation");
            else
                return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : RedirectToAction("Alumnos", "Navigation");

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
        
        public ActionResult Link()
        {

            if (Request.Form["myUserType"] == "3")
            {
                var checkLink = DbContext.MateriasProfesores.FirstOrDefault(link => link.UsuarioId == Convert.ToInt32(Request.Form["UsuarioId"]) && link.MateriaId == Convert.ToInt32(Request.Form["MateriaId"]));
                if (checkLink == null)
                {
                    var usuarioToLink = new MateriasProfesores
                    {
                        UsuarioId = Convert.ToInt32(Request.Form["UsuarioId"]),
                        MateriaId = Convert.ToInt32(Request.Form["MateriaId"]),
                        Creado = DateTime.Now
                    };
                    DbContext.MateriasProfesores.Add(usuarioToLink);
                }
            }
            else
            {
                var checkLink = DbContext.AlumnosMaterias.FirstOrDefault(link => link.UsuarioId == Convert.ToInt32(Request.Form["UsuarioId"]) && link.MateriaId == Convert.ToInt32(Request.Form["MateriaId"]));
                if (checkLink == null)
                {
                    var usuarioToLink = new AlumnosMaterias
                    {
                        UsuarioId = Convert.ToInt32(Request.Form["UsuarioId"]),
                        MateriaId = Convert.ToInt32(Request.Form["MateriaId"]),
                        Creado = DateTime.Now
                    };
                    DbContext.AlumnosMaterias.Add(usuarioToLink);
                }
            }
            
            DbContext.SaveChanges();

            if (Request.Form["myUserType"] == "3")
                return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : RedirectToAction("Profesores", "Navigation");    
            else
                return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : RedirectToAction("Alumnos", "Navigation");
            
        }
        
    }
}