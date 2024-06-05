using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CodingEvents.Models;
using CodingEvents.Data;

namespace CodingEvents.Controllers;

public class EventsController : Controller{

// static private Dictionary<string, string> Events = new Dictionary<string, string>
//         {
//             {"Birthday", "In October"},
//             {"Christmas", "In December"},
//             {"Halloween", "At the end of october"}
//         };

 static private List<Event> Events = new List<Event>();
    
[HttpGet]
public IActionResult Index()
{
//    List<string> Events = new List<string>();
      //Add some events to the List
    

    ViewBag.events = EventData.GetAll();
    return View();

}

[HttpGet]
public IActionResult Add()
{
  // Any additional method code here

  return View();
}

[HttpPost]
public IActionResult NewEvent (Event newEvent)
{
   // Method code ...
   EventData.Add(newEvent);
   return Redirect("/Events");
}

   public IActionResult Delete()
   {
      ViewBag.events = EventData.GetAll();

      return View();
   }

      [HttpPost]
   public IActionResult Delete(int[] eventIds)
   {
      foreach (int eventId in eventIds)
      {
            EventData.Remove(eventId);
      }

      return Redirect("/Events");
   }
}
