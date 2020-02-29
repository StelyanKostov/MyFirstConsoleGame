using System;

namespace Game
{
    static public class Player
    {       
        public static char Char { get; } = '@';
        public static int HP { get; set; } = 100;
        public static int Points { get; set; } = 0;
        public static int PlayerRow { get; set; }
      
        public static int PlayerCol { get; set; }
      
        static public void Create()
        {          
            PlayerRow = Math.Abs(Map.Lenght / 2);
            PlayerCol = Math.Abs(Map.Lenght / 2);
            PlacePlayerOnMap();
        }
        static public void PlacePlayerOnMap()
        {
            Map.Data[PlayerRow, PlayerCol] = Char;
        }       
    }
}
