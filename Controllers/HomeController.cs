using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using aspnetmvc5.Models;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore;

namespace aspnetmvc5.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            /*https://www.c-sharpcorner.com/article/configuration-in-asp-net-core/
            https://www.nuget.org/packages/MySql.Data.EntityFrameworkCore
            https://dev.mysql.com/doc/connector-net/en/connector-net-entityframework-core.html
            http://www.entityframeworktutorial.net/efcore/install-entity-framework-core.aspx*/
            Console.WriteLine("Start!");

            using (var context = new FacturasContext())
            {
                var facturas = context.Facturas;
                
                foreach(var factura in facturas)
                {
                    var data = new StringBuilder();
                    data.AppendLine($"ID: {factura.id}");
                    data.AppendLine($"Fecha: {factura.fecha}");
                    data.AppendLine($"Cliente: {factura.cliente}");
                    Console.WriteLine(data.ToString());
                }
            }

            return View();
        }

        public IActionResult About([FromServices] FacturasContext DB)
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
