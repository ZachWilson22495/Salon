using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Client
  {
    public string ClientName { get; set; }
    public string ClientDescription { get; set; }
    public int Id { get; }
    private static List<Client> _instances = new List<Client> { };

    public Client(string clientName, string clientDescription)
    {
      ClientName = clientName;
      ClientDescription = clientDescription;
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
