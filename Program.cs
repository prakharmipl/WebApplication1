using Microsoft.EntityFrameworkCore;
using WebApplication1.DBContext;
using WebApplication1.Repository;

AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
{
    Console.WriteLine("UNHANDLED: " + e.ExceptionObject);
};

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("ApplicationConnection")));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFontend", policy =>
    {
        policy.WithOrigins("https://localhost:7091", "http://localhost:8080").AllowAnyHeader().AllowAnyMethod();
    });



    });



builder.Services.AddControllers();
RegisterServices.AddApplicationServices(builder.Services);

//builder.Services.AddScoped<IProductRepository, ProductRepository>();

var app = builder.Build();
app.UseCors("AllowFontend");

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
