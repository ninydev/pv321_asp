using System.Runtime.InteropServices.JavaScript;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebServer.Controllers;

public class BuildController : Controller
{

    public IActionResult First()
    {
        string welcomeMessage = "Hello Vasil";
        // Send to View - for build html
        ViewData["welcomeMessage"] = welcomeMessage;
        ViewBag.welcomeMessage = welcomeMessage;

        ViewData["imgUrl"] = "https://vita325.com/wp-content/uploads/2024/05/service-1.jpg";

        ViewData["someVar"] = "Цього не буде на сторинці";
        

        ViewData["currentDate"] = DateTime.Now; 
        
        return View();
    }
    
}