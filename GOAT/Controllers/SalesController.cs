using Microsoft.AspNetCore.Mvc;

namespace GOAT.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Display()
        {
            return View();
        }
    }
}
