using System;
using aspnetmvc5.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnetmvc5.Controllers
{
    public class ActionCarrerasController : DefaultController
    {
        public ActionResult DeleteCarrera()
        {
            
            var CarreraToRemove = new Carreras();
            
            CarreraToRemove = DbContext.Carreras.Find(Convert.ToInt32(Request.Query["Id"]));
            DbContext.Carreras.Remove(CarreraToRemove);
            DbContext.SaveChanges();
            
            
            return RedirectToAction("Carreras", "Navigation");

        }
    }
}