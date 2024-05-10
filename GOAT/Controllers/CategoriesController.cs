using BLL.Managers;
using DTOs.Objects;
using Microsoft.AspNetCore.Mvc;

namespace GOAT.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Display()
        {
            List<Category> categories =CategoryManager.GetAll();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Add(Category category)
        {
            CategoryManager.Add(category);
            return NoContent();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var delete = CategoryManager.GetByID(id);
            if (delete == null)
            {
                return NotFound();
            }
            return View(delete);
        }
        [HttpPost]
        public IActionResult Delete(Category category)
        {
            CategoryManager.Delete(category.Id);
            return RedirectToAction("Display");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var category = CategoryManager.GetByID(id);
            if (category == null)
            {
                return NotFound(); 
            }

            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            CategoryManager.Edit(category);
            return RedirectToAction("Display");
        }
    }
}
