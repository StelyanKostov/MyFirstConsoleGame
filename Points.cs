using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public static class Points
    {
        static private int counntPoints = Map.Lenght * 3;
        public static char Char { get; } = 'P';
        public static int Pointss { get; } = 100;
        public static bool ActivePoints { get; set; } = false;

        public static void Create()
        {
            for (int i = 0; i < counntPoints; i++)
            {
                int pointRow = RandomLocation.Create();
                int pointCol = RandomLocation.Create();
               
                if (Verificationn.Location(pointRow, pointCol))
                {
                    Map.Data[pointRow, pointCol] = Char;
                }
                else
                {
                    i--;
                }
            }
        }
        public static void Get()
        {
            ActivePoints = true;
            Player.Points += Pointss;
        }
    }
}
