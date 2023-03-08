using Microsoft.EntityFrameworkCore;

namespace BestRestaurants.Models
{
  public class BestRestaurantsContext : DbContext
  {
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<CuisineType> CuisineType { get; set; }

    public BestRestaurantsContext(DbContextOptions options) : base(options) { }
  }
}    