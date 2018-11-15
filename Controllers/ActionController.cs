using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace aspnetmvc5.Controllers
{
    public class ActionController : DefaultController
    {
        [HttpPost]
        public ActionResult Login()
        {
            var loginUser = dbContext.Usuarios.First(
                user => user.Mail == Request.Form["email"] && user.Password == Request.Form["password"]);

            if (loginUser != null)
            {
                miUsuario.Mail = loginUser.Mail;
                
                return RedirectToAction("Carreras", "Navigation");   
            }
            else
            {
                return RedirectToAction("Login", "Navigation");
            }
            
        }
        
        public ActionResult Logout()
        {
            miUsuario.Mail = null;
            
            return RedirectToAction("Login", "Navigation");
        }

    }
}
