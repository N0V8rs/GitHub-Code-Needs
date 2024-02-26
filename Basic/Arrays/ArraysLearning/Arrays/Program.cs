using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class WeaponSystem
    {
        private string[] weaponNames = { "Pistol", "Shotgun", "Assault Rifle" };
        private int[] weaponAmmo = { 5, 3, 15 };
        private int[] weaponMaxAmmo = { 10, 6, 30 };
        private int[] weaponPower = { 3, 5, 2 };
        private double[] weaponFireRate = { 1, 0.5, 3 }; // in shots per second
        private int currentWeaponIndex = 0;

        public void Fire()
        {
            if (weaponAmmo[currentWeaponIndex] > 0)
            {
                Console.WriteLine($"Firing {weaponNames[currentWeaponIndex]}! Damage: {weaponPower[currentWeaponIndex]}");
                weaponAmmo[currentWeaponIndex]--;
            }
            else
            {
                Console.WriteLine("Out of ammo! Reload!");
            }
        }

        public void Reload()
        {
            weaponAmmo[currentWeaponIndex] = weaponMaxAmmo[currentWeaponIndex];
            Console.WriteLine($"Reloaded {weaponNames[currentWeaponIndex]}. Ammo: {weaponAmmo[currentWeaponIndex]}");
        }
        public void PickUpAmmo(int[] ammoValues)
        {
            Random random = new Random();

            // Create a list of available weapon indices
            List<int> availableIndices = new List<int>();
            for (int i = 0; i < weaponNames.Length; i++)
            {
                availableIndices.Add(i);
            }

            // Loop three times (or any desired number of pickups)
            for (int i = 0; i < 1; i++) // Change 3 to the desired number of pickups
            {
                // If there are no available indices, break the loop
                if (availableIndices.Count == 0)
                {
                    Console.WriteLine("No more available weapons to pick up ammo for.");
                    break;
                }

                // Randomly select an index from the available indices
                int randomIndex = random.Next(0, availableIndices.Count);
                int randomWeaponIndex = availableIndices[randomIndex];

                // Get the ammo amount for the randomly selected weapon
                int ammoAmount = ammoValues[randomWeaponIndex];

                // Add the ammo amount to the current weapon's ammo count, ensuring it doesn't exceed the maximum capacity
                weaponAmmo[randomWeaponIndex] = Math.Min(weaponAmmo[randomWeaponIndex] + ammoAmount, weaponMaxAmmo[randomWeaponIndex]);

                // Print a message indicating the ammo pickup for the current weapon and its updated total ammo count
                Console.WriteLine($"Picked up {ammoAmount} ammo for {weaponNames[randomWeaponIndex]}. Total Ammo: {weaponAmmo[randomWeaponIndex]}");

                // Remove the picked index from the available indices to ensure each pickup is for a different gun
                availableIndices.RemoveAt(randomIndex);
            }
        }
        public void SwitchWeapon(int newWeaponIndex)
        {
            if (newWeaponIndex >= 0 && newWeaponIndex < weaponNames.Length)
            {
                currentWeaponIndex = newWeaponIndex;
                Console.WriteLine($"Switched to {weaponNames[currentWeaponIndex]}.");
            }
            else
            {
                Console.WriteLine("Invalid weapon selection.");
            }
        }

        public void ShowHUD()
        {
            Console.WriteLine($"Current Weapon: {weaponNames[currentWeaponIndex]}");
            Console.WriteLine($"Ammo Counts:");
            for (int i = 0; i < weaponNames.Length; i++)
            {
                Console.WriteLine($"{weaponNames[i]}: {weaponAmmo[i]} / {weaponMaxAmmo[i]}");
            }
            Console.ReadKey(true);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WeaponSystem weaponSystem = new WeaponSystem();
            int[] ammoValues = { 5, 3, 10 };

            weaponSystem.ShowHUD();
            weaponSystem.Fire();
            weaponSystem.Reload();
            weaponSystem.Fire();
            // Specify ammo pickup values for each weapon type
            weaponSystem.PickUpAmmo(ammoValues);
            weaponSystem.SwitchWeapon(1);
            weaponSystem.Fire();
            weaponSystem.ShowHUD();
            weaponSystem.SwitchWeapon(2);
            weaponSystem.Fire();
            weaponSystem.Fire();
            weaponSystem.Fire();
            weaponSystem.Fire();
            weaponSystem.Reload();
            weaponSystem.ShowHUD();
        }
    }
}

