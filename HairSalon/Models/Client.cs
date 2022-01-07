namespace HairSalon.Models
{
  public class Client
  {
    public string ClientName { get; set; }
    public string ClientDescription { get; set; }
    public int ClientId { get; set; }
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}
// namespace HairSalon.Models
// {
//   public class Client
//   {
//     public string ClientName { get; set; }
//     public string ClientDescription { get; set; }
//     public int Id { get; }

//     public Client(string clientName, string clientDescription, int id)
//     {
//       ClientName = clientName;
//       ClientDescription = clientDescription;
//       Id = id;
//     }

//     public static List<Client> GetAll()
//     {

//     }

//     public static void ClearAll()
//     {
//       MySqlConnection conn = DB.Connection();
//       conn.Open();
//       var cmd = conn.CreateCommand() as MySqlCommand;
//       cmd.CommandText = @"DELETE FROM clients;";
//       cmd.ExecuteNonQuery();
//       conn.Close();
//       if (conn != null)
//       {
//         conn.Dispose();
//       }
//     }
    
//     public static Client Find(int searchId)
//     {
//       Client placeholderClient = new Client("placeholder client");
//       return placeholderClient;
//     }

//     public override bool Equals(System.Object otherClient)
//     {
//       if (!(otherClient is Client))
//       {
//         return false;
//       }
//       else
//       {
//         Client newClient = (Client) otherClient;
//         bool descriptionEquality = (this.Description == newClient.Description);
//         return descriptionEquality;
//       }
//     }

//     public void Save()
//     {

//     }
//   }
// }
