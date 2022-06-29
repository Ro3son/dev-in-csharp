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

        }
        public static bool ImprimirMensagem(this bool mensagem)
        {
            return mensagem;
        }
        public static int Multiplicar(this int num1, int num2)
        {
            return num1 * num2;
        }
    }
}