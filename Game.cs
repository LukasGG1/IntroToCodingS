using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
             Console.WriteLine("Hello Traveler! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name + " !" + "Please input role");
            string role = Console.ReadLine();
            Console.WriteLine("What is your race, " + name);
            string race = Console.ReadLine();
            float health = 100.0f;
            float healthRegen = 20;
            bool maxlevelreached = false;
            int maxlevel = 50;
            int level = 1;
            bool ready = true;
            Console.WriteLine("player name: " + name);
            Console.WriteLine("player health: " + health);
            Console.WriteLine("player level: " + level);
            Console.WriteLine("player role: " + role);
            Console.WriteLine("Player Race: " + race);
        }
    }
}
