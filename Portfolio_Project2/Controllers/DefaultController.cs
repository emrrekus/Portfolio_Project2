using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Project2.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
