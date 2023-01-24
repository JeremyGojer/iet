using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TFLStore.Models;
using BOL;
using SAL;
namespace TFLStore.Controllers;

public class ShoppingCartController : Controller
{
    private readonly ILogger<ShoppingCartController> _logger;


    public ShoppingCartController(ILogger<ShoppingCartController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        string data=TempData["mychoice"].ToString();
        ViewData["mychoice"]=data;
        return View();
    }

    public IActionResult AddToCart(int id)
    {
         
        return View();
    }

    public IActionResult RemoveFromCart(){
        return View();
    }

    public IActionResult Delete(){
         return View();
    }

 
}
