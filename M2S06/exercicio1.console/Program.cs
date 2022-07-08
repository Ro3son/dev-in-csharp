namespace BancoApp
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

            Console.WriteLine("\n ------ Meu Banco ------ ");

            Console.WriteLine($"Conta: {indexSelecionado}");

            Conta conta1 = new Conta("Robson", 100.00m);

            Console.WriteLine($"Olá, {conta1.Cliente}");

            Console.WriteLine("Digite uma opção: ");
            Console.WriteLine("1 - Saldo");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Depositar");
            Console.WriteLine("0 - Sair");


            var condicao = true;

            while (condicao)
            {

                int option = Convert.ToInt32(Console.ReadLine());

                Operacoes options = (Operacoes)option;

                switch (options)
                {
                    case Operacoes.Saldo:
                        Console.WriteLine(@$"Meu saldo: {conta1.MostrarSaldo()}");
                        break;
                    case Operacoes.Sacar:
                        Console.WriteLine("Digite valor para saque: ");
                        conta1.Sacar();
                        break;
                    case Operacoes.Depositar:
                        Console.WriteLine("Digite o valor depósito: ");
                        conta1.Depositar();
                        break;
                    default:
                        condicao = false;
                        System.Console.WriteLine("Saindo...");
                        break;
                }
            }
        }
    }
}
