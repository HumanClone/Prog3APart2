using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FarmerTracker.Models;

namespace FarmerTracker.Controllers;

public class EmployeesController : Controller
{


     private readonly FarmerTrackerContext _context;

    public EmployeesController(FarmerTrackerContext context)
    {
        _context = context;
    }


    public IActionResult Index()
    {
        HttpContext.Session.SetString("Users", _context.Users.Count().ToString());
        int count = _context.Users.Count();
        return View(_context.Users.ToList());
        
    }

    public IActionResult Home()
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }

    public IActionResult UserView()
    {
      List<User> list = _context.Users.ToList();
        Console.WriteLine(list);
        return View(list);
    }
}
