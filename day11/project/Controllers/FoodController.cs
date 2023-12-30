using System.Diagnostics;
using BLL;
using Microsoft.AspNetCore.Mvc;
using project.Models;
using BAL;
using MAL.connected;

namespace project.Controllers;

public class FoodController : Controller
{
    private readonly ILogger<FoodController> _logger;

    public FoodController(ILogger<FoodController> logger)
    {
        _logger = logger;
    }
    [HttpGet]
    public IActionResult Insert()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Insert(int id, string name,string unit,int cid)
    {
        service s = new service();
        s.Insert(id,name,unit,cid);
        return View();
    }

    public IActionResult ShowData()
    {
        service s = new service();
        List<Food> lst = s.ShowData();
        ViewData["data"] = lst;
        return View();
    }
    [HttpGet]
    public IActionResult Update(int id)
    {
        DBManager db = new DBManager();
        List<Food> lst = db.GetAllData();
        var f = lst.Find((food)=>food.id == id);
        return View(f);
    }
    [HttpPost]
    public IActionResult Update(int id, string name,string unit,int cid)
    {
        Console.WriteLine(id);
        DBManager db = new DBManager();
        bool status = db.Update(id,name,unit,cid);
    //    Food f = new Food(id,name,unit,cid);
       if(status)
       {
        return RedirectToAction("ShowData");
       }else{
        return View();
       }
    }
    [HttpGet]
    public IActionResult DeleteById(int id, string name)
    {
        DBManager db = new DBManager();
        List<Food> lst = db.GetAllData();
        var e = lst.Find((Food)=>Food.id==id);
        return View(e);
    }
    [HttpPost]
    public IActionResult DeleteById(int id)
    {
        DBManager db = new DBManager();
        bool status = db.DeleteById(id);
        Console.WriteLine(status);
        if(status)
        {
        return RedirectToAction("ShowData");
        }else{
        return RedirectToAction("Error1");
        }
    }
    public IActionResult Error1()
    {
        
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}