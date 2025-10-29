using System.Diagnostics;
using Baumarkt.Models;
using Microsoft.AspNetCore.Mvc;

namespace Baumarkt.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
