using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
{
  //we must delete all categorys between tests
  [TestClass]
  public class CategoryTest : IDisposable
  {

    public void Dispose()
    {
      Category.ClearAll();
    }

  [TestClass]
  public class CategoryTest
  {
    //test to confirm our constructor can successfully create Category objects
    [TestMethod]
    public void CategoryConstructor_CreatesInstanceOfCategory_Category()
    {
      Category newCategory = new Category("test category");
      Assert.AreEqual(typeof(Category), newCategory.GetType());
    }

    //test that a Category can retrieve its name
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Category";
      Category newCategory = new Category(name);

      //Act
      string result = newCategory.GetName();

      //Assert
      Assert.AreEqual(name, result);
    }

    //test that we can retrieve Category IDs
    [TestMethod]
    public void GetId_ReturnsCategoryId_Int()
    {
      //Arrange
      string name = "Test Category";
      Category newCategory = new Category(name);

      //Act
      int result = newCategory.GetId();

      //Assert
      Assert.AreEqual(1, result);
    }

  }
}
