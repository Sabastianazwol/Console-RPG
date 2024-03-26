using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Console_RPG
{
    abstract class Equipment : Item
    {
        public float duralbility;
        public float weight;
        public float rarity;
        public bool isEquipped;
        protected Equipment(string name,
            string description,
            int shopPrice,
            int sellPrice,
            float duralbility,
            float weight,
            float rarity)
            : base(name, description, shopPrice, sellPrice)
        {
            this.duralbility = duralbility;
            this.weight = weight;
            this.rarity = rarity;
            this.isEquipped = false;
        }


        class Armor : Equipment
        {
            public int defense;
            public stats modier;

            public Armor(string name, string description, int shopPrice, int sellPrice, float duralbility, float weight, float rarity, int defense, stats modier) : base(name, description, shopPrice, sellPrice, duralbility, weight, rarity)
            {
                this.defense = defense;
            }

            public override void Use(Entity user, Entity target)
            {
                this.isEquipped = !this.isEquipped; // checks and changes if it equipped.

                if (this.isEquipped)
                {//increase the target's defense if they equip the item.
                    target.stats.Constitution += this.defense;
                }
                else
                {
                    // decrease the target's defense if they unequip the item.
                    target.stats.Constitution -= this.defense;
                }
            }
        }

        class weapon : Equipment
        {
            public int damage;
            public stats modier;

            public weapon(string name, string description, int shopPrice, int sellPrice, float duralbility, float weight, float rarity, int damge, stats modier) : base(name, description, shopPrice, sellPrice, duralbility, weight, rarity)
            {
                this.damage = damage;
            }

            public override void Use(Entity user, Entity target)
            {
                this.isEquipped = !this.isEquipped; // checks and changes if it equipped.

                if (this.isEquipped)
                {//increase the target's defense if they equip the item.
                    target.stats.Strength += this.damage;
                }
                else
                {
                    // decrease the target's defense if they unequip the item.
                    target.stats.Strength -= this.damage;
                }
            }
        }
    }
}
