using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur
    {
        public string dinosaurType;
        public int health;
        public int energy;
        public int attackPower;  
    
        public Dinosaur(string dinosaurType, int health, int energy, int attackPower)
        {
            this.dinosaurType = dinosaurType;
            this.health = health;
            this.energy = energy;
            this.attackPower = attackPower;
        }
        // Method to attack Robot
        //Pass in a Robot.

        public bool attack(Robot robot)
        {
            // What do we need to have happen when attacking a robot?
            //Reduce robot health
            robot.health -= attackPower;
            return checkIfRobotDied(robot);
        }
    
        public bool checkIfRobotDied(Robot robot)
        {
            //Check current health
            //If current health is greater than 0
            //else current health is less than 0
            if (robot.health > 0)
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
