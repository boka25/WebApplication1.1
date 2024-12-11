using Microsoft.AspNetCore.Mvc;

namespace WebApplication44.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
