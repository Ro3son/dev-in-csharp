
namespace ProjectBattleRobots
{
    public class RobotBattleHeavy : Robot
    {
        public RobotBattleHeavy(string nome, int pontos) : base(nome, pontos) { }
        public override int CausarDano()
        {
            int roboBatalhaPesadoCausaDano = 20;
            Console.WriteLine(roboBatalhaPesadoCausaDano);
            return roboBatalhaPesadoCausaDano;
        }
    }
}
