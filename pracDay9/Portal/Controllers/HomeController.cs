using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
// using Portal.Models;
using DAL.connected;
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
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Insert(int id,string name,string unit,int cid)
    {
        DBManager DB = new DBManager();
        DB.InsertData(id,name,unit,cid);
        if(ModelState!=null){
        return View();
        }
        else return View();
    }
    [HttpGet]
    public IActionResult Insert()
    {
        return View();
    }
     [HttpPost]
    public IActionResult Display()
    {
        return View();
    }
    // [HttpGet]
    // public IActionResult Display()
    // {
    //     return View();
    // }
     [HttpPost]
    public IActionResult DisplayById()
    {
        return View();
    }
    // [HttpGet]
    // public IActionResult DisplayById()
    // {
    //     return View();
    // }
      [HttpPost]
    public IActionResult DeleteById()
    {
        return View();
    }
    // [HttpGet]
    // public IActionResult DeleteById()
    // {
    //     return View();
    // }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new Models.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
