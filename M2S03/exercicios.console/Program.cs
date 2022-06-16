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

}

