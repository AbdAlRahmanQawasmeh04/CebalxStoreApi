using Microsoft.AspNetCore.Mvc;
using CebalxStoreApi.Models;
using CebalxStoreApi.Data;
using System.Linq;

namespace CebalxStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // 1. GET: قراءة كل المنتجات
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }

        // 2. POST: إضافة منتج جديد
        [HttpPost]
        public IActionResult AddProduct(Product newProduct)
        {
            _context.Products.Add(newProduct);
            _context.SaveChanges();
            return Ok(newProduct);
        }

        // 3. PUT: تعديل منتج موجود بناءً على رقمه (ID)
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product updatedProduct)
        {
            // أول خطوة: بندور على المنتج بقاعدة البيانات
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound("المنتج غير موجود!"); // حماية في حال دخلنا رقم غلط
            }

            // ثاني خطوة: بنحدث البيانات
            product.Name = updatedProduct.Name;
            product.Price = updatedProduct.Price;

            _context.SaveChanges(); // بنحفظ التعديل بالقاعدة

            return Ok(product);
        }

        // 4. DELETE: حذف منتج بناءً على رقمه (ID)
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            // بندور على المنتج أولاً
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound("المنتج غير موجود أساساً!");
            }

            // بنحذفه وبنحفظ التغييرات
            _context.Products.Remove(product);
            _context.SaveChanges();

            return Ok("تم حذف المنتج بنجاح!");
        }
    }
}