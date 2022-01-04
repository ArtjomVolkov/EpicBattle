using System;

namespace EpicBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] heroes = { "Dominic Toretto", "IvanZolo2004", "Hog Rider", "Spange Bob" };
            string[] villains = { "Nekoglai", "Joker", "Buster", "Putin", "Vodka", "Evelon" };



            string randomHero = GetRandomCharacter(heroes);
            string randomVillains = GetRandomCharacter(villains);
            Console.WriteLine($"Your random hero is {randomHero}");
            Console.WriteLine($"Your random villain is {randomVillains}");

            string randomWeapon = GetWeapon();
            string randomWeapons = GetWeapon();
            Console.WriteLine($"Your weapon Hero {randomWeapon}");
            Console.WriteLine($"Your weapon Villain {randomWeapons}");
        }

        public static string GetRandomCharacter(string[] someArray)
        {

            return someArray[GetRandomIndexForArray(someArray)];
        }

        public static string GetWeapon()
        {
            string[] weapon = { "AWP", "Desert Eagle", "AK-47", "Knife", "Pen" };
            return weapon[GetRandomIndexForArray(weapon)];
        }
        public static int GetRandomIndexForArray(string[] someArray)
        {
            Random rnd = new Random();
            return rnd.Next(0, someArray.Length);
        }
    }
}
