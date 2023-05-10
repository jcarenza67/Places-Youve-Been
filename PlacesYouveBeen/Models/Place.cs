namespace PlacesYouveBeen.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public string DaysThere { get; set; }
    public static List<Place> _entries = new List<Place> {};
    
    public Place(string cityName)
    {
      CityName = cityName;
      DaysThere = daysThere;
      _entries.Add(this);
    }

    public static List<Place> GetAll()
    {
      return _entries; 
    }

    public static void ClearAll()
    {
      _entries.Clear();
    }
  }

  public static Place Find(string cityName)
  {
    return _entries[cityName];
  }
}
