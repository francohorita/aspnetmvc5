using Microsoft.AspNetCore.Mvc;

namespace aspnetmvc5.Controllers
{
    public class TestController : DefaultController
    {
        private void SetViewDatas()
        {
            ViewData["AppName"] = "FNF";
        }

        public IActionResult Prueba()
        {
            SetViewDatas();

            return View();
        }

    }
}