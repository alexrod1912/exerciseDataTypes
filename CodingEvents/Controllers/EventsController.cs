using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CodingEvents.Models;

namespace CodingEvents.Controllers;

public class EventsController : Controller{

static private List<string> Events = new List<string>
        {
            "Birthday",
            "Christmas",
            "Halloween"
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
public IActionResult NewEvent (string name)
{
   // Method code ...
   Events.Add(name);
   return Redirect("/Events");
}


}
