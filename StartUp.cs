
namespace Game
{
    class StartUp
    {
        static void Main(string[] args)
        {
            OutPut.Welcome();
            Controller.StartMenu();
            Map.Create();
            Player.Create();
            Bonus.CreateBonus();
            Points.Create();
            Trap.Create();
            Mine.Create();
            StartGame.Start();
           
        }
    }
}
