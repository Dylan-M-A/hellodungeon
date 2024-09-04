using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    internal class Game
    {
        struct Player
        {
            public float health;
            public float stamina;
            public float mana;
            public int gold;
            public int silver;
            public int bronze;
            public string name;

            public Player(
                float health,
                float stamina,
                float mana,
                int gold,
                int silver,
                int bronze,
                string name)
            {
                this.health = health;
                this.stamina = stamina;
                this.mana = mana;
                this.gold = gold;
                this.silver = silver;
                this.bronze = bronze;
                this.name = name;
            }
        }

        static void Main(string[] args)
        {
            // type name = value
            Player player = new Player(10, 10, 5f, 3, 10, 7, "warrior");

            PrintPlayerStats(player);
            Console.WriteLine("-------------");
        }

        static void PrintPlayerStats(Player player)
        {
            Console.WriteLine(player.name + " Health:  " + player.health);
            Console.WriteLine(player.name + " Stamina:  " + player.stamina);
            Console.WriteLine(player.name + " Mana:  " + player.mana);
            Console.WriteLine(player.name + " Gold:  " + player.gold);
            Console.WriteLine(player.name + " Silver:  " + player.silver);
            Console.WriteLine(player.name + " Bronze:  " + player.bronze);
        }
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
                    input = GetInput("Man walks over, man walks under, in times of war he burns asunder", "Bridge");
                    if (input == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Correct, you are smarter than I thought.");
                        Console.WriteLine("Now onto the next challenge.");
                        Console.WriteLine();
                        Console.WriteLine("Your next puzzle will put you through a loop because its a maze.");
                        int v1 = GetInput("You have two choices one to go left and one to go right. Choose.", "Right", "Left");
                        if (v1 == 1)
                        {
                            input = GetChoice("Straight", "Left");
                            if (input == 1)
                            {
                                Console.WriteLine("Oh no, its a dead end.");
                            }
                            else if (input == 2)
                            {
                                input = GetChoice("Straight", "Left");
                                if (input == 1)
                                {
                                    input = GetChoice("Left", "Right");
                                    if (input == 1)
                                    {
                                        input = GetChoice("Right", "Left");
                                        if (input == 1)
                                        {
                                            input = GetChoice("Straight", "Left");
                                            if (input == 1)
                                            {

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (input == 2)
                    {
                        Console.WriteLine("Haha, you got it wrong.");
                    }
                }

            }
        }

        private int GetChoice(string v)
        {
            throw new NotImplementedException();
        }

        static int GetInput(string description, string option1, string option2)
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
        static int GetInput(string description, string option1)
        {
            string input = "";
            int inputRecieved = 0;

            while (inputRecieved != 1)
            {
                // Able to type answer now
                Console.WriteLine(description);
                Console.Write("> ");

                input = Console.ReadLine();

                if (input == "Bridge" || input == option1)
                {
                    inputRecieved = 1;
                }
                else
                {
                    Console.WriteLine("Nope, got it wrong.");
                    Console.ReadKey();
                }
            }

            Console.Clear();
            return inputRecieved;
        }
        static int GetChoice(string option1, string option2)
        {
            string input = "";
            int inputRecieved = 0;

            while (inputRecieved != 1)
            {
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);
                Console.WriteLine("> ");

                input = Console.ReadLine();

                if (input == "1" || input == option1)
                {
                    inputRecieved = 1;
                }
                else if (input == "2" || input == option2)
                {
                    inputRecieved = 2;
                }
                else
                {
                    Console.WriteLine("Put the right numbers and no letters.");
                    Console.ReadKey();
                }
            }

            Console.Clear();
            return inputRecieved;
        }
    }
}
