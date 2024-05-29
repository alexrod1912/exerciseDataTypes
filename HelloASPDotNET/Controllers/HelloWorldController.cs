using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNET.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    [HttpGet]
    [Route("/HelloWorld/")]
      public IActionResult Index() 
      {
         string html = "<form method='post' action='/HelloWorld/Welcome'>" +
         "<input type='text' name='name' />" +
         "<input type='submit' value='Greet Me!' />" +
         "</form>";

      return Content(html, "text/html");
      }
    // 
    // GET: /HelloWorld/Welcome/ 
    public IActionResult Welcome(string name)
    {
        return Content ("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
    }
}