using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebServer.Controllers;

public class FirstController : Controller
{

    public string Html()
    {
        int a = 10;
        int b = 20;
        return "<h1>Hello Html " + (a+b) + "</h1>";
    }
    

    public string Hello()
    {
        return "Hello";
    }
    
    public string Bye()
    {
        return "Bye";
    }
    
}