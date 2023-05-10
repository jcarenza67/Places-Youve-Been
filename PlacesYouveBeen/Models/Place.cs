using System;
using System.Collections.Generic;

namespace PlacesYouveBeen.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public string Date { get; set; }
    public string Journal { get; set; }
    public int Id { get; }
    // public string Friends { get; set; }


    private static  List<Place> _instances = new List<Place> { };  
    public Place (string cityName, string date, string journal)
    {
      CityName = cityName;
      Date = date;
      Journal = journal;
      _instances.Add(this);
      Id = _instances.Count;  
    }

 
    public static List<Place> GetAll()
    {
      return _instances; 
    }

    public static void Clear()
    {
      _instances.Clear();
    }

    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
