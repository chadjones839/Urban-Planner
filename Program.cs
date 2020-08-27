using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            City flipadelphia = new City("flipadelphia", "Dr. Puddles", "2019");
            City nashville = new City("Nashville", "Robby Tommy", "1890");

            Building abstergo = new Building("Abstergo Inc.");
            abstergo.Construct("Ongo Gablogian", "Durl Winston");
            abstergo.Stories = 120;
            abstergo.Width = 300.5;
            abstergo.Depth = 150.5;

            Building spacersChoice = new Building("Spacers Choice");
            spacersChoice.Construct("Ongo Gablogian", "Wilson Brown");
            spacersChoice.Stories = 85;
            spacersChoice.Width = 100.3;
            spacersChoice.Depth = 100.8;

            Building ominent = new Building("Ominent Labs");
            ominent.Construct("Ongo Gablogian", "Carl Hanratty");
            ominent.Stories = 12;
            ominent.Width = 200.5;
            ominent.Depth = 235.5;


            flipadelphia.AddBuilding(ominent);
            flipadelphia.AddBuilding(spacersChoice);
            nashville.AddBuilding(abstergo);
            Console.WriteLine(flipadelphia.CityName);
            flipadelphia.BuildingsList();
            Console.WriteLine(nashville.CityName);
            nashville.BuildingsList();
        }
    }
}
