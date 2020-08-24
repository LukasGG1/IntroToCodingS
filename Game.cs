using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            bool gameOver = false;
            while (gameOver == false)
            {

                float playerHealth = 100.0f;
                float healthRegen = 20;
                bool maxlevelreached = false;
                int damage = 20;
                int defense = 40;
                int level = 1;
                bool ready = true;
                int number = 0;
                while (number < 20)
                {
                    number++;
                }
                //What you typed was correct. We just have no way to see it.
                //By that I mean that that information wasn't printed to the console. 

                string race = "none";
                string role = "none";
                Console.WriteLine("......................................................................................................");
                Console.WriteLine(".............AA..............RRRRRRR.....EEEEEEEEEE...NN.............N...............AA...............");
                Console.WriteLine("............A.A..............R......R....E............N.N............N..............A..A..............");
                Console.WriteLine("...........A...A.............R......R....E............N..N...........N.............A....A.............");
                Console.WriteLine("..........A.....A............R......R....E............N...N..........N............A......A............");
                Console.WriteLine(".........A.......A...........R......R....E............N....N.........N...........A........A...........");
                Console.WriteLine("........A.........A..........RRRRRRR.....E............N.....N........N..........A..........A..........");
                Console.WriteLine(".......AAAAAAAAAAAAA.........RRR ........E............N......N.......N.........AAAAAAAAAAAAAA.........");
                Console.WriteLine(".......A............A........R.R.........EEEEEEEE.....N.......N......N........A..............A........");
                Console.WriteLine("......A..............A.......R..R........E............N........N.....N.......A................A.......");
                Console.WriteLine(".....A................A......R...R.......E............N.........N....N......A..................A......");
                Console.WriteLine("....A..................A.....R....R......E............N..........N...N.....A....................A.....");
                Console.WriteLine("...A....................A....R.... R.....E............N...........N..N....A......................A....");
                Console.WriteLine("..A......................A ..R......R....E............N............N.N...A........................A...");
                Console.WriteLine(".A........................A..R.......R...EEEEEEEEEE...N.............NN..A..........................A..");
                Console.WriteLine("......................................................................................................");
                Console.ReadKey();

                Console.Clear();

                Console.WriteLine("Mysterious Old man:" + "Greeting, Stranger. I am Dungeon Master. What is your name?"); // << like this was
                Console.WriteLine(" ");
                Console.WriteLine("(Type your name please)");
                string name = Console.ReadLine();

                Console.WriteLine("Dungeon Master:" + "Welcome, " + name + "!" + "   Please input role");
                Console.WriteLine("Press 1 for Warden role");
                Console.WriteLine("Press 2 for Necromancer role");
                char input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                //we can also use a while loop here. We can loop until the player puts in a valid input
                //The condition would look like this : while(input != '1' && input!= '2')
                //Try to get this working and I'll be back in a bit to check on you
                while (input != '1' && input != '2')
                Console.WriteLine();
                if (input == '1')
                {
                    playerHealth = 200;
                    role = "Warden";
                }
                else if (input == '2')
                {
                    damage = 40;
                    role = "Necromancer";
                }
                else
                {
                    Console.WriteLine("Dungeon Master:" + "Invalid input. Pick your role please," + name);
                    Console.ReadKey();
                }

                Console.Clear();

                Console.WriteLine("Dungeon Master: " + "What is your race, " + name + "?");
                Console.WriteLine("Press 1 for Dark Elf");
                Console.WriteLine("Press 2 for Human");
                Console.WriteLine("Press 3 for Dwarf");
                Console.WriteLine("Press 4 for Khajit(Cat men)");
                Console.WriteLine("Press 5 for Orc");
                input = Console.ReadKey().KeyChar;
                while (input != '1' && input != '2' && input != '3' && input != '4' && input != '5');
                Console.WriteLine();
                if (input == '1')
                {
                    race = "Dark Elf";
                }
                else if (input == '2')
                {
                    race = "Human";

                }
                else if (input == '3')
                {
                    race = "Dwarf";
                }
                else if (input == '4')
                {
                    race = "Khajit";
                }
                else if (input == '5')
                {
                    race = "orc";
                }
                Console.Clear();

                Console.WriteLine("player name: " + name);
                Console.WriteLine("player health: " + playerHealth);
                Console.WriteLine("player damage: " + damage);
                Console.WriteLine("player level: " + level);
                Console.WriteLine("player role: " + role);
                Console.WriteLine("Player Defense: " + defense);
                Console.WriteLine("Player Race: " + race);
                Console.WriteLine("Press any key to continue. ");
                Console.ReadKey();

                Console.Clear();


                Console.WriteLine("You start your own journay." + "You tripped over stange chest" + "You looked at strange chest" + "Should you open chest," + name);
                Console.WriteLine("Press 1 for Open Stange Chest");
                Console.WriteLine("Press 2 for refuse open strange chest.");
                input = Console.ReadKey().KeyChar;
                if (input == '1')
                {
                    playerHealth = 0;
                    damage = 500;
                    Console.WriteLine("You reaches your hand to open chest");
                    Console.WriteLine("Suddenly, Chest revels his arm and grabbed you!");
                    Console.WriteLine("Chest revels his mouth and such terriying teeth as shark and ate whole you");
                    Console.WriteLine(name + " died. Game Over!");
                    gameOver = true;
                    break;

                }

                else if (input == '2')
                {
                    Console.WriteLine("You decided to not open strange chest");
                    Console.WriteLine("You continued your journey");
                    Console.ReadKey();
                }

                Console.Clear();


                Console.WriteLine("You continues to forest. Bandit suddenly appears! It is time for you shine, " + name + "!");
                Console.ReadKey();

                Console.Clear();

                int banditHealth = 60;
                int banditDamage = 25;
                while (playerHealth > 0 && banditHealth > 0)
                {
                    Console.WriteLine("player name: " + name);
                    Console.WriteLine("player health: " + playerHealth);
                    Console.WriteLine("player damage: " + damage);
                    Console.WriteLine("player level: " + level);
                    Console.WriteLine("player role: " + role);
                    Console.WriteLine("player defense: " + defense);
                    //Enemy stat
                    Console.WriteLine("Bandit's Name: No-No Dancer");
                    Console.WriteLine("Bandit Health: " + banditHealth);
                    Console.WriteLine("Bandit Damage: " + banditDamage);
                    Console.WriteLine("Bandit Role: Nightblade");
                    {
                        Console.WriteLine("Press 1 to Attack");
                        Console.WriteLine("Press 2 to Defend");
                        input = Console.ReadKey().KeyChar;
                        if (input == '1')
                        {
                            banditHealth -= damage;
                            Console.WriteLine("You hit them with a your refenece signure move from anime");
                            continue;
                        }
                        else if (input == '2')
                        {
                            defense -= banditDamage;
                            Console.WriteLine("You try poses but it succesed raised your guard. Bandit yeeted rock to you" + "Your shield took" + banditDamage + "damage");
                            continue;
                        }
                    }
                }
                

                
                Console.Clear();

                Console.WriteLine("You've been approached by a mysterious traveler walk like as half-naked azetic stripper.");
                Console.WriteLine("They offer you a strange but creepy stone mask with a promise to turn you night creature. It will boost all your stat. but suffer reduces your stat while under sunlight");
                Console.WriteLine("Press 1 for I REJECT MY HUMANITY! YES.");
                Console.WriteLine("Press 2 for I refuse.");
                input = Console.ReadKey().KeyChar;
                if (input == '1')
                {
                    playerHealth = 300;
                    damage = 500;
                    Console.WriteLine("You put on mask and light shine! ");
                    Console.WriteLine("You died but awaken and feeling so cold and powerful such as pleasure... ");
                    Console.ReadKey();
                }
                else if (input == '2') 
                {
                    Console.WriteLine(name + " refused put on mask and continue your journey.");
                }
                Console.WriteLine("Press any key to continue");
                Console.WriteLine("You've come to a crossroad.");
                Console.WriteLine("There's a weary sign. Do you read it?");
                Console.WriteLine("Press 1 for yes.");
                Console.WriteLine("Press 2 for no");
                input = Console.ReadKey().KeyChar; 
                

            }
        }
    }
}
