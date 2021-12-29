using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList.Controllers
{
  public class ClientsController : Controller
  {

    [HttpGet("/categories/{stylistId}/clients/new")]
    public ActionResult New(int stylistId)
    {
      Stylist stylist = Stylist.Find(stylistId);
      return View(stylist);
    }

    [HttpGet("/categories/{stylistId}/clients/{clientId}")]
    public ActionResult Show(int stylistId, int clientId)
    {
      Client client = Client.Find(clientId);
      Stylist stylist = Stylist.Find(stylistId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("client", client);
      model.Add("stylist", stylist);
      return View(model);
    }

    [HttpPost("/clients/delete")]
    public ActionResult DeleteAll()
    {
      Client.ClearAll();
      return View();
    }
  }
}