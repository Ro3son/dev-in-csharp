namespace LancamentoNotas
{
    public class Disciplinas
    {
        public string NomeDisciplina { get; set; }
        public int QuantidadeAvaliações { get; set; }

        public Disciplinas(string disciplina, int avaliacoes)
        {
            NomeDisciplina = disciplina;
            QuantidadeAvaliações = avaliacoes;
        }

    }
}
