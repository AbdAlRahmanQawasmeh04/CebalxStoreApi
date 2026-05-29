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

        // هذا البناء (Constructor) عشان نستدعي قاعدة البيانات
        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // 1. GET: قراءة كل المنتجات من قاعدة البيانات الحقيقية
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }

        // 2. POST: إضافة منتج جديد وحفظه في قاعدة البيانات
        [HttpPost]
        public IActionResult AddProduct(Product newProduct)
        {
            _context.Products.Add(newProduct);
            _context.SaveChanges(); // هذا السطر اللي بثبت الداتا بالقاعدة
            return Ok(newProduct);
        }
    }
} 