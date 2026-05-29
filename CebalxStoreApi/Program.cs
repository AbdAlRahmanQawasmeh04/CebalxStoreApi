using Microsoft.EntityFrameworkCore;
using CebalxStoreApi.Data;
var builder = WebApplication.CreateBuilder(args);
// تفعيل الكنترولر وواجهة Swagger
builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
// تشغيل الواجهة
app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();
app.MapControllers();
app.Run();