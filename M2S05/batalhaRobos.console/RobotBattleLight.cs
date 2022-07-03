
namespace ProjectBattleRobots
{
    public class RobotBattleLight : Robot
    {
        public RobotBattleLight(string nome, int pontos) : base(nome, pontos) { }
        public override int CausarDano()
        {
            int roboBatalhaLeveCausaDano = 10;
            Console.WriteLine(roboBatalhaLeveCausaDano);
            return roboBatalhaLeveCausaDano;
        }
    }
}
