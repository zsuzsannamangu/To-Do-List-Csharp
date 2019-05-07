using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ToDoList.Models
{
  public class Item
  {
    private string _description;
    // private int _id;

    public Item (string description)
    {
      _description = description;
      // _id = _instances.Count;
    }

    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    // public int GetId()
    // {
    //   return _id;
    // }

    public static List<Item> GetAll()
    {
      List<Item> allItems = new List<Item> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM items;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while(rdr.Read())
      {
        int itemId = rdr.GetInt32(0);
        string itemDescription = rdr.GetString(1);
        Item newItem = new Item(itemDescription, itemId);
        allItems.Add(newItem);
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return allItems;
    }
    //delete objects:
    public static void ClearAll()
    {
     //call DB.Connection() to create our conn object
     MySqlConnection conn = DB.Connection();
     conn.Open();
     var cmd = conn.CreateCommand() as MySqlCommand;
     cmd.CommandText = @"DELETE FROM items;";
     cmd.ExecuteNonQuery();
     //SQL statements that modify data (like deleting it!) instead of querying and returning data are executed with the ExecuteNonQuery() method
     //whereas executing commands that retrieve data use different methods, like the ExecuteReader() one we used in GetAll().
    }

    conn.Close();
    if (conn != null)
    {
    conn.Dispose();
    }

    // public static Item Find(int searchId)
    // {
    //   return _instances[searchId-1];
    // }

  }
}
