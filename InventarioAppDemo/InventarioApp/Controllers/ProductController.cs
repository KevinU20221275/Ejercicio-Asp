using InventarioApp.Data;
using InventarioApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventarioApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ProductData productData = new ProductData();
            return View(productData.GetAllProducts());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProductModel productModel)
        {
            try
            {
                ProductData productData = new ProductData();
                productData.Add(productModel);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;

                return View(productModel);
            }
        }
    }
}
