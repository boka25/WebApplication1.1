using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;
using WebApplication44.Models;

namespace WebApplication44.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            /*  Response.ContentType = "text/html";
              StringBuilder stringBuilder = new StringBuilder();

              foreach(var header in Request.Headers)
              {
                  //Console.WriteLine($"{header.Key}:{header.Value}");
                  stringBuilder.Append($"{header.Key}:{header.Value}");
              }

              await Response.WriteAsync (stringBuilder.ToString());*/
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
