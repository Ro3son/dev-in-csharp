
namespace ProjectBattleRobots
{
    public abstract class Robot
    {
        public string? NomeRobo { get; private set; }
        public int PontosVida { get;  protected set; }
        EStatus Status { get; set; }

        public Robot(string nome, int pontos)
        {
            NomeRobo = nome;
            PontosVida = pontos;
        }

        public void Iniciar()
        {
            Status = EStatus.Ligado;
            Console.WriteLine($"{Status}");
        }
        public void Parar()
        {
            Status = EStatus.Desligado;
            Console.WriteLine($"{Status}");
        }
        public abstract int CausarDano();
        public int ReduzirPontosVida(int dano)
        {
            PontosVida = PontosVida - dano;

            if (PontosVida == 0)
            {
                EStatus status = EStatus.Destruido;
                Console.WriteLine($"{status}");
            }
            return PontosVida;
        }
    }
}
