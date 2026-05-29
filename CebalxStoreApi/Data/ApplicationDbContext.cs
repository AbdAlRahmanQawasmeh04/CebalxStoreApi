using Microsoft.EntityFrameworkCore;
using CebalxStoreApi.Models;

namespace CebalxStoreApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // هذا السطر بحول كلاس Product لجدول حقيقي بقاعدة البيانات
        public DbSet<Product> Products { get; set; }
    }
}