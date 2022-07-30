
namespace ProjectBattleRobots
{
    public class RobotBattleHeavy : Robot
    {
        public RobotBattleHeavy(string nome) : base(nome) { }
        public override int CausarDano()
        {
            int roboBatalhaPesadoCausaDano = 20;
            Console.WriteLine(roboBatalhaPesadoCausaDano);
            return roboBatalhaPesadoCausaDano;
        }
    }
}
