/*

Crie Menu (Adicionar uma cor para o texto do menu, valor inicial de saldo é 0)
- operações: consulta saldo, depósito, saque, histórico, sair.

Crie método de consulta de saldo e implemente a lógica necessária e o resultado esperado.

*/

using System;

namespace BankingApplication {
    public class MenuBank {
        public enum Menu { sair, saldo, deposito, saque, historico }
        static void Main() {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            System.Console.WriteLine("\n\n ---------- Menu ----------\n");
            System.Console.WriteLine("1 - Consultar Saldo");
            System.Console.WriteLine("2 - Depositar");
            System.Console.WriteLine("3 - Sacar");
            System.Console.WriteLine("4 - Extrato");
            System.Console.WriteLine("0 - Sair \n");
            System.Console.WriteLine("Digite uma opção: \n");

            var condition = true;

            decimal x;
            
            decimal y;
 
            while (condition) {

                int option = Convert.ToInt32(Console.ReadLine());

                Menu options = (Menu)option;

                switch (options) {
                    case Menu.saldo:
                        decimal saldoValue;
                        Console.ForegroundColor = ConsoleColor.White;
                        System.Console.WriteLine("\n\n ------ Saldo ------ \n");
                        BankAccount saldo = new BankAccount();
                        saldo.ConsultarSaldo(out saldoValue);
                        System.Console.WriteLine($"Saldo: {saldoValue}\n");
                        break;
                    case Menu.deposito:
                        System.Console.WriteLine("\n\n ------ Depósito ------ \n");
                        System.Console.WriteLine("Digite o valor para depósito: ");
                        BankAccount deposito = new BankAccount();
                        deposito.Depositar(out x);
                        System.Console.WriteLine($"Saldo Atual: {x}\n");
                        break;
                    case Menu.saque:
                        System.Console.WriteLine("\n\n ------ Saque ------ \n");
                        System.Console.WriteLine("Digite o valor para sacar: ");
                        BankAccount saque = new BankAccount();
                        saque.Sacar(out y);
                        System.Console.WriteLine($"Você sacou: {y}\n");
                        break;
                    case Menu.historico:
                        BankAccount historico = new BankAccount();
                        System.Console.WriteLine("\n\n ------ Extrato ------ \n");
                        historico.Historico();
                        System.Console.WriteLine($"Depósito: {0}, Saque: {0}, Saldo: {0}");
                        break;
                    case Menu.sair:
                    default:
                        condition = false;
                        System.Console.WriteLine("Saindo...");
                        break;
                }
            
            }

        }

    }
    public class BankAccount {
        public void ConsultarSaldo(out decimal saldo) {
            
            saldo = 100.00m;

        }
        public void Depositar(out decimal x) {

            decimal value2;

            ConsultarSaldo(out value2);

            decimal value1 = Convert.ToDecimal(Console.ReadLine());

            x = value1 + value2;

            // Validação

            if (value1 < 0) {

                Console.ForegroundColor = ConsoleColor.Red;

                System.Console.WriteLine("Não pode enviar números negativos \n");
            }

        }
        public void Sacar(out decimal y) {

            y = Convert.ToDecimal(Console.ReadLine());

            // Validação

            if (y < 1) {

                Console.ForegroundColor = ConsoleColor.Red;

                System.Console.WriteLine("Saldo Insuficiente!");
            }
        }
        public void Historico() {

            var date = DateTime.Now;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            System.Console.WriteLine($"{date}");

        }
    }

}
