using Microsoft.AspNetCore.Mvc;

namespace TyrellCorp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
