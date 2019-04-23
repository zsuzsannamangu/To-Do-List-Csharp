using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    private string _description;
    private static List<Item> _instances = new List<Item> {};

    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

  }
}
