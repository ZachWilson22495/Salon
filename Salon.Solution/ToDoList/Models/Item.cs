using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Client
  {
    public string Description { get; set; }
    public int Id { get; }
    private static List<Client> _instances = new List<Client> { };

    public Client(string description)
    {
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Client> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Client Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
