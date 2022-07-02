
namespace ProjectBattleRobots
{
    public abstract class Robot
    {
        public string? NomeRobo { get; set; }
        public int PontosVida { get; set; }
        EStatus Status { get; set; }
        
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
        public abstract void CausarDano();
        public void ReduzirPontosVida(int dano) {
            PontosVida = PontosVida - dano;

            if (PontosVida == 0) {
                EStatus status = EStatus.Destruido;
                Console.WriteLine($"{status}");
            }
        }
    }
}
