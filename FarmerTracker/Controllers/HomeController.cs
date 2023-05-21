using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FarmerTracker.Models;

namespace FarmerTracker.Controllers;

public class HomeController : Controller
{
    private readonly FarmerTrackerContext _context;

    public HomeController(FarmerTrackerContext context)
    {
        _context = context;
    }
  

    public IActionResult Index()
    {
       
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

    [HttpPost]
        public async Task<IActionResult> Login(IFormCollection form)
        {
            User user = new User();
            user.FullName = form["FullName"];
            user.UserPassword = form["UserPassword"];

            var result = _context.Users.Where(u => u.FullName==user.FullName).FirstOrDefault();
            if (result != null)
            {
                if (BCrypt.Net.BCrypt.Verify(user.UserPassword, result.UserPassword))
                {
                    HttpContext.Session.SetInt32("UserId", result.UserId);
                    HttpContext.Session.SetString("FullName", result.FullName);
                    HttpContext.Session.SetString("Farmer", result.Farmer);
                    if (result.Farmer == "Yes")
                    {
                        return RedirectToAction("Profile", "Farmers");
                    }
                    else
                    {
                        return RedirectToAction("Home", "Employees");
                    }
                }
                else
                {
                    ViewBag.Notification = "Password or Username Incorrect";
                    return View();
                }
            }
            else
            {
                ViewBag.Notification = "Password or Username Incorrect";
                return View();
            }
           
            
        
            

        }

    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index", "Home");
    }

    // public IActionResult Profile()
    // {
    //     return RedirectToAction("Profile", "Farmers");
    // }
    // public IActionResult Home()
    // {
    //     return RedirectToAction("Home", "Employees");
    // }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
