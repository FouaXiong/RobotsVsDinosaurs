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
            fleet = new Fleet(2);
            herd = new Herd(3);
        }

        // Run Game method
        public void runGame()
        {
            while (true)
            {
                fleet.herdAttacks(herd.dinosaurs);

            }
        }
        //Declare winner method
    }
}
