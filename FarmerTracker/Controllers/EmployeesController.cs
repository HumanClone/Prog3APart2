using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FarmerTracker.Models;
using System.Linq;
namespace FarmerTracker.Controllers;

using Microsoft.EntityFrameworkCore;

#warning need to do popovers and set up log in 
public class EmployeesController : Controller
{


    private readonly FarmerTrackerContext _context;

    public EmployeesController(FarmerTrackerContext context)
    {
        _context = context;
    }


   public IActionResult Index(string searchString)
    {   
        HttpContext.Session.SetInt32("UserId",2);
        HttpContext.Session.SetString("FullName","Abby");

        List<Product> products=_context.Products.Select(product=>product).Include(product=>product.User).ToList<Product>();

        if(!string.IsNullOrEmpty(searchString))
        {   
            
            products=products.Where(product=>product.User.FullName.Equals(searchString)||product.UserId.ToString().Equals(searchString)).ToList<Product>();
        }
        
        return View(products);
        
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
        List<User> users= _context.Users.Select(user=>user).ToList<User>();
        return View(users);
    }
}
