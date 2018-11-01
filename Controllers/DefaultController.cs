using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using aspnetmvc5.Models;

namespace aspnetmvc5.Controllers
{
    public class DefaultController : Controller
    {
        protected void CheckedLoggedUser()
        {
            
        }
        
        protected void SetViewDatas()
        {
            ViewData["AppName"] = "FNF";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
