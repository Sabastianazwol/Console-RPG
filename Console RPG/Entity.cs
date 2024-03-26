using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{

    // classes are useful for storing complex objects
    abstract class Entity
    {

        public stats stats;
        public string name;

        public int currentHP, maxHP;
        public int currentMana, maxMana;


        public Entity(string name, int hp, int mana, stats stats)
        {
            this.name = name;
            this.currentHP = hp;
            this.maxHP = hp;
            this.maxMana = mana;
            this.stats = stats;
        }
        public abstract Entity ChooseTarget(List<Entity> choices);

        public abstract void Attack(Entity target);
        public void UseItem(Item item, Entity target)
        {
            item.Use(this, target);
        }

        public abstract void DoTurn(List<player> players, List<Enemy> enemies);
    }
}
