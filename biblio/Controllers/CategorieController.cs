using Microsoft.AspNetCore.Mvc;

namespace biblio.Controllers
{
    public class CategorieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
