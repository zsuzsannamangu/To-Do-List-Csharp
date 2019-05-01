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
    //test to retrieve all Category objects to display in our app
    [TestMethod]
    public void GetAll_ReturnsAllCategoryObjects_CategoryList()
    {
      //Arrange
      string name01 = "Work";
      string name02 = "School";
      Category newCategory1 = new Category(name01);
      Category newCategory2 = new Category(name02);
      List<Category> newList = new List<Category> { newCategory1, newCategory2 };

      //Act
      List<Category> result = Category.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    // a Find() method to locate and display specific Category objects
    [TestMethod]
     public void Find_ReturnsCorrectCategory_Category()
     {
       //Arrange
       string name01 = "Work";
       string name02 = "School";
       Category newCategory1 = new Category(name01);
       Category newCategory2 = new Category(name02);

       //Act
       Category result = Category.Find(2);

       //Assert
       Assert.AreEqual(newCategory2, result);
     }

     //we assert that calling a GetItems() method on a Category correctly returns an empty List meant to hold Items
     [TestMethod]
     public void GetItems_ReturnsEmptyItemList_ItemList()
     {
       //Arrange
       string name = "Work";
       Category newCategory = new Category(name);
       List<Item> newList = new List<Item> { };

       //Act
       List<Item> result = newCategory.GetItems();

       //Assert
       CollectionAssert.AreEqual(newList, result);
     }

      //test that we can add an Item object into the _items property of a Category object
     [TestMethod]
     public void AddItem_AssociatesItemWithCategory_ItemList()
     {
       //Arrange
       string description = "Walk the dog.";
       //create new Item
       Item newItem = new Item(description);
       //add created new Item to a List
       List<Item> newList = new List<Item> { newItem };
       string name = "Work";
       //create new Category
       Category newCategory = new Category(name);
       //call AddItem() on new Category and pass in our sample Item(newItem)
       newCategory.AddItem(newItem);

       //Act
       //call GetItems to retrieve Items saved in Category
       List<Item> result = newCategory.GetItems();

       //Assert
       //assert that newCategory.GetItems() returns a List containing our Item
       CollectionAssert.AreEqual(newList, result);

  }
}
