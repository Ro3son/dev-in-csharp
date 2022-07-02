
namespace ProjectBattleRobots
{
    class Program
    {
        static void Main()
        {
            RobotBattleHeavy robot1 = new RobotBattleHeavy();
            robot1.NomeRobo = "Bender";
            robot1.PontosVida = 20;
           
            
            RobotBattleLight robot2 = new RobotBattleLight();
            robot2.NomeRobo = "R2D2";
            robot2.PontosVida = 40;
         

            Console.WriteLine(" ---------- Batalha Entre Robôs ---------- \n");

            Console.WriteLine(
                $"{robot1.NomeRobo} vs {robot2.NomeRobo} \n" +
                $"Pontos de Vida: \n {robot1.PontosVida} ----- {robot2.PontosVida} \n"
            );

            Console.WriteLine("Iniciar Partida? (s/n)");

            var iniciarPartida = Console.ReadLine();

            if (iniciarPartida == "s") {
                Console.WriteLine($"{robot1.NomeRobo}");
                robot1.Iniciar();
                Console.WriteLine($"{robot2.NomeRobo}");
                robot2.Iniciar();
                Console.WriteLine($"{robot2.NomeRobo} Ataca {robot1.NomeRobo}");
                robot2.CausarDano();
                Console.WriteLine($"{robot1.NomeRobo} Não fica parado e ataca {robot2.NomeRobo}");
                robot1.CausarDano();
                Console.WriteLine($"Pontos de Vida: \n {robot1.PontosVida} ----- {robot2.PontosVida} \n");
            }
        }
    }
}
