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
    public class Conta
    {
        private string nomeCliente;
        private int numeroConta;
        private decimal saldoConta;
        private decimal deposito, saque;
        private decimal aposDeposito, aposSaque;
        public Conta(string nome, int conta, decimal saldo)
        {
            nomeCliente = nome;
            numeroConta = conta;
            saldoConta = saldo;
        }
        static void Main() {

            Conta conta = new Conta("Robson", 100310, 25.00m);

            Conta conta1 = new Conta("Iolanda", 345678, 100.000m);

            Console.WriteLine(conta.nomeCliente);

            conta.Depositar();

            conta.Sacar();

            conta.ObterSaldo();

            conta.ObterNumero();

            conta.ObterNomeCliente();

        }
        public void Depositar()
        {  
           Console.WriteLine("Digite o valor para depósito: ");
           deposito = Convert.ToDecimal(Console.ReadLine());
           Console.WriteLine($"Você depositou: {deposito} ");
           aposDeposito = (deposito + saldoConta);
           Console.WriteLine($"Saldo Atual: {aposDeposito} \n");
        }
        public void Sacar()
        {
           Console.WriteLine("Digite o valor para saque: ");
           saque = Convert.ToDecimal(Console.ReadLine());
           Console.WriteLine($"Você sacou: {saque} ");
           aposSaque = (aposDeposito - saque);
           Console.WriteLine($"Saldo Atual: {aposSaque} \n");
        }
        public void ObterSaldo()
        {
          Console.WriteLine($"Saldo: {aposSaque}");
        }
        public void ObterNumero()
        {
          Console.WriteLine($"Número da conta: {numeroConta}");
        }
        public void ObterNomeCliente()
        {
          Console.WriteLine($"Nome do cliente: {nomeCliente}");
        }
    }
}
