/*
Ex 7, 8, 9

Crie uma classe estática chamada MetodosDeExtensao.cs e 
crie um método de extensão para retornar um texto que represente o valor de um bool.
Exemplo: 
bool a = "false" a.*ImprimirMensagem()* // deve retornar "Falso" 
bool a = "true" a.*ImprimirMensagem()* // deve retornar "Verdadeiro"

Utilizando a classe anterior crie um método de extensão para multiplicar um inteiro (int).
O método deve receber um parâmetro do tipo inteiro.

Crie sobrecargas do método anterior como:
receber decimal ao invés de int
receber mais de 2 parâmetros
receber parâmetros opcionais

*/

using System;

namespace MetodosExtensao
{
    public static class MetodosDeExtensao
    {
        static void Main()
        {
            bool a = false;
            Console.WriteLine(a.ImprimirMensagem());
            bool b = true;
            Console.WriteLine(b.ImprimirMensagem());

            Console.WriteLine(Multiplicar(9, 9));
            Console.WriteLine(Multiplicar(9, 9.8m));
            Console.WriteLine(Multiplicar(5, 5.2m, 5.4m));
            Console.WriteLine(Multiplicar(2));

        }
        public static bool ImprimirMensagem(this bool mensagem)
        {
            return mensagem;
        }
        public static int Multiplicar(this int num1, int num2)
        {
            return num1 * num2;
        }
        public static decimal Multiplicar(this int num1, decimal num2) {
            return num1 * num2;
        }
        public static decimal Multiplicar(this int num1, decimal num2, decimal num3) {
            return num1 * num2 * num3;
        }
        public static decimal Multiplicar(this int num1, int num2 = 10, int num3 = 10, decimal num4 = 20.5m) {
            return num1 * num2 * num3 * num4;
        }
    }
}