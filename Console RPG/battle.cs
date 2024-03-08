using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Console_RPG
{
    class Battle
    {
        public List<Enemy> enemies;
        public bool isresolved;

        public Battle(List<Enemy> enemies)
        {
            this.enemies = enemies;
            this.isresolved = false;
        }




        public void Resolve(List<Player> players)
        {
            while (true)
            {
                foreach (var player in players)
                {
                    if (player.currentHp > 0)
                    {
                        Console.WriteLine("It's " + player.name + "'s turn.");
                        player.DoTurn(players, enemies);
                    }

                }


                foreach (var enemies in enemies)
                {
                    if (enemies.currentHp > 0)
                    {
                        Console.WriteLine("It's " + enemies.name + "'s turn.");
                        enemies.DoTurn(players, this.enemies);
                    }
                    else
                    {
                        Console.WriteLine("Enemy can no longer continue fighting");
                    }


                }


                if (players.TrueForAll(player => player.currentHp <= 0))
                {
                    Console.WriteLine("");
                    break;
                }

                if (enemies.TrueForAll(enemy => enemy.currentHp <= 0))
                {
                    Console.WriteLine("");
                    //Other enemies stuff like drops, ect.
                    break;
                }



            }

            //Anything that happens no matter who wins

        }




    }
}
