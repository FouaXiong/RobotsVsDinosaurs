using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            Dinosaur dinosaur2 = new Dinosaur("Gendrome", 100, 25, 30);
            dinosaurs.Add(dinosaur2);
            Dinosaur dinosaur3 = new Dinosaur("Iodrome", 150, 20, 15);
            dinosaurs.Add(dinosaur3);
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
    
        public void fleetAttacks(List<Robot> robot)
        {
            int count = 0;
            count = GetLowCount(robot);
            for (int i = 0; i < count; i++)
            {
                bool death;
                death = this.dinosaurs[i].attack(robot[i]);
                Console.WriteLine(death);
                if (death)
                {
                    robot.Remove(robot[i]);
                    count = GetLowCount(robot);
                }
            }
            
        }
        public int GetLowCount(List<Robot> robot)
        {
            if(robot.Count > dinosaurs.Count)
            {
                return dinosaurs.Count;
            }
            else
            {
                return robot.Count;
            }
        
        }
    
    
    
    }
}
