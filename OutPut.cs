using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Game
{
    public static class OutPut
    {
        public static void Help()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine($"{Player.Char} - Stands for Player. The game always starts from the middle of the map.");
            str.AppendLine($"{Points.Char} - Stands for Points, one entry gives {Points.Pointss} points.");
            str.AppendLine($"{Mine.Char} - Stands for a Mine, which are hidden, the mine reduces the HP with {Math.Abs(Mine.HP)}.");
            str.AppendLine($"{Bonus.Char} - Stands for Bonus, it provides {Bonus.Points} points and {Bonus.HP} HP.");
            str.AppendLine($"{Trap.Char} - Stands for trap, it reduces the HP with {Math.Abs(Trap.HP)}.");
            str.AppendLine($"w - Moves one field up, after which you must type \"enter\" to complete the movement.");
            str.AppendLine($"s - Moves one field down, after which you must type \"enter\" to complete the movement.");
            str.AppendLine($"a - Moves one field left, after which you must type \"enter\" to complete the movement.");
            str.AppendLine($"d - Moves one field right, after which you must type \"enter\" to complete the movement.");
            str.AppendLine($"exit - Type it to go out of the game.");
            str.AppendLine($"Collect {StatusGame.win} point to win the game.");
            str.AppendLine($"If you get to 0 or less points you lose the game.");

            str.Remove(str.Length - 1, 1);
            Console.WriteLine(str);
            Console.ReadLine();
            Console.Clear();
        }
        public static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Thank you for playing!");
            Console.WriteLine("Good bye!");
        }
       
        public static void Dead()
        {
            Console.WriteLine("Sorry, you just died!");
            Console.WriteLine($"Your points are {Player.Points}.");
            Console.WriteLine("Game Over!");
        }
        public static void WinGame()
        {
            Console.WriteLine($"You have just won.\nYour points are {Player.Points}.");
        }
        public static void GamePlay()
        {
            Map.Show();
            Console.WriteLine($"Your points are {Player.Points}.");
            Console.WriteLine($"Your HP is {Player.HP}.");
            if (Mine.ActiveMine)
            {
                Console.WriteLine($"Oops, mine {Mine.HP} HP.");
            }
            else if (Points.ActivePoints)
            {
                Console.WriteLine($"Points + {Points.Pointss}.");
            }
            else if (Trap.ActiveTrap)
            {
                Console.WriteLine($"Oops, trap {Trap.HP} HP.");
            }
            else if (Bonus.ActiveBonus)
            {
                Console.WriteLine($"Points + {Bonus.Points} HP + {Bonus.HP}.");
            }
        }
        public static void Welcome()
        {
            Console.WriteLine("Welcome to the Game!");
            Console.WriteLine("Type \"help\" for more information.");
            Console.WriteLine("Press \"enter\" to start game.");
        }
    }
}
