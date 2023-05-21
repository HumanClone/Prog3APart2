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

    // using the userid of the session, the product list is filtered to only show the products of the user
    public IActionResult Profile()
    {
        //HttpContext.Session.SetInt32("UserId",2);
        List<Product> products=_context.Products.Select(product=>product).Where(product=>product.UserId==HttpContext.Session.GetInt32("UserId")).Include(product=>product.User).ToList<Product>();
        return View(products);
    }


    //basic return of the view
    public IActionResult Create()
    {
        return View();
    }

    // a post method to create a new product and save it to the database
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Pname,Ptype,Pdate")] Product @product)
    {
        @product.UserId=HttpContext.Session.GetInt32("UserId");
        if (ModelState.IsValid)
        {
            _context.Add(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Profile));
        }
        
        return RedirectToAction(nameof(Create));
    }
    
}