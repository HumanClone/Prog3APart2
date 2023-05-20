using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FarmerTracker.Models;
using System.Linq;
namespace FarmerTracker.Controllers;

using Microsoft.EntityFrameworkCore;

public class FarmersController : Controller
{


    private readonly FarmerTrackerContext _context;

    public FarmersController(FarmerTrackerContext context)
    {
        _context = context;
    }

    public IActionResult Profile()
    {
        HttpContext.Session.SetInt32("UserId",2);
        List<Product> products=_context.Products.Select(product=>product).Where(product=>product.UserId==HttpContext.Session.GetInt32("UserId")).Include(product=>product.User).ToList<Product>();
        return View(products);
    }

    public IActionResult Create()
    {
        return View();
    }
    
}