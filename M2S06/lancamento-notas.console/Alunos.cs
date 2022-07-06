
namespace LancamentoNotas
{
    public class Alunos
    {
        public string NomeAluno { get; set; }
        public int NumeroChamada { get; set; }

        public Alunos(string nome, int numChamada)
        {
            NomeAluno = nome;
            NumeroChamada = numChamada;
        }
    }
}
