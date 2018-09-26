using aspnetmvc5.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnetmvc5.Controllers
{
    public class TestController : DefaultController
    {
        public IActionResult Prueba()
        {
            SetViewDatas();
            
            Usuarios usuario = new Usuarios();
            
            ViewData["Edad"] = usuario.CalcularEdad();

            return View();
        }

    }
}