namespace BestRestaurants.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public string Dish { get; set; }
    public int Price { get; set; }
    public string Location { get; set; }

    public int CuisineId { get; set; }
    public CuisineType CuisineType { get; set; }
  }
}