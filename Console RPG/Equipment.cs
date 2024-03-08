﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{

    abstract class Equipment : Item
    {
        public float durability;
        public float weight;
        public float rarity;
        public bool isEquipped;

        protected Equipment(string name, string description, int shopPrice, int sellPrice, int maxAmount, float durability, float weight, float rarity) : base(name, description, shopPrice, sellPrice, maxAmount)
        {
            this.durability = durability;
            this.weight = weight;
            this.rarity = rarity;
            this.isEquipped = false;
        }







    }

    class Armor : Equipment
    {
        public int defense;


        public Armor(string name, string description, int shopPrice, int sellPrice, int maxAmount, float durability, float weight, int defense, float rarity) : base(name, description, shopPrice, sellPrice, maxAmount, durability, weight, rarity)
        {
            this.defense = defense;

        }

        public override void Use(Entity user, Entity target)
        {
            // Flip the value of whether or not it's equipped 
            this.isEquipped = !this.isEquipped;

            if (this.isEquipped)
            {
                // Increase the target's defense if they equip the item.
                target.stats.defense += this.defense;
            }

            else
            {
                // Decrease the target's defense if they unequip the item.
                target.stats.defense -= this.defense;
            }



        }
    }


    class Weapon : Equipment
    {
        public int damage;


        public Weapon(string name, string description, int shopPrice, int sellPrice, int maxAmount, float durability, float weight, int damage, float rarity) : base(name, description, shopPrice, sellPrice, maxAmount, durability, weight, rarity)
        {
            this.damage = damage;

        }

        public override void Use(Entity user, Entity target)
        {
            // Flip the value of whether or not it's equipped 
            this.isEquipped = !this.isEquipped;

            if (this.isEquipped)
            {
                // Increase the target's defense if they equip the item.
                target.stats.strength += this.damage;
            }

            else
            {
                // Decrease the target's defense if they unequip the item.
                target.stats.strength -= this.damage;
            }



        }
    }



}


    





      


   

       



         
