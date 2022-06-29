/* Ex 5

Faça uma classe Conta que contenha o nome do cliente, o número da conta e o saldo. 
Estes valores deverão ser informados no construtor da classe. 
Faça um método depositar e um método sacar para realizar o depósito e saque de valores da conta. 
Faça um método obterSaldo que retorne o saldo do cliente. Faça um método obterNumero que retorne o número da conta. 
Faça um método obterNomeCliente que retorna o nome do cliente titular da conta.

*/

using System;

namespace Banco
{
  public class Program
  {
    static void Main()
    {

      Conta conta = new Conta("Robson", 100310, 25.00m);

      Conta conta1 = new Conta("Iolanda", 345678, 100.000m);

      conta.Depositar();

      conta.Sacar();

      conta.ObterSaldo();

      conta.ObterNumero();

      conta.ObterNomeCliente();

    }
  }
}
