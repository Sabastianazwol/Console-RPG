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
        public abstract Entity ChooseTraget(List<Entity> trgets);
        public abstract void Attact(Entity trget);


    }


    class Player : Entity
    {
        public int level;

        public Player(string name, int hp, int mana, Stats stats, int level) : base(name, hp, mana, stats)
        {
            this.level = level;
        }

        public override Entity ChooseTraget(List<Entity> trgets)
        {
            throw new NotImplementedException();
        }

        public override void Attact(Entity trget)
        {
            throw new NotImplementedException();
        }
    }
    class enemy : Entity
    {
        public int coinsDroppedOnDefeated;
        public int level;

        public enemy(string name, int hp, int mana, Stats stats, int level) : base(name, hp, mana, stats)
        {
            this.level = level;
        }
        public override Entity ChooseTraget(List<Entity> trgets)
        {
            throw new NotImplementedException();

        }
        public override void Attact(Entity trget)
        {
            throw new NotImplementedException();
        }
    }
}
