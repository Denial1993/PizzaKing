using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PizzaKing.Models;



namespace PizzaKing.Controllers;


public class TestController : Controller
{
    public string Try()
    {
        // This is a placeholder for the Index action method.
        // You can return a view or any other result as needed.
        return "Hello, this is the TestController's Try method!";
    }
    // private readonly ILogger<TestController> _logger;

    // public TestController(ILogger<TestController> logger)
    // {
    //     _logger = logger;
    // }

    // [HttpGet]
    // public IActionResult Index()
    // {
    //     return View();
    // }

    // [HttpPost]
    // public IActionResult Index(string name)
    // {
    //     _logger.LogInformation("TestController.Index called with name: {Name}", name);
    //     return View();
    // }
}