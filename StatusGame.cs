using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
   public static class StatusGame
    {
        public static int win { get; } = 2000;
        static public void LostGame()
        {
            if (Player.HP <= 0)
            {
                OutPut.Dead();
                Environment.Exit(0);
            }
        }
        static public void WinGame()
        {
            if (Player.Points >= win)
            {
                OutPut.WinGame();
                Environment.Exit(0);
            }
        }
    }
}
