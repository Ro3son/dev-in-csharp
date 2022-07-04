
namespace ProjectBattleRobots
{
    class Program
    {
        static void Main()
        {
            RobotBattleHeavy robot1 = new RobotBattleHeavy("Bender", 100);
            
            RobotBattleLight robot2 = new RobotBattleLight("R2D2", 100);

            PartidaBatalha.Batalhar(robot1, robot2);
         
        }
    }
}

// Uma referência de objeto é necessária para o campo, 
// o método ou a propriedade "PartidaBatalha.Batalhar(Robot, Robot)" não estática
// Solução usar classe estática na classe PartidaBatalha.