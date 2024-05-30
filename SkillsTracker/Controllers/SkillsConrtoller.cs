using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers;

public class SkillsController : Controller
{
    // 
    // GET: /HelloWorld/
    [HttpGet]
    [Route("/skills/")]
      public IActionResult Index() 
      {
        string html = "<h1>Skill Tracker </h1>" + 
        "<h2> Skills to learn</h2>" + "<ol><li>C#</li><li>Javascript</li><li>Java</li></ol>";
        

      return Content(html, "text/html");
      }
    [HttpGet]
    [HttpPost]
    // GET: /HelloWorld/Welcome/ 
    public IActionResult Form(string date, string cSharp, string javascript, string java)
    {
        if (HttpContext.Request.Method == "GET")
     {
                
         string html = "<form method='post' action='/skills/Form'>" +
         "<label for= 'day'> Date </label>" + 
         "<input type='date' id = 'day' name='date' />" + 

        "<label for= 'cSharp'> C# </label>" + 
         "<select name='cSharp'>" +
         "<option value='good'  >good</option>" + 
         "<option value='bad'  >bad</option>" + 
         "<option value='okay'  >okay</option>" +
         "</select>" +

        "<label for= 'javascript'> Javascript</label>" + 
        "<select name='javascript'>" +
         "<option value='good'  >good</option>" + 
         "<option value='bad'  >bad</option>" + 
         "<option value='okay'  >okay</option>" +
         "</select>" +

        "<label for= 'java'> Java </label>" + 
         "<select name='java'>" +
         "<option value='good'  >good</option>" + 
         "<option value='bad'  >bad</option>" + 
         "<option value='okay'  >okay</option>" +
         "</select>" +

         "<input type='submit' value='Submit form' />" +
         "</form>";

         return Content(html, "text/html");
     } else if (HttpContext.Request.Method == "POST"){
        string html1 = $"<h1>Form Submitted</h1>" +
                              $"<p>Date: {date}</p>" +
                              $"<p>C#: {cSharp}</p>" +
                              $"<p>Javascript: {javascript}</p>" +
                              $"<p>Java: {java}</p>";

                return Content(html1, "text/html");
     }
         string html2 = "<h1>Skill Tracker </h1>" ;
         return Content(html2,"text/html" );
    }
}