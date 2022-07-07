namespace Banco
{
    public class Conta
    {
        public string Cliente { get; set; }
        public decimal Saldo { get; set; }
        public decimal Saque { get; set; }
        public decimal LimiteSaque { get; set; }

        public Conta()
        {
            Cliente = "Robson";
            Saldo = 20.5m;
            LimiteSaque = 1000m;
        }
        public decimal MostrarSaldo()
        {
            return Saldo;
        }
        public decimal Sacar()
        {
            Console.WriteLine("Digite o valor para saque: ");
            decimal saque = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Você sacou: {saque}");
            var subtracao = (Saldo - saque);
            return subtracao;
        }
        public decimal Depositar()
        {
            Console.WriteLine("Digite o valor depósito: ");
            decimal deposito = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Você depositou: {deposito}");
            var soma = (Saldo + deposito);
            return soma;
        }
    }
}