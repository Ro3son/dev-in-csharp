
namespace ProjectBattleRobots
{
    public abstract class Robot
    {
        public string NomeRobo { get; set; }
        public int PontosVida { get; set; }
        public string Status { get; set; }
        
        public void Iniciar()
        {
            EStatus status = EStatus.Ligado;
        }
        public void Parar()
        {
            EStatus status = EStatus.Desligado;
        }
        public abstract void CausarDano();
        public void ReduzirPontosVida() {

        }
    }
}
