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
            int input = GetInput("Are you a brawler or a specialist?", "Brawler", "Specialist");
            if (input == 1)
            {
                playerRole = "Brawler";
                Console.WriteLine("Player role: " + playerRole);
                Console.WriteLine("Stats: ");
                Console.WriteLine("Strength: 5");
                Console.WriteLine("Speed: 2");
                Console.WriteLine("Agility: 3");
                Console.WriteLine("Defense: 4");
                Console.WriteLine("Intelligence: 3");
                Console.WriteLine();
            }
            else if (input == 2)
            {
                playerRole = "Specialist";
                Console.WriteLine("Player role: " + playerRole);
                Console.WriteLine("Stats: ");
                Console.WriteLine("Strength: 3");
                Console.WriteLine("Speed: 4");
                Console.WriteLine("Agility: 5");
                Console.WriteLine("Defense: 2");
                Console.WriteLine("Intelligence: 4");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Bag: ");
            Console.WriteLine("Gold: " + playerGold);
            Console.WriteLine("Silver: " + playerSilver);
            Console.WriteLine("Bronze: " + playerBronze);
            Console.WriteLine("Dagger");
            Console.WriteLine();
            {
                int v = GetInput("You have to choose out of two doors which one to go through.", "Left Door", "Right Door");
                if (v == 1)
                {
                    Console.WriteLine("Good Job You Died.");
                }
                else if (v == 2)
                {
                    Console.WriteLine("You enter the right door.");
                    Console.WriteLine();
                    Console.WriteLine("Great, you've made it to the next set of puzzles.");
                    Console.WriteLine("You're next puzzle will be a riddle.");
                    Console.WriteLine();
                    int v1 = GetInput("Man walks over, man walks under, in times of war he burns asunder", "Bridge", "Building");
                    if (v1 == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Correct, you are smarter than I thought.");
                        Console.WriteLine("Now onto the next challenge.");
                        Console.WriteLine();

                    }
                    else if (v1 == 2)
                    {
                        Console.WriteLine("Haha, you got it wrong.");
                    }
                }

            }
        }

        int GetInput(string description, string option1, string option2)
        {
            string input = "";
            int inputRecieved = 0;

            // Input loop
            while (inputRecieved != 1 && inputRecieved != 2)
            {
                // Pring options
                Console.WriteLine(description);
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);
                Console.Write("> ");

                // Get input from player
                input = Console.ReadLine();

                // If player selected the first option
                if (input == "1" || input == option1)
                {
                    // Set inputRecieved to be the first option
                    inputRecieved = 1;
                }
                // Otherwise if the player selected the second option
                else if (input == "2" || input == option2)
                {
                    // Set inputRecieved to be the second option
                    inputRecieved = 2;
                }
                // If neither are true
                else
                {
                    // Display error message
                    Console.WriteLine("Invalid Input");
                    Console.ReadKey();
                }
            }

            Console.Clear();
            return inputRecieved;
        }
    }
}
