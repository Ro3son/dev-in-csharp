// Ex 1 - Defina uma classe e seus objetos.
/*
Entrada: o nome, ano de nascimento, salário do funcionário e a % de reajuste.
Saída: deve mostrar o nome do funcionário, idade e o valor do salário já calculado com o reajuste.
*/

using System;

namespace ex01 {
    public class Funcionario {

        // Fields
        private string nome;
        private int anoDeNascimento;
        private decimal salario, reajuste;

        // Constructor
        public Funcionario(string nome, int anoDeNascimento, decimal salario, decimal reajuste) {

            this.nome = nome;

            this.anoDeNascimento = anoDeNascimento;

            this.salario = salario;

            this.reajuste = reajuste;

        }
        static void Main() {

            Funcionario funcionario = new Funcionario("Robson", 1991, 2540.25m, 20.5m);

            int idadeFuncionario = (2022 - funcionario.anoDeNascimento);

            decimal salarioReajustado = (((funcionario.reajuste / 100) * funcionario.salario) + funcionario.salario);

            salarioReajustado = Math.Round(salarioReajustado, 2);

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            System.Console.WriteLine(
             $"Nome do funcionário: {funcionario.nome}, " +
             $"Idade do funcionário: {idadeFuncionario} anos. \n" +
             $"Salário Reajustado: {salarioReajustado}");
        }
    }
}

// Ex 2 - Crie uma classe "Pessoa" com seus atributos
// Ex 3 - Crie um método para calcular a idade da Pessoa

public class Pessoa {
    string nome;
    int anoDeNascimento;
    double altura;
    double peso;

    public Pessoa(string nome, int anoDeNascimento, double altura, double peso) {

        this.nome = nome;

        this.anoDeNascimento = anoDeNascimento;

        this.altura = altura;

        this.peso = peso;
    }
    
    static void Main() {
      Pessoa idade = new Pessoa("", 1991, 1.70, 65.0);
      idade.IdadePessoa();
    }
    public void IdadePessoa() {
      int anoAtual = 2022;
      int idade = (anoAtual - anoDeNascimento);
      System.Console.WriteLine($"A idade atual é {idade} anos.");
    }
}

// Ex 4 - Defina o que é uma atributo.
// Resposta: Um atributo é uma instância de uma classe.

// Ex 5 - Qual a diferença entre uma propriedade privada e pública?
// Resposta: A propriedade privada só pode ser acessada pela classe a qual pertence.
// A propriedade pública pode ser acessada por todas as classes da aplicação;

// Ex 6 - Se você criar 5 objetos de uma classe, quantas vezes o construtor da classe será chamado?
// Resposta: Apenas uma vez

// Ex 7 - Por que você usa um construtor?
// Resposta: Para obter valores iniciais.
// Quando quero definir um construtor adicional e pegar diferentes argumentos.

// Ex 8 - Quando o construtor de uma classe é chamado?
//Resposta: A qualquer hora que uma instância de uma classe é criada.