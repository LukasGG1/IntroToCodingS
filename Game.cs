using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            float health = 100.0f;
            float healthRegen = 30;
            string name = Console.ReadLine();
            bool maxlevelreached = false;
            int maxlevel = 50;
            int level = 1;
            bool ready = true;
            Console.WriteLine(health);
            health = health + healthRegen;
            Console.Write(name + " was healed by Gold Experience. Gained " + healthRegen + " health");
        }
    }
}
