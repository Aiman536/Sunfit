using Microsoft.AspNetCore.Mvc;

namespace Sunfit.Controllers
{
    public class content : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
