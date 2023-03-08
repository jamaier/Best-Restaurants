using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using BestRestaurants.Models;
using System.Collections.Generic;
using System.Linq;

namespace BestRestaurants.Controllers
{
  public class CuisineTypesController : Controller
  {
    private readonly BestRestaurantsContext _db;

    public CuisineTypesController(BestRestaurantsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<CuisineType> model = _db.CuisineTypes.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(CuisineType cuisineType)
    {
      _db.CuisineTypes.Add(cuisineType);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      CuisineType thisCuisineType = _db.CuisineTypes
                                  .Include(cuisineType => cuisineType.Restaurants)
                                  .FirstOrDefault(cuisineType => cuisineType.CuisineId == id);
      return View(thisCuisineType);
    }

    public ActionResult Edit(int id)
    {
      CuisineType thisCuisineType = _db.CuisineTypes.FirstOrDefault(cuisineType => cuisineType.CuisineId == id);
      return View(thisCuisineType);
    }

    [HttpPost]
    public ActionResult Edit(CuisineType cuisineType)
    {
      _db.CuisineTypes.Update(cuisineType);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      CuisineType thisCuisineType = _db.CuisineTypes.FirstOrDefault(cuisineType => cuisineType.CuisineId == id);
      return View(thisCuisineType);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      CuisineType thisCuisineType = _db.CuisineTypes.FirstOrDefault(cuisineType => cuisineType.CuisineId == id);
      _db.CuisineTypes.Remove(thisCuisineType);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}