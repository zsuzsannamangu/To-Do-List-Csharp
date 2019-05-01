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
      //this is where Items related to the parent Category will be stored:
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

    //GetItems() method on a Category correctly returns an empty List meant to hold Items.
    public List<Item> GetItems()
    {
      return _items;
    }

    //AddItem() will accept a Item object, and then use the built-in List Add() method to save that item into the _items property of a specific Category
    public void AddItem(Item item)
    {
      _items.Add(item);
    }
  }
}
