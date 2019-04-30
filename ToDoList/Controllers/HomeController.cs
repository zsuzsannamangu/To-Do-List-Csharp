using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        // return View();
        //we want the test to fail first, so we add return new EmptyResult(), so that is not what the return is expected to be - which is Index() method to return something that is of type ActionResult but is not of type ViewResult
        return new EmptyResult();
      }

    }
}
