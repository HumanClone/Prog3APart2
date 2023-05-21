using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FarmerTracker.Models;
using System.Linq;
namespace FarmerTracker.Controllers;

using Microsoft.EntityFrameworkCore;


public class EmployeesController : Controller
{


    private readonly FarmerTrackerContext _context;

    public EmployeesController(FarmerTrackerContext context)
    {
        _context = context;
    }

    //using all Possible inputs that may be give to then filter the products and return a list
   public IActionResult Index(string searchString,string? Ptype, DateTime? startdate,DateTime? enddate)
    {   
       
        List<Product> products=_context.Products.Select(product=>product).Include(product=>product.User).ToList<Product>();

        if(!string.IsNullOrEmpty(searchString))
        {   
            
            products=products.Where(product=>product.User.FullName.Equals(searchString)||product.UserId.ToString()==searchString).ToList<Product>();
        }
        if(!string.IsNullOrEmpty(Ptype))
        {
            products=products.Where(product=>product.Ptype.Equals(Ptype)).ToList<Product>();
        }
        if(startdate!=null && enddate!=null)
        {
            products=products.Where(product=>product.Pdate>= startdate && product.Pdate<=enddate).ToList<Product>();
        }
       
        return View(products);
        
    }

    //basic return of the view
    public IActionResult Home()
    {
        return View();
    }

    //basic return of the view
    public IActionResult Create()
    {
        return View();
    }


        /// How to Secure Passwords with BCrypt.NET
        /// [
        ///  var passwordHash = BCrypt.HashPassword("Password123!");
        /// ]
        /// https://code-maze.com/dotnet-secure-passwords-bcrypt/
        /// Acccessed[20 May 2023]


    // a post method to create a new user and save it to the database
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("FullName,Email,PhoneNumber,UserPassword,Farmer")] User @user)
    {
        @user.UserPassword=BCrypt.Net.BCrypt.HashPassword(@user.UserPassword);
        if (ModelState.IsValid)
        {
            _context.Add(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(UserView));
        }
        
        return RedirectToAction(nameof(Create));
    }

    // a method to return a list of all the users in the database
    public IActionResult UserView()
    {
        List<User> users= _context.Users.Select(user=>user).ToList<User>();
        return View(users);
    }
}
