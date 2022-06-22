/*

Crie Menu (Adicionar uma cor para o texto do menu, valor inicial de saldo é 0)
- operações: consulta saldo, depósito, saque, histórico, sair.

Crie método de consulta de saldo e implemente a lógica necessária e o resultado esperado.

Crie método para depósito.
Validação: não pode enviar números negativos (mostrar em cor vermelha a mensagem da validação)

*/

using System;

namespace BankingApplication {
    public static class MenuBank {
        static decimal saldo, deposito, saque, saldoAposDeposito, saldoAposSaque;
        public enum Menu { sair, saldo, deposito, saque, extrato }
        static void Main() {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            System.Console.WriteLine("\n\n ---------- Menu ----------\n");
            System.Console.WriteLine("1 - Consultar Saldo");
            System.Console.WriteLine("2 - Depositar");
            System.Console.WriteLine("3 - Sacar");
            System.Console.WriteLine("4 - Extrato");
            System.Console.WriteLine("0 - Sair \n");
            System.Console.WriteLine("Digite uma opção: \n");
            Console.ResetColor();

            ExecutarPrograma();

        }
        public static void ExecutarPrograma() {

            var condition = true;

            while (condition) {

                int option = Convert.ToInt32(Console.ReadLine());

                Menu options = (Menu)option;

                Console.ForegroundColor = ConsoleColor.White;

                switch (options) {
                    case Menu.saldo:
                        System.Console.WriteLine("\n\n ------ Saldo ------ \n");
                        System.Console.WriteLine("Digite um valor para o saldo: ");
                        saldo = Convert.ToDecimal(Console.ReadLine());
                        System.Console.WriteLine($"Saldo: {BankAccount.ConsultarSaldo(saldo)}\n");
                        break;
                    case Menu.deposito:
                        System.Console.WriteLine("\n\n ------ Depósito ------ \n");
                        System.Console.WriteLine("Digite um valor para depósito: ");
                        deposito = Convert.ToDecimal(Console.ReadLine());
                        saldoAposDeposito = (BankAccount.ConsultarSaldo(saldo) + BankAccount.Depositar(deposito));

                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;

                        var validation = (deposito < 0) ?
                        "Não pode enviar números negativos" :
                        $"Você depositou {deposito}\n" + $"Saldo Atual: {saldoAposDeposito}";

                        System.Console.WriteLine($"{validation}");

                        Console.ResetColor();
                        Console.Write("\n");

                        break;
                    case Menu.saque:
                        System.Console.WriteLine("\n\n ------ Saque ------ \n");
                        System.Console.WriteLine("Digite um valor para saque: ");
                        saque = Convert.ToDecimal(Console.ReadLine());
                        saldoAposSaque = (BankAccount.Depositar(saldoAposDeposito) - BankAccount.Sacar(saque));

                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.White;

                        string validation2 = (saque == 0) ?
                        "Saldo Insuficiente!" : $"Você sacou: {saque}\n" + $"Saldo Atual: {saldoAposSaque}";

                        System.Console.WriteLine($"{validation2}");

                        Console.ResetColor();
                        Console.WriteLine("\n");

                        break;
                    case Menu.extrato:
                        System.Console.WriteLine("\n\n ------ Extrato ------ \n");
                        var date = DateTime.Now;
                        System.Console.WriteLine($"{date}");
                        System.Console.WriteLine($"Depósito: {deposito}, Saque: {saque}, Saldo: {saldoAposSaque}");
                        break;
                    case Menu.sair:
                    default:
                        condition = false;
                        System.Console.WriteLine("Saindo...");
                        break;
                }
                Console.ResetColor();
            }
        }

    }
    public static class BankAccount {
        public static decimal ConsultarSaldo(this decimal saldo) {
            return saldo;
        }
        public static decimal Depositar(this decimal deposito) {
            return deposito;
        }
        public static decimal Sacar(this decimal saque) {
            return saque;
        }
        public static string Extrato(this string extrato) {
            return extrato;
        }
    }

}
