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
            System.Console.WriteLine("4 - Histórico");
            System.Console.WriteLine("0 - Sair \n");
            System.Console.WriteLine("Digite uma opção: \n");

            ExecutarPrograma();

        }
        static void ExecutarPrograma() {

            var condition = true;

            while (condition) {

                int option = System.Convert.ToInt32(Console.ReadLine());

                Menu options = (Menu)option;

                condition = MenuOpcoes(options);

            }
        }
        static bool MenuOpcoes(Menu options) {

            var condition = true;

            switch (options) {
                case Menu.saldo:
                    decimal saldoValue;
                    Console.ForegroundColor = ConsoleColor.White;
                    BankAccount saldo = new BankAccount();
                    saldo.ConsultarSaldo(out saldoValue);
                    System.Console.WriteLine("\n\n ------ Saldo ------ \n");
                    System.Console.WriteLine($"Saldo: {saldoValue}");
                    break;
                case Menu.deposito:
                    decimal x;
                    BankAccount deposito = new BankAccount();
                    System.Console.WriteLine("\n\n ------ Depósito ------ \n");
                    deposito.Depositar(out x);
                    System.Console.WriteLine($"Você depositou: {x}");
                    break;
                case Menu.saque:
                    decimal y;
                    BankAccount saque = new BankAccount();
                    System.Console.WriteLine("\n\n ------ Saque ------ \n");
                    saque.Sacar(out y);
                    System.Console.WriteLine($"Você sacou: {y}");
                    break;
                case Menu.historico:
                    BankAccount historico = new BankAccount();
                    System.Console.WriteLine("\n\n ------ Extrato ------ \n");
                    System.Console.WriteLine($"{historico.Historico()}");
                    break;
                case Menu.sair:
                default:
                    condition = false;
                    System.Console.WriteLine("Saindo...");
                    break;
            }
            
            return condition;
        }

    }
    public class BankAccount {
        private decimal saldo, deposito, saque;
        private string extrato = "";
        public void ConsultarSaldo(out decimal saldo) {
            
            saldo = 0;
        }
        public void Depositar(out decimal x) {

            decimal value2;

            ConsultarSaldo(out value2);

            System.Console.WriteLine("Digite o valor para depósito: ");

            decimal value1 = Convert.ToDecimal(Console.ReadLine());

            x = value1 + value2;

            // Validação

            if (value1 < 0) {

                Console.ForegroundColor = ConsoleColor.Red;

                System.Console.WriteLine("Não pode enviar números negativos \n");
            }

        }
        public void Sacar(out decimal y) {

            System.Console.WriteLine("Digite o valor para sacar: ");
            
            y = Convert.ToDecimal(Console.ReadLine());

            // Validação

            if (y < 1) {

                Console.ForegroundColor = ConsoleColor.Red;

                System.Console.WriteLine("Saldo Insuficiente!");
            }
        }
        public string Historico() {

            System.Console.WriteLine(
            $"Depósito: {deposito}\n" +
            $"Saque: {saque}\n" +
            $"Saldo: {saldo}" );

            return extrato;

        }
    }

}
