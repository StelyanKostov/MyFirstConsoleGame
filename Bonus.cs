namespace Game
{
    public static class Bonus
    {
        private static int count = Map.Lenght * 2;
        public static char Char { get; } = 'B';
        public static int HP { get; } = 10;
        public static int Points { get; } = 200;

        public static bool ActiveBonus { get; set; } = false;
        public static void CreateBonus()
        {
            for (int i = 0; i < count; i++)
            {            
                int rowBonus = RandomLocation.Create();
                int colBonus = RandomLocation.Create();
                if (Verificationn.Location(rowBonus, colBonus))
                {
                    Map.Data[rowBonus, colBonus] = Char;
                }
                else
                {
                    i--;
                }
            }
        }
        public static void Active()
        {
            ActiveBonus = true;
            Player.HP += HP;
            Player.Points += 200;
        }
    }
}
