using System.Collections.Generic;

namespace Game
{
    public static class Mine
    {
        private static Queue<int> data;
        static private int count = 25;
        public static int HP { get; } = -25;
        public static bool ActiveMine{get;set;} = false;
        public static char Char { get; } = 'M';
        public static void Create()
        {
            data = new Queue<int>();

            for (int i = 0; i < count; i++)
            {
                int rowMine = RandomLocation.Create();
                int colMine = RandomLocation.Create();           
                
                if (Verificationn.Location(rowMine, colMine))
                {
                    data.Enqueue(rowMine);
                    data.Enqueue(colMine);
                }
                else
                {
                    i--;
                }
            }
        }
        public static void Verification(int rowIndex, int colIndex)
        {
            for (int i = 0; i < count; i++)
            {
                int rowIndexMine = data.Dequeue();
                int colIndexMine = data.Dequeue();

                if (rowIndex == rowIndexMine && colIndexMine == colIndex)
                {
                    Active();
                }

                data.Enqueue(rowIndexMine);
                data.Enqueue(colIndexMine);
            }
        }

        public static void Active()
        {
            ActiveMine = true;          
            Player.HP += HP;
        }

    }
}
