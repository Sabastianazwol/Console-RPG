using System;

namespace Console_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("player", 600, 400, new Stats(100, 800, 700), 400);
            Enemy batman = new Enemy("batman", 80, 40, new Stats(20, 28, 27), 10);
            Enemy drek = new Enemy("drek", 6, 4, new Stats(10, 8, 7), 3);


           

            Location bedroom;
        }
    }
}
