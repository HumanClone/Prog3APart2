using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FarmerTracker.Models;

namespace FarmerTracker.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        #warning neeed to remove on release
        HttpContext.Session.SetInt32("UserId",2);
        HttpContext.Session.SetString("FullName","Abby");
        //HttpContext.Session.SetString("Farmer","Yes");
        
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index", "Home");
    }

    public IActionResult Profile()
    {
        return RedirectToAction("Profile", "Farmers");
    }
    public IActionResult Home()
    {
        return RedirectToAction("Home", "Employees");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
