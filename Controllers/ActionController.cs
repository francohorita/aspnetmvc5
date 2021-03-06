﻿using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace aspnetmvc5.Controllers
{
    public class ActionController : DefaultController
    {
        [HttpPost]
        public ActionResult Login()
        {

            var loginUser = DbContext.Usuarios.FirstOrDefault(
                user => user.Mail == Request.Form["email"] && user.Password == Request.Form["password"]);
            
            if (loginUser != null)
            {
                SessionUser.Mail = loginUser.Mail;
                SessionUser.Tipo = loginUser.Tipo;
            
                return RedirectToAction("Carreras", "Navigation");
            }
            else
            {
                return RedirectToAction("Login", "Navigation", new {Message = "Datos incorrectos."});
            }
            
        }
        
        public ActionResult Logout()
        {
            SessionUser.Mail = null;
            
            return RedirectToAction("Login", "Navigation");
        }

    }
}
