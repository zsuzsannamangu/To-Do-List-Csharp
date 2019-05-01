using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Category
  {
    private static List<Category> _instances = new List<Category> {};
    private string _name;
    private int _id;
    private List<Item> _items;

    public Category(string categoryName)
    {
      _name = categoryName;
      _instances.Add(this);
      _id = _instances.Count;
      _items = new List<Item>{};
    }
    //retrieve Category name
    public string GetName()
    {
      return _name;
    }
    //retrieve Category IDs
    public int GetId()
    {
      return _id;
    }
    //we must delete all Categorys between tests.
    public static void ClearAll()
    {
      _instances.Clear();
    }

    //functionality to retrieve all Category objects to display in our app
    public static List<Category> GetAll()
    {
      return _instances;
    }

    //Find() method to locate and display specific Category objects
    public static Category Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
