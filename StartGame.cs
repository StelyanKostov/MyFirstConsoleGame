using System;

namespace Game
{
    public static class StartGame
    {
        public static void Start()
        {
            while (true)
            {
                
                OutPut.GamePlay();
                bool endGame = Controller.ControlPlayer();
                if (endGame)
                {
                    Environment.Exit(0);
                }
                Console.Clear();
                StatusGame.LostGame();
                StatusGame.WinGame();
            }
        }
    }
}
