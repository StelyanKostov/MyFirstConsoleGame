using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Movement
    {
        public static void Up()
        {
            int newPosicionRow = Player.PlayerRow - 1;
            if (newPosicionRow < 0)
            {
                newPosicionRow = Map.Lenght - 1;
            }
            Action(newPosicionRow, Player.PlayerCol);
            NewLocationPlayer(newPosicionRow, "row");

        }
        public static void Down()
        {
            int newPosicionRow = Player.PlayerRow + 1;
            if (newPosicionRow == Map.Lenght)
            {
                newPosicionRow = 0;
            }
            Action(newPosicionRow, Player.PlayerCol);
            NewLocationPlayer(newPosicionRow, "row");

        }
        public static void Left()
        {
            int newPosicionCol = Player.PlayerCol - 1;
            if (newPosicionCol < 0)
            {
                newPosicionCol = Map.Lenght - 1; 
            }
            Action(Player.PlayerRow, newPosicionCol);

            NewLocationPlayer(newPosicionCol, "col");
        }
        public static void Right()
        {
            int newPosicionCol = Player.PlayerCol + 1;
            if (newPosicionCol == Map.Lenght)
            {
                newPosicionCol = 0;
            }
            Action(Player.PlayerRow, newPosicionCol);
            NewLocationPlayer(newPosicionCol, "col");          

        }
        public static void Action(int rowIndex , int colIndex)
        {
            char ch = Map.Data[rowIndex, colIndex];
            if (ch == Bonus.Char)
            {
                Bonus.Active();
            }
            else if (ch == Trap.Char)
            {
                Trap.Active();
            }
            else if (ch == Points.Char)
            {
                Points.Get();
            }
            else
            {
                Mine.Verification(rowIndex, colIndex);
            }

        }
        public static void NewLocationPlayer(int newLocation, string rowOrCol)
        {
            Map.Data[Player.PlayerRow, Player.PlayerCol] = Map.TerrainMap;
            switch (rowOrCol)
            {
                case "row":
                    Player.PlayerRow = newLocation;
                    break;
                case "col":
                    Player.PlayerCol = newLocation;
                    break;
            }
            Map.Data[Player.PlayerRow, Player.PlayerCol] = Player.Char;
        }


    }
}
