using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTest
  {
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item() //NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    {
      Item newItem = new Item();
      Assert.AreEqual(typeof(Item), newItem.GetType());
    } //typeof returns the data type of a class. GetType() returns the data type of a specific object. So is the newItem object is of the Item data type?

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Walk the dog.";
      Item newItem = new Item(description);
      string result = newItem.GetDescription();
      Assert.AreEqual(description, result);
    }

  }
}
