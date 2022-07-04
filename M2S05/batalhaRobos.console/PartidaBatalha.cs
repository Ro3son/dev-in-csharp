
namespace ProjectBattleRobots
{
    public static class PartidaBatalha
    {
        public static void Batalhar(Robot robot1, Robot robot2)
        {

            Console.WriteLine(" ---------- Batalha Entre Robôs ---------- \n");

            Console.WriteLine("Iniciar Partida? (s/n)");

            var iniciarPartida = Console.ReadLine();

            if (iniciarPartida == "s")
            {
                Console.WriteLine(
                   $"{robot1.NomeRobo} vs {robot2.NomeRobo} \n" +
                   $"Pontos de Vida: \n {robot1.PontosVida} ----- {robot2.PontosVida} \n"
               );

                Console.WriteLine($"{robot1.NomeRobo} ");
                robot1.Iniciar();
                Console.WriteLine($"{robot2.NomeRobo} ");
                robot2.Iniciar();
                Console.Write("\n");

                Console.WriteLine($"{robot2.NomeRobo} Ataca {robot1.NomeRobo}.");
                Console.WriteLine("Dano causado: ");
                robot1.ReduzirPontosVida(robot2.CausarDano());
                
                Console.WriteLine($"{robot1.NomeRobo} Ataca {robot2.NomeRobo}. \n");
                Console.WriteLine("Dano causado: ");
                robot2.ReduzirPontosVida(robot1.CausarDano());
                Console.WriteLine($"{robot1.NomeRobo} está aguardando...");
            }
        }
    }
}
