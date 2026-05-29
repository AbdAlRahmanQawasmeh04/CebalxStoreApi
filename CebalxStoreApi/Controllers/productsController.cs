using Microsoft.AspNetCore.Mvc;
using CebalxStoreApi.Models;
using System.Collections.Generic;

namespace CebalxStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "High-Performance Laptop", Price = 1200 },
            new Product { Id = 2, Name = "Wireless Mouse", Price = 45 }
        };

        // 1. طلب GET: لقراءة كل المنتجات
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(_products);
        }

        // 2. طلب POST: لإضافة منتج جديد
        [HttpPost]
        public IActionResult AddProduct(Product newProduct)
        {
            _products.Add(newProduct);
            return Created("", newProduct);
        }

        // 3. طلب PUT: لتعديل منتج موجود
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product updatedProduct)
        {
            var product = _products.Find(p => p.Id == id);
            if (product == null)
                return NotFound("المنتج غير موجود!");

            product.Name = updatedProduct.Name;
            product.Price = updatedProduct.Price;
            return Ok(product);
        }

        // 4. طلب DELETE: لحذف منتج
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = _products.Find(p => p.Id == id);
            if (product == null)
                return NotFound("المنتج غير موجود!");

            _products.Remove(product);
            return Ok("تم حذف المنتج بنجاح");
        }
    }
}