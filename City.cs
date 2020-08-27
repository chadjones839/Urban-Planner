using System;
using System.Collections.Generic;

namespace Planner
{
  public class City
  {
    public string CityName { get; set; }
    public string Mayor { get; set; }
    public string Founded { get; set; }
    private Dictionary<string, Building> BuildingList = new Dictionary<string, Building>();


    public City(string CityName, string Mayor, string Founded)
    {
      this.CityName = CityName;
      this.Mayor = Mayor;
      this.Founded = Founded;
    }

    public void AddBuilding(Building newBuilding)
    {
      BuildingList.Add(newBuilding.GetAddress(), newBuilding);
    }

    public void BuildingsList()
    {
      foreach (KeyValuePair<string, Building> building in BuildingList)
      {
        building.Value.ListBuildings();
      }
    }
  }
}