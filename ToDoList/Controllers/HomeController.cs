using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList.Controllers
{
  public class HomeController : Controller
  {
      [HttpGet("/")]
    public ActionResult Index()
    {
     Item item = new Item("description");
     Item item2 = new Item("descriptions");
     Item item3 = new Item("description3");
     List<Item> allItems = Item.GetAll();
      return View(allItems);
    }

     [HttpGet("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string description)
    {
       Item myItem = new Item(description);
      return RedirectToAction("Index");
    }
}
}
