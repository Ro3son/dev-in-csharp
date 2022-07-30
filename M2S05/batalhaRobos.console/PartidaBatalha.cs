namespace ProjectBattleRobots
{
    public static class PartidaBatalha
    {
        public static void Batalhar(Robot robot1, Robot robot2)
        {
            StartBattle(robot1, robot2);
            RandomAttack(robot1, robot2);
        }

        public static void StartBattle(Robot robo1, Robot robo2)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" ---------- Batalha Entre Robôs ---------- \n");
            Console.ResetColor();

            Console.WriteLine("Iniciar Partida? (s/n)");

            var iniciarPartida = Console.ReadLine();

            if (iniciarPartida == "s")
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("\n ======= \n");
                Console.WriteLine(
                    $"{robo1.NomeRobo} vs {robo2.NomeRobo} \n"
                        + $"Pontos de Vida: \n {robo1.PontosVida} ----- {robo2.PontosVida} "
                );
                Console.Write("\n ======= \n");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("\n ======= \n");
                Console.WriteLine($"{robo1.NomeRobo} ");
                robo1.Iniciar();
                Console.WriteLine($"{robo2.NomeRobo} ");
                robo2.Iniciar();
                Console.Write("\n ======= \n");
                Console.ResetColor();
            }
        }

        public static void RandomAttack(Robot robo1, Robot robo2)
        {
            Random rnd = new Random();

            string[] atacante = { "Bender", "R2D2", "R2D2", "Bender" };

            for (int i = 0; i < 15; i++)
            {
                int mIndex = rnd.Next(atacante.Length);

                Console.WriteLine($"\n ---- Atacante 1: {atacante[mIndex]} ---- \n");

                if (atacante[mIndex] == "Bender")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Robô atacado: {robo2.NomeRobo}, Dano causado: ");
                    Console.WriteLine(
                        $"Pontos Vida (R2D2): {robo2.ReduzirPontosVida(robo1.CausarDano())}"
                    );
                    Console.ResetColor();
                }
                else if (atacante[mIndex] == "R2D2")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Robô atacado: {robo1.NomeRobo}, Dano causado: ");
                    Console.WriteLine(
                        $"Pontos Vida (Bender): {robo1.ReduzirPontosVida(robo2.CausarDano())}"
                    );
                    Console.ResetColor();
                }
            }
        }
    }
}
