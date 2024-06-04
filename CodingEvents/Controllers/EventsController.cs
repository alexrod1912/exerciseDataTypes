using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CodingEvents.Models;

namespace CodingEvents.Controllers;

public class EventsController : Controller{

static private Dictionary<string, string> Events = new Dictionary<string, string>
        {
            {"Birthday", "In October"},
            {"Christmas", "In December"},
            {"Halloween", "At the end of october"}
        };
    
[HttpGet]
public IActionResult Index()
{
//    List<string> Events = new List<string>();
      //Add some events to the List
    

    ViewBag.events = Events;
    return View();

}

[HttpGet]
public IActionResult Add()
{
  // Any additional method code here

  return View();
}

[HttpPost]
public IActionResult NewEvent (string name, string description)
{
   // Method code ...
   Events.Add(name, description);
   return Redirect("/Events");
}


}
