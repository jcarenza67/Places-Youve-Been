using PlacesYouveBeen.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PlacesYouveBeen.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Places.GetAll();
      return View(allPlaces);
    }
  [HttpGet("/places/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
  [HttpPost("/cars")]
    public ActionResult Create(string makeModel, int price)
    {
      Car myCar = new Car(makeModel, price);
      return RedirectToAction("Index");
    }

  }
}