using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationGeo.Data;

namespace WebApplicationGeo.Controllers.Toyota;

public class SearchColorController : Controller
{
    private readonly ApplicationDbContext _context;

    public SearchColorController(ApplicationDbContext context)
    {
        _context = context;
    }
    
    // GET
    
    // 1 крок - Controller from url (path)
    public IActionResult Index(
        string search = null
        )
    {

        // 2 крок (Inlcude)
        var colors = _context.Colors;
        colors.Include(colors => colors.Configurations);
        
        // 3 крок (Where - Filter )
        if (!String.IsNullOrEmpty(search))
        {
            colors.Where( color => color.Name.ToLower().Contains(search.ToLower()));
        }
        
        // 4 - Paginate
        colors.Skip(0);
        colors.Take(5);
        
        // 5 - Order By
        colors.OrderBy(c=> c.Name);

        colors.ToList();
        
        
        return View();
    }
}