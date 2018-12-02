using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using aspnetmvc5.Models;

namespace aspnetmvc5.Controllers
{
    public class DefaultController : Controller
    {
        protected static readonly Usuarios SessionUser = new Usuarios();
        protected readonly MySqlDbContext DbContext = new MySqlDbContext();
        
        protected void SetViewDatas()
        {
            ViewData["AppName"] = "Doggo HS";
            ViewData["Authors"] = "Horita, Litardo & Ravinale";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
