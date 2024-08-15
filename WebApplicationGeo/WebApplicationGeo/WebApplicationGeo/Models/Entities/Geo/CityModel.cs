namespace WebApplicationGeo.Models.Entities.Geo;
using System.ComponentModel.DataAnnotations.Schema;

public class CityModel
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public int AreaId { get; set; }
    [ForeignKey("AreaId")]
    public int Area { get; set; }
}