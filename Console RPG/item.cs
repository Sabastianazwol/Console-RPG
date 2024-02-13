using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    abstract class Item
    {
        public int shopPrice;
        public int maxAmount;
        public string name;
        public string description;

        public Item(string name, string description, int shopPrice, int maxAmount)
        {
            this.name = name;
            this.description = description;
            this.shopPrice = shopPrice;
            this.maxAmount = maxAmount;
        }
        public abstract void Use(Entity user, Entity target);
    }

    class HealthPostionItem : Item
    {
        public int helthAmount;

        public HealthPostionItem(string name, string description, int shopPrice, int maxAmount, int helthAmount) : base(name, description, shopPrice, maxAmount)
        {
            this.helthAmount = helthAmount; 

        }

   
        
    }
}
 

   
   





 
  

