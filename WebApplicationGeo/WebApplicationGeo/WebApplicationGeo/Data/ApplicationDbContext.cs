using WebApplicationGeo.Models.Cars.Toyota;
using WebApplicationGeo.Models.Entities.Geo;

namespace WebApplicationGeo.Data;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public DbSet<ColorModel> Colors { get; set; }
    public DbSet<CountryModel> Countries { get; set; }
    public DbSet<AreaModel> Areas { get; set; }
    public DbSet<CityModel> Cities { get; set; }
    public DbSet<RegionModel> Regions { get; set; }
    
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}