using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tourdalCommerce.Data;
using tourdalCommerce.Models;

namespace tourdalCommerce.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _context=context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpGet]
    public IActionResult UserRegistration(){
        return View();
    }
    [HttpPost]
    public IActionResult UserRegistration(UserModel user)
    {
        try {
            if (user != null)
            {
                if (ModelState.IsValid)
                {
                    var newuser = new UserModel
                    {
                        UserName = user.UserName,
                        UserMail = user.UserMail,
                        Password = user.Password,
                        Phone = user.Phone
                    };
                    _context.Registered_User.Add(newuser);
                    _context.SaveChanges();
                    return RedirectToAction("UserDetail");
                }
                else
                {
                    ViewData["Message"] = "The Model is not valid try new entry";
                    return View();
                }
            }

        }
        catch (Exception ex)
        {
            ViewData["Message"]=ex.Message;
            return RedirectToAction("Error");
        }
           
        return RedirectToAction("UserDetail");
    }

    public IActionResult UserDetail(){
      var users =  _context.Registered_User.ToList();
        return View(users);
    }
}
