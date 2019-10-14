using System;
using System.Collections.Generic;

namespace Planner
{
    public class City {
        public string cityName {get; set;}
        public string Mayor =  "Mayor Ellie";
        public string yearEst = "1821";
        public List<Building> Buildings {get; set;}
        public void addBuilding(Building taco){
            Buildings.Add(taco);
            Console.WriteLine(taco);
        }
        public City(string cityName)
        {
            Buildings = new List<Building>();
            Console.WriteLine($"City: {cityName}");
        }
    }
}