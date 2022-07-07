/*
Crie um console application aplicando os conceitos de exceptions mostrados na aula 
que abstraia o funcionamento de um caixa de banco com as seguintes características:
O programa deve possuir uma lista de contas pré-definidas, o usuário poderá escolher entre uma delas 
(através de um índice de opção por exemplo).
Na sequência, o programa deve apresentar as opções de operações para essa conta, sendo elas: 
mostrar saldo, sacar e depositar.
No fim de cada operação deve ser mostrado o valor atualizado do saldo.
A conta nesse contexto possui numero, saldo, limite de saque e um campo para determinar se ela está 
operacional ou não.

Informativos extras:
- Para fazer qualquer operação a conta precisa estar operacional.
- Para sacar uma conta precisa ter saldo suficiente com base no valor informado.
- Para realizar um saque o valor informado também deve ser inferior ao LimiteSaque da conta.
*/

using System.Collections.Generic;
using System.Linq;

namespace Banco
{
    public class Program
    {
        static void Main()
        {
            var contas = new List<int> { 1234, 5678, 91011 };

            Console.WriteLine("Escolha uma conta: ");

            foreach (var conta in contas)
            {
                Console.WriteLine($"{contas.IndexOf(conta)}: {conta}");
            }

            int i = Convert.ToInt32(Console.ReadLine());

            var indexSelecionado = contas.ElementAt(i);

            Console.WriteLine($"Conta: {indexSelecionado}");

            Console.WriteLine("\n ------ Conta ------ \n");

            Conta conta1 = new Conta();
            Console.WriteLine(@$"Nome: {conta1.Cliente} Saldo: {conta1.MostrarSaldo()}");
            Console.WriteLine(@$"{conta1.Sacar()}");
            Console.WriteLine(@$"{conta1.Depositar()}");

        }
    }
}