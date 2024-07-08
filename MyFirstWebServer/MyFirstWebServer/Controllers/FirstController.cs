using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace MyFirstWebServer.Controllers;

public class FirstController : Controller
{

    public string Html()
    {
        int a = 10;
        int b = 20;

        StringBuilder sb = new StringBuilder();

        sb.Append("<html>\n");
        sb.Append("<head>\n");
        sb.Append("<title>");
        sb.Append("My Site");
        sb.Append("</title>\n");
        sb.Append("</head>\n");
        
        sb.Append("<body>\n");
        sb.Append("<h1>Hello Html " + (a + b) + "</h1>\n");
        sb.Append("</body>\n");
        
        sb.Append("</html>\n");
        
        return sb.ToString();
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