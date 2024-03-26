using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_RPG
{
    class player : Entity
    {

        public static List<Item> Inventory = new List<Item>();
        public static int CoinCount = 0;
        public int level;
        public string CharClass;
        public player(string name, int hp, int mana, stats stats, int level, string CharClass) : base(name, hp, mana, stats)
        {
            this.level = level;
            this.CharClass = CharClass;
        }

        public override Entity ChooseTarget(List<Entity> choices)
        {
            Console.WriteLine("please pick entity to target");

            for (int i = 0; i < choices.Count; i++)
            {
                Console.WriteLine((choices[i]).name);
            }

            int index = Convert.ToInt32(Console.ReadLine());
            return choices[index - 1];

        }
        public Item ChooseItem(List<Item> choices)
        {
            Console.WriteLine("please pick the Item you use");

            for (int i = 0; i < choices.Count; i++)
            {
                Console.WriteLine((choices[i]).name);
            }

            int index = Convert.ToInt32(Console.ReadLine());
            return choices[index - 1];

        }



        public override void Attack(Entity target)
        {
            Console.WriteLine(this.name + "attacked" + target.name + "!");
        }



        public void ClassPick()
        {// Player picks From SPIDERMAN ,DEREK ,ZELDA
            CharClass = Console.ReadLine();
            if (CharClass == "SPIDERMAN")
            {
                CharClass = "SPDERMAN";
                Console.WriteLine("YOU HAVE TRIANED AND COULD NOT KEEP UP");
                new stats();

            }
            else if (CharClass == "DEREK ")
            {
                CharClass = "DEREK";
                Console.WriteLine(" HAS NO POWER CANT BATTLE HIM,");
            }
            else if (CharClass == "ZELDA")
            {
                CharClass = "ZELDA";
                Console.WriteLine("ZELDA RULER OF THE WORLD CAN BATTLE HIM TO STRONG.");
            }
            else
            {
                Console.WriteLine("Life cant be unlived, choose your past");
                Console.WriteLine("|SPIDERMAN| |DEREK| |ZELDA|");
            }
            ClassPick();
        }

        public override void DoTurn(List<player> players, List<Enemy> enemies)
        {
            Console.WriteLine("move forward in life");
            Console.WriteLine("ATTACK | ITEM");
            string choice = Console.ReadLine();


            if (choice == "ATTACK")
            {
                Entity target = ChooseTarget(enemies.Cast<Entity>().ToList());
                Attack(target);

            }
            else if (choice == "ITEM")
            {
                Item item = ChooseItem(Inventory);
                Entity target = ChooseTarget(players.Cast<Entity>().ToList());
                item.Use(this, target);
                Inventory.Remove(item);
            }

        }






    }

}




