using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public static class Verificationn
    {
        public static bool Location(int rowIndexOnMine,int colIndexOnMine)
        {           
            bool dontHavePlayer = Map.Data[rowIndexOnMine, colIndexOnMine] != Player.Char;
            bool donthaveBonus = Map.Data[rowIndexOnMine, colIndexOnMine] != Bonus.Char;
            bool dontHaveTrap = Map.Data[rowIndexOnMine, colIndexOnMine] != Trap.Char;
            bool dontHavePoints = Map.Data[rowIndexOnMine, colIndexOnMine] != Points.Char;
            if (dontHavePlayer && donthaveBonus && dontHaveTrap && dontHavePoints)
            {
                return true;
            }
            return false;
        }
    }
}
