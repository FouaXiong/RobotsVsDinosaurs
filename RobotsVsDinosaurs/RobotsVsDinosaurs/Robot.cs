using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot
    {
        // member variables (HAS A)
        public string robotName;
        public int health;
        public int powerLevel;
        public Weapon laser;

        // constructor (SPAWNER)
        public Robot(Weapon weapon, string robotName, int health, int powerLevel)
        {
            laser = weapon;
            this.robotName = robotName;
            this.health = health;
            this.powerLevel = powerLevel;
        }

        public bool attack(Dinosaur dinosaur)
        {
            dinosaur.health -= powerLevel;
            Console.WriteLine(dinosaur.health);
            return checkIfDinosaurDied(dinosaur);
        }
        
        //member methods (CAN DO)
        // Method to attack Dinosaur
            //Pass in a dinosaur.
        public bool checkIfDinosaurDied(Dinosaur dinosaur)
        {
            if (dinosaur.health > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        
        }
    }
}
