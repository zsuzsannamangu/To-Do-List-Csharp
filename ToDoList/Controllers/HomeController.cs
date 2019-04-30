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
      //It will retrieve a list of all existing Items, passing in the entire list as the view's model
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }

    [Route("/items/new")]
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
