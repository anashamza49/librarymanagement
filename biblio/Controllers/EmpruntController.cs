using Microsoft.AspNetCore.Mvc;

namespace biblio.Controllers
{
    public class EmpruntController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
