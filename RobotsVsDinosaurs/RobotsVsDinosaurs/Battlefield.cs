using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        //member variable

        Fleet fleet;
        Herd herd;

        public Battlefield()
        {
            fleet = new Fleet(1);
            herd = new Herd(1);
        }

        // Run Game method
        public void runGame()
        {
            while (fleet.robots.Count > 0 && 0 < herd.dinosaurs.Count)
            {
                fleet.herdAttacks(herd.dinosaurs);
                Console.WriteLine("Fleet");
                herd.fleetAttacks(fleet.robots);
                Console.WriteLine("Herd");
            }
            winningSide();
        }
        //Declare winner method
        public void winningSide()
        {
            if (fleet.robots.Count > herd.dinosaurs.Count)
            {
                Console.WriteLine("Fleet has won!");
            }
            else
            {
                Console.WriteLine("Herd has won!");
            }
        
        }
    }
}
