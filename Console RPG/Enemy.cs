using System.Collections.Generic;
using System;
using System.Linq;

namespace Console_RPG
{
    class Enemy : Entity
    {
        public int experienceDroppedOnDeath;

        public Enemy(string name, int hp, int mana, stats stats, int experienceDroppedOnDeath) : base(name, hp, mana, stats)
        {
            this.experienceDroppedOnDeath = experienceDroppedOnDeath;
        }

        public override Entity ChooseTarget(List<Entity> targets)
        {
            Random random = new Random();
            return targets[random.Next(targets.Count)];
        }


        public override void Attack(Entity target)
        {
            Console.WriteLine(this.name + " attacked " + target.name + " ! ");
        }

        public override void DoTurn(List<player> players, List<Enemy> enemies)
        {
            Entity target = ChooseTarget(players.Cast<Entity>().ToList());
            Attack(target);


        }
    }

}

