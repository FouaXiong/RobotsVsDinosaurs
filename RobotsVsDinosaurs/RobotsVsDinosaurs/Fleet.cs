using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet
    {
        public List<Robot> robots;

        //constructor
        public Fleet(int number)
        {
            robots = new List<Robot>();
            createFleet(number);
        }

        public void createRobot()
        {
            Weapon weapon = new Weapon("Laser", 25);
            Robot robot = new Robot(weapon, "Laz0r", 100, 50); //Instantiating
            robots.Add(robot);
        }
        
        public void createFleet(int number)
        {
            for (int i = 0; i < number; i++)
            {
                createRobot();
            }
        }
        //Method to create robot and add to List.
        //Method to make robots attack.
        // USE FOR/EACH
        //Pass in a Herd.

        public void herdAttacks(List<Dinosaur>dinosaur)
        {
            int count = 0;
            count = GetLowCount(dinosaur);
            for (int i = 0; i < count; i++)
            {
                bool death;
                death = this.robots[i].attack(dinosaur[i]);
                Console.WriteLine(death);
                if (death)
                {
                    dinosaur.Remove(dinosaur[i]);
                    count = GetLowCount(dinosaur);
                }
                
            }
        }
        public int GetLowCount(List<Dinosaur> dinosaur)
        {
            if (dinosaur.Count > robots.Count)
            {
                return robots.Count;

            }
            else
            {
                return dinosaur.Count;
            }
        }

    }
}
