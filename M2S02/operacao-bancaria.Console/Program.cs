/*
Crie Menu (Adicionar uma cor para o texto do menu, valor inicial de saldo é 0)
- operações: consulta saldo, depósito, saque, histórico, sair.

Crie método de consulta de saldo e implemente a lógica necessária e o resultado esperado.

*/

class CalculadoraBancaria {
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

        executarPrograma();
    }
    static void executarPrograma() {
       
       var condition = true;

       while (condition) {

         int option = System.Convert.ToInt32(Console.ReadLine());

         Menu options = (Menu)option;

         condition = switchOptions(options);
         
       }
    }
    static bool switchOptions(Menu options) {

        var condition = true;

        switch(options) {
            case Menu.saldo:
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine("Saldo: ");
                break;
            case Menu.deposito:
                System.Console.WriteLine("Depositar: ");
                break;
            case Menu.saque:
                System.Console.WriteLine("Sacar: ");
                break;
            case Menu.historico:
                System.Console.WriteLine("Histórico: ");
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