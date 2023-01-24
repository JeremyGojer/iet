﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TFLStore.Models;
using BOL;
using SAL;
namespace TFLStore.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    //parameterized constructor is always used for Dependency Injection
    //1.Constructor DI
    //2.Property DI
    //3.Method DI
    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        ProductService svc=new ProductService();
        List<Product> products=svc.GetAll();
        this.ViewData["products"]=products;
        return View();
    }

    public IActionResult Details(int id)
    {
        ProductService svc=new ProductService();
        List<Product> products=svc.GetAll();
        Product foundProduct=null;
        foreach( Product p in products){  
            if(p.ProductId==id)
            {
                foundProduct=p;
               // ViewData["product"]=foundProduct;
                ViewBag.product=foundProduct;
                
            }
        }
        return View();
    }

    public IActionResult Insert(){
        return View();
    }

    public IActionResult Delete(){
         return View();
    }

    public IActionResult Update(){
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
