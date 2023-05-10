using PlacesYouveBeen.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace PlacesYouveBeen.Controllers
{
  public class PlacesController : Controller
  {
    private static List<Place> _places = new List<Place> { };

    [HttpGet("/places")]
    public ActionResult Index()
    {
      return View(_places);
    }
  [HttpGet("/places/new")]
    public ActionResult New()
    { 
      return View();
    }
  [HttpPost("/places")]
    public ActionResult Create(string cityName, string date, string journal, string friends)
    {
      Place myPlace = new Place(cityName, date, journal, friends);
      _places.Add(myPlace);
      return RedirectToAction("Index");
    }

  [HttpPost("/places/delete")]
  public ActionResult Clear()
  {
    _places.Clear();
    return View("Index", _places);
  }
  [HttpGet("/places/{id}")]
    public ActionResult Show(int id)
    {
      Place foundPlace = _places.Find(place => place.Id == id);
      return View(foundPlace);
    }

    [HttpPost("/places/{id}/delete")]
    public ActionResult Delete(int id)
    {
      Place deletePlace = _places.Find(place => place.Id == id);
      _places.Remove(deletePlace);
      return RedirectToAction("Index");
    }

  }
}