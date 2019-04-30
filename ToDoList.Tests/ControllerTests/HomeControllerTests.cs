using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.Controllers;
using ToDoList.Models;

namespace ToDoList.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
      // test that the Index() on our HomeController - ToDoList.HomeController.Index(), returns a view properly
      [TestMethod]
      public void Index_ReturnsCorrectView_True()
      {
        //Arrange
        //We instantiate an instance of HomeController
        HomeController controller = new HomeController();

        //Act
        //We generate a var: indexView, of type ActionResult to store the ActionResult returned from the Index() method. It just checks the name of the indexView
        ActionResult indexView = controller.Index();

        //Assert
        //We assert that the datatype of our indexView is a ViewResult
        //The ViewResult class inherits from the ActionResult class
        Assert.IsInstanceOfType(indexView, typeof(ViewResult));
      }
      // let's check to see if its model contains the right kind of data, in this case, contains a list of Items
      [TestMethod]
      public void Index_HasCorrectModelType_ItemList()
      {
        //Arrange
        HomeController controller = new HomeController();
        ViewResult indexView = controller.Index() as ViewResult;

        //Act
        // we now extract the model from it, it should contain our model's list
        var result = indexView.ViewData.Model;

        //Assert
        //We then assert that it is a list of Item objects.
        // Assert.IsInstanceOfType(result, typeof(List<Item>));
        ViewResult indexView = new HomeController().Index() as ViewResult;
      }
      //checking the datatype of the IActionResult returned from the action
      //we declare that it should be of type RedirectToActionResult since the Create method returns RedirectToAction.
      [TestMethod]
      public void Create_ReturnsCorrectActionType_RedirectToActionResult()
      {
        //Arrange
        ItemsController controller = new ItemsController();

        //Act
        IActionResult view = controller.Create("Walk the dog");

        //Assert
        Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
      }
      //checks the name of the action that we redirect to
      [TestMethod]
      public void Create_RedirectsToCorrectAction_Index()
      {
        //Arrange
        //First we create a new instance of the ItemsController, then we call the Create() method on it
        // then we cast the return value of that method call as the datatype RedirectToActionResult
        ItemsController controller = new ItemsController();
        RedirectToActionResult actionResult = controller.Create("Walk the dog") as RedirectToActionResult;

        //Act
        //Then, we access the ActionName property on the RedirectToActionResult result.
        string result = actionResult.ActionName;

        //Assert
        Assert.AreEqual(result, "Index");
      }
    }
}
