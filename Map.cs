using System;

namespace Game
{
    public static class Map
    {

        public static int Lenght { get; } = 21;       
        public static char TerrainMap { get; } = '-';
        public static char[,] Data { get; set; } = new char[Lenght, Lenght];
        public static void Create()
        {
            for (int row = 0; row < Lenght; row++)
            {
                for (int col = 0; col < Lenght; col++)
                {
                    Data[row, col] = TerrainMap;
                }
            }
        }
        public static void Show()
        {
            for (int row = 0; row < Lenght; row++)
            {
                for (int col = 0; col < Lenght; col++)
                {
                    Console.Write(" ");
                    Console.Write(Data[row, col]);
                }
                Console.WriteLine();
            }
        }


    }
}
