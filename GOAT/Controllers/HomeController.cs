using GOAT.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GOAT.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
