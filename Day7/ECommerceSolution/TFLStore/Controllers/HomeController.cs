using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TFLStore.Models;

namespace TFLStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    //parameterized constructor is always used for Dependency Injection
    //1.Constructor DI
    //2.Property DI
    //3.Method DI
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    //Action Methods
    //Attribute: Metadata like annotation in Java
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult AboutUs(){
        return View();
    }

    public IActionResult Contact(){
         return View();
    }

    public IActionResult Services(){
        List<string> trainingServices=new List<string>();
        trainingServices.Add("Workshops");
        trainingServices.Add("Bootcamps");
        trainingServices.Add("OnlineBatches");
        trainingServices.Add("Weekendworkshops");
        trainingServices.Add("Croporate Training");
        trainingServices.Add("Conducting Interviews");
        trainingServices.Add("Mentoring");
        return Json(trainingServices);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
