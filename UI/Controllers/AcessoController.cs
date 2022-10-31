using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class AcessoController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
