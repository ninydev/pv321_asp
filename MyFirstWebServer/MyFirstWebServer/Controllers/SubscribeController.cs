using Microsoft.AspNetCore.Mvc;
using MyFirstWebServer.Data;
using MyFirstWebServer.Models.Entities;

namespace MyFirstWebServer.Controllers;

public class SubscribeController : Controller
{
    
    private readonly ApplicationDbContext _context;

    /// <summary>
    /// Создае класс контроллер
    /// </summary>
    /// <param name="context"> Зеднання з БД </param>
    public SubscribeController(ApplicationDbContext context)
    {
        _context = context;
    }


    /// <summary>
    /// Add user email to DB
    /// </summary>
    /// <param name="email">User email</param>
    /// <returns></returns>
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult SaveEmail(String email)
    {
        ViewBag.email = email;

        SubscribeModel newSubscriber = new SubscribeModel();
        newSubscriber.Email = email;

        // Таким чином ми перезавантажемо БД
        // ApplicationDbContext db = new ApplicationDbContext();

        _context.Subscribers.Add(newSubscriber);
        _context.SaveChangesAsync();
        
        return View();
    }

}

