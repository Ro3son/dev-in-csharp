/*
Dado que:
- Existe uma lista de alunos pré-definida com as seguintes propriedades (nome, nº chamada).
- Existe uma lista de disciplinas pré-definida com as seguintes propriedades (nome, quantidade avaliações).
- Deve ser criada uma nova lista das notas lançadas.

Crie um console application aplicando os conceitos de exceptions mostrados na aula que abstraia 
o funcionamento de um sistema para lançamento de notas de um professor.

O programa precisa ter três opções: lançar nota, listar turmas e visualizar boletim do aluno.
A aplicação precisa conter uma lista de alunos e uma lista de disciplinas pré-definidas (em memória).
No lançamento o programa deve permitir o usuário(professor) selecionar um aluno e uma disciplina 
para realizar o lançamento das notas. após isso, o programa deve solicitar a entrada de X valores
(de acordo com a quantidade de avaliações da disciplina), 
armazenar esses valores em uma nova entidade e calcular a média entre elas,
Na visualização do boletim o programa deve retornar no seguinte formato:
"
Nome: {Nome_Aluno}

// Para cada disciplina lançada:
Disciplina: {Nome disciplina}
Notas provas: {Notas provas}
Média: {Média}
".

Informativos extras:
- As notas lançadas devem possuir um valor de 0 a 10. Tratar via exception.
- Não deve ser possível visualizar as notas se não existir nenhuma lançamento. Tratar via exception.
- Não deve ser possível visualizar o boletim se nenhuma disciplina for lançada para o aluno. Tratar via exception.
*/

namespace LancamentoNotas
{
    public class Program
    {
        static void Main()
        {
            List<Alunos> alunos = new List<Alunos>
            {
                new Alunos("Agnaldo", 1),
                new Alunos("Bruno", 6),
                new Alunos("Pedro", 19),
                new Alunos("Robson", 22)
            };

            Console.WriteLine("Alunos --- nº chamada");

            foreach (Alunos aluno in alunos)
            {
                Console.WriteLine(@$"{aluno.NomeAluno}, {aluno.NumeroChamada}");
            }

            Console.Write("\n");

            List<Disciplinas> disciplinas = new List<Disciplinas>
            {
               new Disciplinas("Português", 2),
               new Disciplinas("Física", 2),
               new Disciplinas("Matemática", 2),
               new Disciplinas("Filosofia", 2)
            };

            Console.WriteLine("Disciplina --- nº Avaliações");

            foreach (Disciplinas disciplina in disciplinas)
            {
                Console.WriteLine(@$"{disciplina.NomeDisciplina}, {disciplina.QuantidadeAvaliações}");
            }

            Console.Write("\n");

            List<Notas> notas = new List<Notas>();
            
        }
    }
}
