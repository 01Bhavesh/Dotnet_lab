using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;
using BOL;
using BLL;
namespace Portal.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Service srve = new Service();
     List<Food> lst = srve.GetAllData();
    ViewData["food"] = lst;
        return View();
    }
    [HttpPost]
    public IActionResult Insert(string msg)
    {
        if(msg == "yes")
        {
        Service serv = new Service();
        serv.InsertData();
        return View();
        }
        return View();
    }
    [HttpGet]
    public IActionResult Insert()
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
}
