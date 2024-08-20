using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationGeo.Data;

namespace WebApplicationGeo.Controllers.Toyota
{
    public class ShowAllCarsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShowAllCarsController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        
        // GET: ShowAllCarsController
        public ActionResult Index()
        {
            var allModels 
                 =  _context.ToyotaModels
                .Include(tModels => tModels.Configurations)
                    .ThenInclude(tConfig => tConfig.Colors )
                        .ThenInclude(tColors => tColors.Color)
                .ToList();
            
            return View(allModels);
        }

    }
}
