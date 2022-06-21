﻿/*

Crie Menu (Adicionar uma cor para o texto do menu, valor inicial de saldo é 0)
- operações: consulta saldo, depósito, saque, histórico, sair.

Crie método de consulta de saldo e implemente a lógica necessária e o resultado esperado.

*/

using System;

namespace BankingApplication {
    public static class MenuBank {
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

            switch (options)
            {
                case Menu.saldo:
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Console.WriteLine("\n\n------ Saldo Atual ------ \n");
                    BankAccount.ConsultarSaldo();
                    break;
                case Menu.deposito:
                    System.Console.WriteLine("\n\n------ Depositar ------ \n");
                    BankAccount.Depositar();
                    break;
                case Menu.saque:
                    System.Console.WriteLine("\n\n ------ Sacar ------ \n");
                    BankAccount.Sacar();
                    break;
                case Menu.historico:
                    System.Console.WriteLine("\n\n ------- Histórico ------\n");
                    BankAccount.Historico();
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
    public static class BankAccount {
        public static void ConsultarSaldo() {
            
            decimal saldo = 0;

            System.Console.WriteLine($"Saldo: {saldo}");
        }
        public static void Depositar() {

            System.Console.WriteLine("Digite um valor para depositar: ");

            decimal deposito = Convert.ToDecimal(Console.ReadLine());

            System.Console.WriteLine($"Você depositou: {deposito}");

        }
        public static void Sacar() {

            System.Console.WriteLine("Digite o valor para sacar: ");
            
            decimal saque = Convert.ToDecimal(Console.ReadLine());

            System.Console.WriteLine($"Você sacou: {saque}");
        }
        public static void Historico() {

            decimal deposito = 300.20m;

            decimal saque = 50.00m;

            decimal saldo = 100.00m;

            decimal total = (saque - saldo);

            System.Console.WriteLine($"Depósito: {deposito}\n Saque: {saque}\n Saldo: {total}");
        }
    }

}
