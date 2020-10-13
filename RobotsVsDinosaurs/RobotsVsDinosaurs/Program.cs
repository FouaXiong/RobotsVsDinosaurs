using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Robot robot = new Robot(new Weapon("Laser", 50), "Laz0r", 100, 30);
            //Dinosaur dinosaur = new Dinosaur("Velociraptor", 100, 30, 20);
            //bool alive = dinosaur.attack(robot);
            //Console.WriteLine(alive);
            //Console.WriteLine(robot.health);
            //alive = dinosaur.attack(robot);
            //Console.WriteLine(alive);
            //Console.WriteLine(robot.health);
            //alive = dinosaur.attack(robot);
            //Console.WriteLine(alive);
            //Console.WriteLine(robot.health);
            //alive = dinosaur.attack(robot);
            //Console.WriteLine(alive);
            //Console.WriteLine(robot.health);
            //Console.ReadLine();
            //for (int i = 0; i < 5; i++)
            //{
            //    bool dead = dinosaur.attack(robot);

            //    if (dead == false)
            //    {
            //        Console.WriteLine("Robot is alive, HP");
            //        Console.WriteLine(robot.health);
            //    }
            //    else 
            //    {
            //        Console.WriteLine("Robot is dead!");
            //        Console.WriteLine(robot.health);
            //    }
            //}
            Battlefield battlefield = new Battlefield();
            battlefield.runGame();

           
           
            
            Console.ReadLine();
        }
    }
}
