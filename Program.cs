using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using mymvcapp.Data;
using mymvcapp.Models;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//builder.Services.AddDbContext<ApplicationDbContext>(
  //  options =>
    //{
      //  options.UseSqlServer(builder.Configuration.GetConnectionString("MyMvcAppDB"));
   // });





builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationUser>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Myconnection")));





//builder.Services.AddDbContext<ApplicationDbContext>(options => 
//options.UseSqlServer(builder.Configuration.GetConnectionString("MyMvcAppDB")));


// Configure MongoDB settings
builder.Services.Configure<MongoDbSettings>(
    builder.Configuration.GetSection("MongoDB"));
builder.Services.AddSingleton<MongoDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
