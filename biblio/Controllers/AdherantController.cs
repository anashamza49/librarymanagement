using Microsoft.AspNetCore.Mvc;

namespace biblio.Controllers
{
    public class AdherantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
