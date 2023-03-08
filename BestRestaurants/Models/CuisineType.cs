using System.Collections.Generic;

namespace BestRestaurants.Models
{
  public class CuisineType
  {
    public int CuisineId { get; set; }
    public string Cuisine { get; set; }
    public List<Restaurant> Restaurants { get; set; }
  }
}