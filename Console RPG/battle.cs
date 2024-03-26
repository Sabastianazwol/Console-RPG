using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Console_RPG
{
    class battle : POI
    {
        public List<Enemy> enemies;


        public battle(List<Enemy> eniemies) : base(false)
        {
            this.enemies = enemies;

        }


        public override void Resolve(List<player> players)
        {
            while (true)
            {// run this code on each of the players
                foreach (var item in players)
                {
                    Console.WriteLine("It is" + item.name + "'s turn");
                    item.DoTurn(players, enemies);

                }


                foreach (var item in enemies)
                {
                    Console.WriteLine("It is" + item.name + "'s turn");
                    item.DoTurn(players, enemies);

                }

                //loseing 
                if (players.TrueForAll(player => player.currentHP <= 0))
                {
                    Console.WriteLine("one more will rest agian");
                    break;
                }
                //wo
                if (players.TrueForAll(Enemy => Enemy.currentHP <= 0))
                {
                    Console.WriteLine("you saved yourself by dooming another");
                    break;
                }
                Console.WriteLine("one story ends another contenues");
            }
        }








    }
}
