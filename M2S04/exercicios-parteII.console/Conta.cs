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
        public void Depositar()
        {
            Console.WriteLine("Digite o valor para depósito: ");
            deposito = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Você depositou: {deposito} ");
            aposDeposito = (deposito + saldoConta);
            Console.WriteLine($"Saldo: {aposDeposito} \n");
        }
        public void Sacar()
        {
            Console.WriteLine("Digite o valor para saque: ");
            saque = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Você sacou: {saque} ");
            aposSaque = (aposDeposito - saque);
            Console.WriteLine($"Saldo: {aposSaque} \n");
        }
        public void ObterSaldo()
        {
            Console.WriteLine($"Saldo Atual: {aposSaque}");
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