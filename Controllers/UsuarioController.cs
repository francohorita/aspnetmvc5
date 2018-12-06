using System;
using aspnetmvc5.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnetmvc5.Controllers
{
    public class UsuarioController : DefaultController
    {
        
        public ActionResult Create()
        {

            ViewData["Title"] = "Crear";
            ViewData["SubTitle"] = "Nuevo Usuario";
            SetViewDatas();

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View();

        }
        
        public ActionResult Edit()
        {

            ViewData["Title"] = "Editar";
            ViewData["SubTitle"] = "Usuario";
            SetViewDatas();
            
            Usuarios usuarioToEdit;
            
            usuarioToEdit = DbContext.Usuarios.Find(Convert.ToInt32(Request.Query["Id"]));

            return SessionUser.Mail == null ? (ActionResult) RedirectToAction("Login", "Navigation") : View(usuarioToEdit);

        }
        
        public ActionResult Show()
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