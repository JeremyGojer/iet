using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TFLStore.Models;

namespace TFLStore.Controllers;

public class AccountController : Controller
{
    private readonly ILogger<AccountController> _logger;

    //parameterized constructor is always used for Dependency Injection
    //1.Constructor DI
    //2.Property DI
    //3.Method DI
    public AccountController(ILogger<AccountController> logger)
    {
        _logger = logger;
    }

    //Action Methods
    //Attribute: Metadata like annotation in Java
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }


    [HttpPost]
    public IActionResult Login(string email, string password)
    {
        if(email =="ravi.tambade@transflower.in" && password=="seed"){
            return RedirectToAction("Insert","Products");
        }
        return View();
    }

    public IActionResult Register( )
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(string firstname, string lastname, string email, string password, string contactnumber)
    {
        bool status=true;

        if(status){
            return RedirectToAction("Login","Account");
        }
        return View();
    }

  
}
