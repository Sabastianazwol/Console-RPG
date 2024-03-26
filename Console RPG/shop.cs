using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Text;

namespace Console_RPG
{
    class Shop : POI
    {
        public string ownerName;
        public string shopName;
        public List<Item> items;

        public Shop(string ownerName, string shopName, List<Item> items) : base(false)
        {
            this.ownerName = ownerName;
            this.shopName = shopName;
            this.items = items;
        }
        public override void Resolve(List<player> players)
        {
            Console.WriteLine($"you made your way to {shopName}");
            while (true)
            {
                Console.WriteLine("what will you do");
                Console.WriteLine("BUY | SEll | STEAL | TALK | lEAVE");
                string userInput = Console.ReadLine();
                if (userInput == "BUY")
                {
                    Item item = ChooseItem(this.items);
                    player.CoinCount -= item.shopPrice;
                    player.Inventory.Add(item);

                    Console.WriteLine($"you traded you {item.name}");
                }
                else if (userInput == "SEll")
                {
                    Item item = ChooseItem(player.Inventory);
                    player.CoinCount += item.shopPrice;
                    player.Inventory.Remove(item);

                    Console.WriteLine($"you traded you {item.name}");
                }
                else if (userInput == "TALK")
                {
                    Console.WriteLine("mhhhhhhh....");
                }
                else if (userInput == "LEAVE")
                {
                    break;
                }
            }

            Console.WriteLine("bring more for me");



        }
        public Item ChooseItem(List<Item> choices)
        {
            Console.WriteLine("please pick the Item you buy");

            for (int i = 0; i < choices.Count; i++)
            {
                Console.WriteLine($"{i + 1} : {choices[i].name} (${choices[i].shopPrice}");
            }

            int index = Convert.ToInt32(Console.ReadLine());
            return choices[index - 1];

        }
    }
}
