using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tourdalCommerce.Models;

namespace tourdalCommerce.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
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

    public IActionResult UserRegistration(UserModel user){
       if(ModelState.IsValid){
        var newuser=new UserModel{
                UserName= user.UserName,
                UserMail= user.UserMail,
                Password= user.Password,
                Phone= user.Phone
                   };
       } 
                //    _context.user.add();
        return View();
    }
}
