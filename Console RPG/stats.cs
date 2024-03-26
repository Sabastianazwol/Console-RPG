namespace Console_RPG
{
    // struct are useful for storing simple plain data
    struct stats
    {
        public int Dexterity;
        public int Strength;
        public int Constitution;
        public int Mind;


        public stats(int dexterity, int strength, int constitution, int mind)
        {
            Dexterity = dexterity;
            Strength = strength;
            Constitution = constitution;
            Mind = mind;
        }
    }

}
