/* Ex 5, 6

Faça uma classe Conta que contenha o nome do cliente, o número da conta e o saldo. 
Estes valores deverão ser informados no construtor da classe. 
Faça um método depositar e um método sacar para realizar o depósito e saque de valores da conta. 
Faça um método obterSaldo que retorne o saldo do cliente. Faça um método obterNumero que retorne o número da conta. 
Faça um método obterNomeCliente que retorna o nome do cliente titular da conta.

Desenvolva um programa para testar a classe Conta. 
O programa deverá criar 3 contas diferentes e realizar diversas operações de saque e depósito. 
Depois, o programa deverá emitir um relatório (no console) 
apresentando o número, o titular e o saldo atual de cada conta.

*/

using System;

namespace Banco
{
  public class Program
  {
    static void Main()
    {

      Conta conta1 = new Conta("Robson", 100310, 25.00m);

      Conta conta2 = new Conta("Iolanda", 345678, 100.000m);

      Conta conta3 = new Conta("Kamila", 123456, 120.000m);

      conta3.Depositar();

      conta3.Sacar();

      conta3.ObterSaldo();

      conta3.ObterNumero();

      conta3.ObterNomeCliente();

    }
  }
}
