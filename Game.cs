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
            string playerName = "Boblius";
            string playerRace = "Orc";
            float playerHealth = 10.0f;
            float playerStamina = 10.0f;
            float playerMana = 5.0f;
            int playerGold = 3;
            int playerSilver = 10;
            int playerBronze = 7;
            string playerAlignment = "Evil";
            bool playerAlive = false;
            int playerSecondLife = 1;
            int playerStrength = 5;
            int playerSpeed = 2;
            int playerAgility = 2;
            int playerDefense = 4;
            int playerIntelligence = 3;

            Console.WriteLine("Hello, " + playerName);
            Console.WriteLine();
            Console.WriteLine("Welcome to my dungeon!");
            Console.WriteLine();
            Console.WriteLine("Race: " + playerRace);
            Console.WriteLine("Health: " + playerHealth);
            Console.WriteLine("Stamina: " + playerStamina);
            Console.WriteLine("Mana: " + playerMana);
            Console.WriteLine("Alignment: " + playerAlignment);
            Console.WriteLine("Alive: " + playerAlive);
            Console.WriteLine();
            Console.WriteLine("Bag: ");
            Console.WriteLine("Gold: " + playerGold);
            Console.WriteLine("Silver: " + playerSilver);
            Console.WriteLine("Bronze: " + playerBronze);
            Console.WriteLine("Dagger");
            Console.WriteLine();
            Console.WriteLine("Stats: ");
            Console.WriteLine("Strength: " + playerStrength);
            Console.WriteLine("Speed: " + playerSpeed);
            Console.WriteLine("Agility: " + playerAgility);
            Console.WriteLine("Defense: " + playerDefense);
            Console.WriteLine("Intelligence: " + playerIntelligence);
            Console.WriteLine();
            Console.WriteLine("This is purgitory. If you want to find your way back to the land of the living, you must make hard decisions and fight for your second life.");
            Console.WriteLine();
            Console.WriteLine("Lives Remaining: " + playerSecondLife);
        }
    }
}
