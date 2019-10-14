using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {

            Building FiveOneTwoEight = new Building("512 8th Avenue");
            FiveOneTwoEight.Width = 500;
            FiveOneTwoEight.Depth = 600;
            FiveOneTwoEight.Stories = 5;

            Building FourTwoTwoSeven = new Building("422 7th Avenue");
            FourTwoTwoSeven.Width = 200;
            FourTwoTwoSeven.Depth = 400;
            FourTwoTwoSeven.Stories = 3;

            Building OneNineThreeEight = new Building("193 8th Avenue");
            OneNineThreeEight.Width = 1000;
            OneNineThreeEight.Depth = 2000;
            OneNineThreeEight.Stories = 10;

            FiveOneTwoEight._Construct();
            FiveOneTwoEight._Purchase("Donald Trump");
            FourTwoTwoSeven._Construct();
            FourTwoTwoSeven._Purchase("Anonymous");
            OneNineThreeEight._Construct();
            OneNineThreeEight._Purchase("Jeff Bezos");

            // FiveOneTwoEight.Print();
            // FourTwoTwoSeven.Print();
            // OneNineThreeEight.Print();

            City Megalopolis = new City("Megalopolis");

            Megalopolis.addBuilding(FourTwoTwoSeven);

            Megalopolis.addBuilding(OneNineThreeEight);
            
            foreach (Building taco in Megalopolis.Buildings) {
                taco.Print();
            }

        }
    }
}
