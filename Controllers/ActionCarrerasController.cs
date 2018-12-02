using System;
using aspnetmvc5.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnetmvc5.Controllers
{
    public class ActionCarrerasController : DefaultController
    {
        
        public ActionResult Delete()
        {
            
            Carreras CarreraToRemove;
            
            CarreraToRemove = DbContext.Carreras.Find(Convert.ToInt32(Request.Query["Id"]));
            DbContext.Carreras.Remove(CarreraToRemove);
            DbContext.SaveChanges();
            
            
            return RedirectToAction("Carreras", "Navigation");

        }

        public ActionResult Create()
        {
            
            var carreraToCreate = new Carreras();
            
            carreraToCreate.Nombre = Request.Form["Nombre"];
            carreraToCreate.Creado = DateTime.Now;
            DbContext.Carreras.Add(carreraToCreate);
            DbContext.SaveChanges();
            
            return RedirectToAction("Carreras", "Navigation");
        }
        
    }
}