using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTest : IDisposable
  {

    public void Dispose()
    {
      Item.ClearAll();
      //to empty our test database between each test
    }

    public ItemTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=to_do_list_test;";
    }

    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      //Arrange
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      Item newItem1 = new Item(description01);
      Item newItem2 = new Item(description02);
      List<Item> newList = new List<Item> { newItem1, newItem2 };

      //Act
      List<Item> result = Item.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
}
    // [TestMethod]
    // public void ItemConstructor_CreatesInstanceOfItem_Item() //NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    // {
    //   Item newItem = new Item("test");
    //   Assert.AreEqual(typeof(Item), newItem.GetType());
    // } //typeof returns the data type of a class. GetType() returns the data type of a specific object. So is the newItem object is of the Item data type?
    //
    // [TestMethod]
    // public void SetDescription_SetDescription_String()
    // {
    //   //Arrange
    //   string description = "Walk the dog.";
    //   Item newItem = new Item(description);
    //
    //   //Act
    //   string updatedDescription = "Do the dishes";
    //   newItem.SetDescription(updatedDescription);
    //   string result = newItem.GetDescription();
    //
    //   //Assert
    //   Assert.AreEqual(updatedDescription, result);
    // }

    [TestMethod]
      public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
      {
        //Arrange
        string description = "Walk the dog.";
        Item newItem = new Item(description);

        //Act
        int result = newItem.GetId();

        //Assert
        Assert.AreEqual(1, result);

        [TestMethod]
        public void Find_ReturnsCorrectItem_Item()
        {
          //Arrange
          string description01 = "Walk the dog";
          string description02 = "Wash the dishes";
          Item newItem1 = new Item(description01);
          Item newItem2 = new Item(description02);

          //Act
          Item result = Item.Find(2);

          //Assert
          Assert.AreEqual(newItem2, result);
        }
      }

  }
}
