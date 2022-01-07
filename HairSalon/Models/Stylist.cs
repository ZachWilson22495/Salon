using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }
    public int StylistId { get; set; }
    public string StylistName { get; set; }
    public string StylistDescription { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}

// {
  //   private static List<Stylist> _instances = new List<Stylist> {};
  //   public string StylistName { get; set; }
  //   public string StylistDescription { get; set; }
  //   public int Id { get; }
  //   public List<Client> Clients { get; set; }

  //   public Stylist(string stylistName, string stylistDescription)
  //   {
  //     StylistName = stylistName;
  //     StylistDescription = stylistDescription;
  //     _instances.Add(this);
  //     Id = _instances.Count;
  //     Clients = new List<Client>{};
  //   }

  //   public static void ClearAll()
  //   {
  //     _instances.Clear();
  //   }

  //   public static List<Stylist> GetAll()
  //   {
  //     return _instances;
  //   }

  //   public static Stylist Find(int searchId)
  //   {
  //     return _instances[searchId-1];
  //   }

  //   public void AddClient(Client client)
  //   {
  //     Clients.Add(client);
  //   }

  // }
