using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    internal class Game
    {
        public void Run()
        {
            float workalreDY;
            float playerHealth = 10.0f;
            float playerStamina = 10.0f;
            float playerMana = 5.0f;
            int playerGold = 3;
            int playerSilver = 10;
            int playerBronze = 7;
            string playerRole = "Warrior";

            Console.WriteLine("Hello, your name please");
            string? playerName = Console.ReadLine();
            
            Console.WriteLine();
            Console.WriteLine("Hello " + playerName + ". Welcome to my dungeon!");
            Console.WriteLine();
            Console.WriteLine("What is your race?");
            string? playerRace = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("So you are a " + playerRace);
            Console.WriteLine("Health: " + playerHealth);
            Console.WriteLine("Stamina: " + playerStamina);
            Console.WriteLine("Mana: " + playerMana);
            Console.WriteLine();
            Console.WriteLine("Are you a Brawler or a Specialist");
            Console.Write("(1 | 2) > ");

            string input = "";

            while (input != "1" && input != "2")
            {
                Console.Write("(1 | 2) > ");
                input = Console.ReadLine();

                if (input == "1")
                {
                    playerRole = "Brawler";
                    Console.WriteLine("Player role: " + playerRole);
                    Console.WriteLine("Strength: 5");
                    Console.WriteLine("Speed: 2");
                    Console.WriteLine("Agility: 3");
                    Console.WriteLine("Defense: 4");
                    Console.WriteLine("Intelligence: 3");
                    Console.WriteLine();
                }
                else if (input == "2")
                {
                    playerRole = "Specialist";
                    Console.WriteLine("Player role: " + playerRole);
                    Console.WriteLine("Strength: 3");
                    Console.WriteLine("Speed: 4");
                    Console.WriteLine("Agility: 5");
                    Console.WriteLine("Defense: 2");
                    Console.WriteLine("Intelligence: 4");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Bag: ");
            Console.WriteLine("Gold: " + playerGold);
            Console.WriteLine("Silver: " + playerSilver);
            Console.WriteLine("Bronze: " + playerBronze);
            Console.WriteLine("Dagger");
            Console.WriteLine();
            Console.WriteLine("Stats: ");
            Console.WriteLine("You have two doors in front of you. Which one do you choose?");
            Console.WriteLine();
            Console.WriteLine("1: Left Door | 2: Right Door");
            string? playerChoice = Console.ReadLine();
            while (input != "1" && input != "2")
            {
                Console.WriteLine("Invalid Choice");
                playerChoice = Console.ReadLine();
            }
            if (StringContent.Equals(playerChoice, "1"))
            {
                Console.WriteLine("Good Job You Died.");
            }
            else if (StringContent.Equals(playerChoice, "2"))
            {
                Console.WriteLine("You enter the right door.");
                Console.WriteLine();
                Console.WriteLine("Great, you've made it to the next set of puzzles.");
                Console.WriteLine("You're next puzzle will be a riddle.");
                Console.WriteLine();
                Console.WriteLine("Man walks over, man walks under, in times of war he burns asunder");
                string? playerRiddle = Console.ReadLine();
                while (input != "Bridge")
                    if (StringContent.Equals(playerRiddle, "Bridge"))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Correct, you are smarter than I thought.");
                        Console.WriteLine("Now onto the next challenge.");
                        Console.ReadLine();

                    }
                    else if (StringContent.Equals(playerRiddle, "2")) ;
            }
            
        }
    }
}
