
namespace Game
{
    public static class Trap
    {
        static private int counntTrap = Map.Lenght * 2;
        public static char Char { get; } = 'T';
        public static int HP { get; } = -20;
        public static bool ActiveTrap { get; set; } = false;

        public static void Create()
        {

            for (int i = 0; i < counntTrap; i++)
            {
                int rowTrap = RandomLocation.Create();
                int colTrap = RandomLocation.Create();
              
                if (Verificationn.Location(rowTrap, colTrap))
                {
                    Map.Data[rowTrap, colTrap] = Char;
                }
                else
                {
                    i--;
                }
            }
        }
        public static void Active()
        {
            ActiveTrap = true;
            Player.HP += HP;
        }
    }
}
