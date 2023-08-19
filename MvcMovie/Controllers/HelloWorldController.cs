using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int id=1)
        {
            ViewData["Name"] = name;
            ViewData["NumTimes"] = id;
            return View();
        }
    }
}
