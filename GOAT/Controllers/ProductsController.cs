using Microsoft.AspNetCore.Mvc;
using DTOs.Objects;
using BLL.Managers;
using GOAT.Data;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
namespace GOAT.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IWebHostEnvironment _hosting;
        public ProductsController(IWebHostEnvironment hosting) { 
            _hosting = hosting;
        }
        public IActionResult Display()
        {
            List<Product> products = ProductManager.GetAllWihInclude();
            return View(products);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ImageFileVM imageFileVM = new();
            ViewData["Categories"] = CategoryManager.GetAll();
            return View(imageFileVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Product product ,ImageFileVM imageFileVM)
        {
            string fileName = "";
            if (imageFileVM.Image != null && imageFileVM.Image.Length > 0)
            {
                var uploadsFolder = Path.Combine(_hosting.WebRootPath,"Data", "Products");
                var filePath = Path.Combine(uploadsFolder, imageFileVM.Image.FileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                     imageFileVM.Image.CopyTo(stream);
                }
                fileName = imageFileVM.Image.FileName;
            }

            product.ImagePath = fileName;
            product.IsExist = true;
            ProductManager.Add(product);
            return NoContent();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            ProductManager.Delete(id);
            return RedirectToAction("Display");    
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            ProductManager.Update(product);
            return NoContent();
        }


        public IActionResult Search(int id)
        {
            Product product = ProductManager.GetByID(id);
            string jsonData = JsonSerializer.Serialize(product);
            return Content(jsonData, "application/json");
        }

        [HttpPost]
        public IActionResult Product(int id)
        {
            Product product = ProductManager.GetByIdWithInclude(id);
            return View();
        }


    }
}
