using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    abstract class Item
    {

        public static HealthPostionItem potionI = new HealthPostionItem("Helth potion I", "", 0, 0, 0);
        public static HealthPostionItem potionII = new HealthPostionItem("Helth potion II", "", 0, 0, 0);
        public static HealthPostionItem potionIII = new HealthPostionItem("Helth potion III", "", 0, 0, 0);


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
        public int healAmount;

        public HealthPostionItem(string name, string description, int shopPrice, int maxAmount, int healAmount) : base(name, description, shopPrice, maxAmount)
        {
            this.healAmount = healAmount; 

        }

        public override void Use(Entity user, Entity target)
        {
            user.currentHp += this.healAmount;

        }











    }







}
 

   
   





 
  

