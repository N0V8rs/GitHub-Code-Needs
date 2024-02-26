using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    // Classes in code, what it is and how to use it.
    // Classes are 
    // Classes will defaults to setting everything to private 
    // int health = private int in another class so you have to do public int health to share to other classes

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Classes");
            Console.WriteLine("What are Classes and how to use them.");
            Console.WriteLine();

            // Variables
            int score; // Declaration
            score = 0;
            Console.WriteLine("Score: " + score);

            // Array
            int[] ammo; // Declaration
            ammo = new int[5]; // Instantiation
            ammo[0] = 5;

            // Player character from Player.cs // Creating player instance
            Player player; // Declaration
            player = new Player(); // Instantiation
            player.health = 100;
            player.x = 0;
            player.y = 0;

            // Enemy from Enemy.cs // Creating an enemy instance
            Enemy bossEnemy;
            bossEnemy = new Enemy();
            Enemy smallEnemy;
            smallEnemy = new Enemy();

            //Enemy[] smallEnmeies; // Declaration
            //smallEnemies = new Enemy[100];
            //for (int i = 0; i < smallEnemies.Length; i++) 
            //{

            //}
            bossEnemy.health = 50;
            bossEnemy.x = 10;
            bossEnemy.y = 5;

            Console.WriteLine("Player Health: " + player.health);
            player.Heal(5);
            Console.WriteLine("Enemy Health: " + bossEnemy.health);
            Console.WriteLine();

            Console.WriteLine("Player postsion " + player.x   +  "X " + player.y + "Y");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
