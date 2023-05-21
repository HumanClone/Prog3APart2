using FarmerTracker.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews()
                .AddSessionStateTempDataProvider();
builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(1000);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var config = new ConfigurationBuilder().
        SetBasePath(Directory.GetCurrentDirectory()).
        AddJsonFile("appsettings.json").
        Build();

builder.Services.AddDbContext<FarmerTrackerContext>(options =>
        options.UseSqlServer(config.GetConnectionString("FarmerDatabase")));

builder.Services.AddSession();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
    //pattern:"{controller=Employees}/{action=UserView}/{id?}");
    //pattern:"{controller=Farmers}/{action=Profile}/{id?}");
app.Run();
