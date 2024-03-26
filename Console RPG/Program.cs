using System;
using System.Numerics;

namespace Console_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("in a land groaning with the sins of the ages finally the it has drawn it's last breath");
            Console.WriteLine("It has suffocated under this pain.");
            Console.WriteLine("while the world has found peace from it's suffering, you have not.");
            Console.WriteLine("what where you before before the lands went silent.");
            Console.WriteLine("|FIGHTER| |MAGE| |CLERIC|");
            player player1 = new player("josh", 10, 10, new stats(10, 10, 10, 10), 1, "fighter");
            player1.ClassPick();


            HealthPotionItem potion1 = new HealthPotionItem("Potion 1", "the last of life store for a another time or wasted by man", 10, 10, 20);



        }
    }
}
