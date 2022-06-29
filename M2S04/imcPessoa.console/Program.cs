/*
Implemente uma classe Pessoa que possua como atributos nome, idade, peso (em quilogramas) e altura (em metros). 
Faça com que os dados sejam inicializados através do construtor da classe. 
Implemente um método capaz de calcular o Índice de Massa Corporal (IMC). 
O cálculo é feito através da fórmula IMC = peso/altura². 
Adicionalmente, implemente um método que informa a faixa de categoria do IMC que a pessoa se encontra, 
utilizando a seguinte tabela:

IMC --- Categoria
< 18,5 --- Abaixo do peso
18,5 > 25 --- Peso normal
25 > --- Sobrepeso

*/

namespace IMC
{
    public class Pessoa
    {
        string nome;
        int idade;
        double peso;
        double altura;
        double imc;
        string resultado;
        public Pessoa()
        {
            nome = "Robson";
            idade = 31;
            peso = 65.00;
            altura = 1.70;
        }
        static void Main()
        {
            Pessoa aluno = new Pessoa();

            aluno.CalcularIMC();

            aluno.FaixaCategoriaIMC();

        }
        public void CalcularIMC()
        {
            imc = ((peso) / Math.Pow(altura, 2));

            resultado = imc.ToString("N2");

            Console.WriteLine($"Nome: {nome}, Idade: {idade}, IMC: {resultado}");

        }
        public void FaixaCategoriaIMC()
        {
            Console.WriteLine("\n ------ IMC - Categoria ------ \n");

            if (imc < 18.5)
            {
                Console.WriteLine("< 18,5 --- Abaixo do peso");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("18,5 > 25 --- Peso normal");
            }
            else if (imc > 25)
            {
                Console.WriteLine("25 > --- Sobrepeso");
            }

        }
    }
}
