using System;

namespace Console_RPG
{
    class BombItem : Item
    {

        public int blastdamge;

        public BombItem(string name, string description, int shopPrice, int sellPrice, int blastdamage) : base(name, description, shopPrice, sellPrice)
        {
            this.blastdamge = blastdamage;

        }
        public override void Use(Entity user, Entity target)
        {
            target.currentHP -= this.blastdamge;
            Console.WriteLine(target.name + "was hit with the blast");
        }
    }

}
