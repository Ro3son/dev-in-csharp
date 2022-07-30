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
                    $"{robot1.NomeRobo} vs {robot2.NomeRobo} \n"
                        + $"Pontos de Vida: \n {robot1.PontosVida} ----- {robot2.PontosVida} \n"
                );

                Console.WriteLine($"{robot1.NomeRobo} ");
                robot1.Iniciar();
                Console.WriteLine($"{robot2.NomeRobo} ");
                robot2.Iniciar();
                Console.Write("\n");
                
                Atacar(robot1, robot2);
                
            }
        }
        public static void Atacar(Robot robo1, Robot robo2)
        {
            Random rnd = new Random();

            string[] atacante = { "Bender", "R2D2", "R2D2", "Bender" };

            for (int i = 0; i < 2; i++)
            {
                int mIndex = rnd.Next(atacante.Length);

                Console.WriteLine("Atacante 1: {0}", atacante[mIndex]);

                if (atacante[mIndex] == "Bender")
                {
                    Console.WriteLine("Atacante 2: R2D2");
                    Console.WriteLine("Dano causado: ");
                    robo1.ReduzirPontosVida(robo2.CausarDano());
                }
                else if (atacante[mIndex] == "R2D2")
                {
                    Console.WriteLine("Atacante 2: Bender");
                    Console.WriteLine("Dano causado: ");
                    robo2.ReduzirPontosVida(robo1.CausarDano());
                    Console.WriteLine($"{atacante[mIndex]} está aguardando...");
                }
            }
        }
    }
}
