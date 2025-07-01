using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PizzaKing.Models;

namespace PizzaKing.Controllers;


public class TestController : Controller
{
    public TestController(ILogger<TestController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(string name)
    {
        _logger.LogInformation("TestController.Index called with name: {Name}", name);
        return View();
    }
}