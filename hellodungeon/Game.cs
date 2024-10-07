using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelloDungeon
{
    internal class Game
    {
        bool playerIsAlive = true;
        int currentArea = 1;
        bool gameOver = false;

        struct Player1
        {
            public float health;
            public float stamina;
            public float mana;
            public int strength;
            public int speed;
            public int defense;
            public int gold;
            public int silver;
            public int bronze;
            public string name;
            public string role;
            public string race;
            public string weapon;

            public Player1(
                string name,
                string role,
                string race,
                string weapon,
                float health,
                float stamina,
                float mana,
                int strength,
                int speed,
                int defense,
                int gold,
                int silver,
                int bronze)
            {
                this.name = name;
                this.race = race;
                this.weapon = weapon;
                this.role = role;
                this.health = health;
                this.stamina = stamina;
                this.mana = mana;
                this.strength = strength;
                this.speed = speed;
                this.defense = defense;
                this.gold = gold;
                this.silver = silver;
                this.bronze = bronze;
            }
        }
        struct DungeonMaster
        {
            public string name;
            public float health;
            public float stamina;
            public float mana;
            public int strength;
            public int speed;
            public int defense;

            public DungeonMaster(
                string name,
                float health,
                float stamina,
                float mana,
                int strength,
                int speed,
                int defense)
            {
                this.name = name;
                this.health = health;
                this.stamina = stamina;
                this.mana = mana;
                this.strength = strength;
                this.speed = speed;
                this.defense = defense;
            }
        }
        Player1 mainCharacter = new Player1(name: "", role: "", race: "", weapon: "", 100, 100, 50f, 50, 25, 40, 3, 10, 7);
        private enum Room
        {
            ROOM1,
            ROOM2,
            ROOM3,
            ROOM4,
            MAIN_MENU
        }
        void Room1()
        {
            //declaring Player mainCharacter and the stats
            Console.WriteLine("Hello, your name please");
#pragma warning disable CS8601 // Possible null reference assignment.
            mainCharacter.name = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.

            Console.WriteLine();
            Console.WriteLine("Hello " + mainCharacter.name + ". Welcome to my dungeon!");
            Console.WriteLine();
            Console.WriteLine("What is your race?");
#pragma warning disable CS8601 // Possible null reference assignment.
            mainCharacter.race = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.

            Console.WriteLine();
            Console.WriteLine("So you are a " + mainCharacter.race);
            Console.WriteLine("Health: " + mainCharacter.health);
            Console.WriteLine("Stamina: " + mainCharacter.stamina);
            Console.WriteLine("Mana: " + mainCharacter.mana);
            Console.WriteLine();
            int input = GetInput("Are you a brawler or a specialist?", "Brawler", "Specialist");
            if (input == 1)
            {
                //creating brawler role and giving it stats
                mainCharacter.role = "Brawler";
                Console.WriteLine("Player role: " + mainCharacter.role);
                Console.WriteLine("Stats: ");
                Console.WriteLine("Strength: " + mainCharacter.strength);
                Console.WriteLine("Speed: " + mainCharacter.speed);
                Console.WriteLine("Defense: " + mainCharacter.defense);
                Console.WriteLine();
            }
            else if (input == 2)
            {
                //creating specialist and giving it stats
                mainCharacter.role = "Specialist";
                Console.WriteLine("Player role: " + mainCharacter.role);
                Console.WriteLine("Stats: ");
                Console.WriteLine("Strength: 3");
                Console.WriteLine("Speed: 4");
                Console.WriteLine("Agility: 5");
                Console.WriteLine("Defense: 2");
                Console.WriteLine("Intelligence: 4");
                Console.WriteLine();
            }
            //showing bag and its items
            Console.WriteLine();
            Console.WriteLine("Bag: ");
            Console.WriteLine("Gold: " + mainCharacter.gold);
            Console.WriteLine("Silver: " + mainCharacter.silver);
            Console.WriteLine("Bronze: " + mainCharacter.bronze);
            Console.WriteLine();
            {
                int v = GetInput("You have to choose out of two doors which one to go through.", "Left Door", "Right Door");
                if (v == 1)
                {
                    Console.WriteLine("Good Job You Died.");
                    playerIsAlive = false;
                }
                else if (v == 2)
                {
                    Console.WriteLine("You enter the right door.");
                    Console.WriteLine();
                    Console.WriteLine("Great, you've made it to the next area.");
                }
            }
        }
        void Room2()
        {
            //giving number of attempts
            int numberOfAttempts = 5;
            string input = "";

            for (int i = 0; i < numberOfAttempts; i--)
            {
                Console.Clear();
                //riddle and its answer
                Console.WriteLine("You're next puzzle will be a riddle.");
                Console.WriteLine("You will have " + numberOfAttempts + " attempts.");
                Console.WriteLine();
                Console.WriteLine("Man walks over, man walks under, in times of war he burns asunder", "Bridge");

                int attemptsRemaining = numberOfAttempts + i;

                Console.WriteLine("Attempts Remaining: " + attemptsRemaining);

                Console.Write("> ");
                input = Console.ReadLine();

                if (input == "bridge")
                {
                    Console.WriteLine("Correct, you are smarter than I thought.");
                    Console.WriteLine("Now onto the next challenge.");
                    Console.WriteLine();
                    break;
                }

                Console.WriteLine("No, you are wrong of course.");
                Console.ReadKey();
                
                if (attemptsRemaining <= 0)
                {
                    playerIsAlive = false;
                    Console.WriteLine("Seems your not as smart as I thought, dumbass.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
            }
        }
        void Room3()
        {
            //fight the dungeon master
            Console.Clear();
            Console.WriteLine("Now of course because this is a dungeon you are going to have to fight.");
            Console.WriteLine("So you are goin to fight me. The Dungeon Master!");
            DungeonMaster boss = new DungeonMaster("Dungeon Master", 200, 100, 100f, 45, 20, 30);
            //battle sequence
            while (mainCharacter.health > 0 && boss.health > 0)
            {
                Console.WriteLine("_______________");
                // monster1 attacks monster2
                Console.WriteLine(boss.name + " Has taken " + Fight(mainCharacter, ref boss) + " damage!");

                //monster2 attacks monster1
                Console.WriteLine(mainCharacter.name + " Has taken " + Fight(boss, ref mainCharacter) + " damage!");

                PrintStats(mainCharacter);
                PrintStats(boss);
            }
            Console.ReadKey();
        }
        //end of the game
        void Room4()
        {
            Console.Clear();
            Console.WriteLine("You've beaten the Dungeon Master. Congratulaions.");
        }
       //main menu screen
        void DisplayMainMenu()
        {
            //displays if you'd like to play again
            int input = GetInput("Would you like to play again?", "Yes", "No");

            //if player presses yes
            if(input == 1)
            {
                //set currentArea to be start with reset stats
                currentArea = 1;
                gameOver = false;
                playerIsAlive = true;
            }
            //if you quit
            else if (input == 2)
            {
                gameOver = true;
            }
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
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                input = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

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

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                input = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

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

            while (inputRecieved != 1 && inputRecieved != 2)
            {
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);
                Console.WriteLine("> ");

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                input = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

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
        //the run for the game
        public void Run()
        {
            // Loop while game isn't over
            while (gameOver == false)
            {
                //Print the current room to the screen
                //if (currentArea == 1)
                //{
                //    Room1();
                //}
                //if (currentArea == 2)
                //{
                //    Room2();
                //}
                //if (currentArea == 3)
                //{
                //    Room3();
                //}
                //if (currentArea == 4)
                //{
                //    Room4();
                //}
                Room room = Room.ROOM1;

                switch (room)
                {
                    case Room.ROOM1:
                        Room1();
                        break;
                    case Room.ROOM2:
                        Room2();
                    break;
                    case Room.ROOM3:
                        Room3();
                        break;
                    case Room.ROOM4:
                        Room4();
                        break;
                }
                //if the player lost or beat the game
                if (playerIsAlive == false || currentArea == 4)
                {
                    //...print main menu
                    DisplayMainMenu();
                }
                else
                {
                    currentArea++;
                }
            }
        }
        //all the fighting features
        float Fight( Player1 attacker, ref DungeonMaster defender)
        {
            float damageTaken = CalculateDamage(attacker.strength, defender.defense);
            defender.health -= damageTaken;
            return damageTaken;
        }        
        float Fight( DungeonMaster attacker, ref Player1 defender)
        {
            float damageTaken = CalculateDamage(attacker.strength, defender.defense);
            defender.health -= damageTaken;
            return damageTaken;
        }
        float CalculateDamage(float strength, float defense)
        {
            float damage = strength - defense;

            //damage clamp method 1
            if (damage <= 0)
            {
                damage = 0;
            }

            return damage;
        }
        void PrintStats(Player1 mainCharacter)
        {
            Console.WriteLine("Name:    " + mainCharacter.name);
            Console.WriteLine("Health:  " + mainCharacter.health);
            Console.WriteLine("Attack:  " + mainCharacter.strength);
            Console.WriteLine("Defense: " + mainCharacter.defense);
        }        
        void PrintStats(DungeonMaster boss)
        {
            Console.WriteLine("Name:    " + boss.name);
            Console.WriteLine("Health:  " + boss.health);
            Console.WriteLine("Attack:  " + boss.strength);
            Console.WriteLine("Defense: " + boss.defense);
        }
    }
}
