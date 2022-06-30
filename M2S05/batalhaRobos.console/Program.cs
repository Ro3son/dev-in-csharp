
namespace ProjectBattleRobots
{
    class Program
    {
        static void Main()
        {
            RobotBattleHeavy robot1 = new RobotBattleHeavy();
            robot1.NomeRobo = "RobotOne";
            Console.WriteLine($"Nome do Robô: {robot1.NomeRobo}");
            robot1.PontosVida = 20;
            Console.WriteLine($"Pontos de vida: {robot1.PontosVida}");
            robot1.Status = "Desligado";
            Console.WriteLine($"Status: {robot1.Status}");

            RobotBattleLight robot2 = new RobotBattleLight();
            robot2.NomeRobo = "RobotTwo";
            Console.WriteLine($"Nome do Robô: {robot2.NomeRobo}");
            robot2.PontosVida = 40;
            Console.WriteLine($"Pontos de vida: {robot2.PontosVida}");
            robot2.Status = "Desligado";
            Console.WriteLine($"Status: {robot2.Status}");
        }
    }
}
