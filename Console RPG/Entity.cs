 using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{

    struct Stats

    {
        public int strength;
        public int defense;
        public int speed;

        public Stats(int strength, int defense, int speed)
        {
            this.strength = strength;
            this.defense = defense;
            this.speed = speed;
        }
    }

    //Classes are useful for storing simple plane data
    abstract class Entity
    {
        public string name;

        public int currentHp, maxHP;
        public int currentMana, maxMana;

        public Stats stats;


        public Entity(string name, int hp, int mana, Stats stats)
        {
            this.name = name;
            this.currentHp = hp;
            this.maxHP = hp;
            this.currentMana = mana;
            this.maxMana = mana;
            this.stats = stats;
        }



        public abstract void DoTurn(List<Player> players, List<Enemy> enemies);
        public abstract Entity ChooseTarget(List<Entity> targets);
        public abstract void Attack(Entity target);


        public void UseItem(Item item, Entity target)
        {
            item.Use(this, target);
        }






    }


    
}
