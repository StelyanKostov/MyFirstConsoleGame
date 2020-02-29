using System;

namespace Game
{
    public static class Controller
    {
        public static bool  ControlPlayer()
        {          
            string command = Console.ReadLine();
            Mine.ActiveMine = false;
            Bonus.ActiveBonus = false;
            Trap.ActiveTrap = false;
            Points.ActivePoints = false;
            switch (command)
            {
                case "w":
                    Movement.Up();
                    break;
                case "s":
                    Movement.Down();
                    break;
                case "a":
                    Movement.Left();
                    break;
                case "d":
                    Movement.Right();
                    break;
                case "exit":
                    OutPut.Exit();
                    return true;
            }
            return false;
        }
        public static void StartMenu()
        {
            var command = Console.ReadLine();           
            switch (command)
            {
                case "help":
                    OutPut.Help();
                    break;
                case "exit":
                    OutPut.Exit();
                    break;
            }
            Console.Clear();
        }
    }
}
