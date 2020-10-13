using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    {
        //member variable
        public List<Dinosaur> dinosaurs;



        //Constructor
        public Herd(int number)
        {
            dinosaurs = new List<Dinosaur>();
            createHerd(number);
        }

        public void createDinosaur()
        {
            Dinosaur dinosaur = new Dinosaur("Velocidrome", 100, 50, 20); //Instantiating
            dinosaurs.Add(dinosaur);
        }

        public void createHerd(int number)
        {
            for (int i = 0; i < number; i++)
			{
                createDinosaur();
			}
        }


        //member method
        //Method to create dinosaur and add to List.
        //Method to make dinosaur attack.
            // USE FOR/EACH
            //Pass in a Fleet.
    }
}
