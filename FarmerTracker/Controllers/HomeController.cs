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

  /// How to Secure Passwords with BCrypt.NET
        /// [
        ///  var result = BCrypt.Verify("Password123!", passwordHash);;
        /// ]
        /// https://code-maze.com/dotnet-secure-passwords-bcrypt/
        /// Acccessed[20 May 2023]

    /* this is a post method that searches the data for the full name and if it exists it will check the password by hasing it and comparing it to the hashed password in the database from there it sets some values to the session and redirects to the profile page
    */

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


    /* this is a method that clears the session and redirects to the home page
    */
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index", "Home");
    }

    /* this is a method that returns the view
    */
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
