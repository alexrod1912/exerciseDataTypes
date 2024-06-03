using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNET.Controllers;

public class HelloController : Controller
{
    // 
    // GET: /HelloWorld/
    [HttpGet]
    [Route("/hello/")]
      public IActionResult Index() 
      {
        //  string html = "<form method='post' action='/hello/Welcome'>" +
        //  "<input type='text' name='name' />" + 
        //  "<select name='language'>" +
        //  "<option value='English'  >English</option>" + 
        //  "<option value='Spanish'  >Spanish</option>" + 
        //  "<option value='French'  >French</option>" +
        //  "</select>" +
        //  "<input type='submit' value='Greet Me!' />" +
        //  "</form>";

      return View();
      }
    // 
    // GET: /HelloWorld/Welcome/ 
    [HttpPost]
    public IActionResult Welcome(string name, string language )
    {
    //     if (language == "English"){
    //         return Content ("<h1>Welcome, " + name + "!</h1>", "text/html");

    //     }else if( language == "Spanish"){
    //         return Content ("<h1>Hola, " + name + "!</h1>", "text/html");
    //     }else 
    //         return Content ("<h1>Bonjour, " + name + "!</h1>", "text/html");

    // }

    ViewBag.person = name;
  return View();
    }
}