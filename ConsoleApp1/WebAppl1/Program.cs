using ConsoleApp1;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting.WindowsServices;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using WebAppl1.Models;


var options = new WebApplicationOptions { Args = args, ContentRootPath = WindowsServiceHelpers.IsWindowsService() ? AppContext.BaseDirectory : default };
var builder = WebApplication.CreateBuilder(options);

//as service
builder.Host.UseWindowsService();

string connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));

builder.Services.AddControllersWithViews();
//Log
//builder.Host.ConfigureLogging(logging =>
//{
//    logging.ClearProviders();
//    logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
//})
//.UseNLog();
/*
builder.Logging.ClearProviders();
builder.Host.UseNLog();
*/

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();



var appName = Assembly.GetEntryAssembly().GetName().Name;


//DI
builder.Services.AddScoped<ICalculator, Calculator>();
builder.Services.AddScoped<IConverter, Converter>();


builder.Services.AddSwaggerGen();

var app = builder.Build();


//var logger = ConfigureNLog(appName);

app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    //options.RoutePrefix = string.Empty;
});
app.MapControllers();



app.UseDefaultFiles();

app.UseStaticFiles(new StaticFileOptions()
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot"))
});

//logger.Info($"{appName} is starting at {DateTime.UtcNow:O}");

app.Run();



/// </summary>
public partial class Program { }