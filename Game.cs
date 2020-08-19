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
            float healthRegen = 20;
            bool maxlevelreached = false;
            int damage = 20;
            int level = 1;
            bool ready = true;
            string role = "none";
            Console.WriteLine("Hello Traveler! What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Welcome " + name + " !" + "Please input role");
            Console.WriteLine("Press 1 for Knight role");
            Console.WriteLine("Press 2 for Wizard role");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if(input == '1')
            {
                health = 200;
                role = "Knight";
            }
            else if(input == '2')
            {
                damage = 40;
                role = "Wizard";
            }
            else
            {
                Console.WriteLine("Invalid input. Using default stats");
            }
            
            Console.WriteLine("player name: " + name);
            Console.WriteLine("player health: " + health);
            Console.WriteLine("player damage: " + damage);
            Console.WriteLine("player level: " + level);
            Console.WriteLine("player role: " + role);
            Console.WriteLine("Press any key to continue. ");
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("You've been approached by a mysterious traveler walk like as half-naked azetic stripper.");
            Console.WriteLine("They offer you a strange but creepy stone mask with a promise to turn you night creature. It will boost all your stat. but suffer reduces your stat while under sunlight");
            Console.WriteLine("Press 1 for I REJECT MY HUMANITY! YES.");
            Console.WriteLine("Press 2 for I refuse.");
            input = Console.ReadKey().KeyChar;
            if (input == '1')
            {
                health = 300;
                damage = 500;
                Console.WriteLine("You put on mask and light shine! ");
                Console.WriteLine("You died but awaken and feeling so cold and powerful such as pleasure... ");
            }
            else if (input == '2');
            {
                Console.WriteLine(name + " refused put on mask and continue your journey.");
            }
            Console.WriteLine("Press any key to continue");
            Console.Clear.();
            Console.WriteLine("You've come to a crossroad.");
            Console.WriteLine("There's a sign. Do you read it?");
            Console.WriteLine("Press 1 for yes.");
            Console.WriteLine("Press 2 for no");
            input = Console.ReadKey().
        }
    }
}
