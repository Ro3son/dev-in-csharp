namespace Banco
{
    public class Conta
    {
        public string Cliente { get; set; }
        public decimal Saldo { get; set; }
        public decimal Saque { get; set; }
        public decimal SaldoAposSaque { get; set; }
        public decimal Deposito { get; set; }
        public decimal SaldoAposDeposito { get; set; }
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
        public void Sacar()
        {
            Saque = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Você sacou: {Saque}");
            SaldoAposSaque = (Saldo - Saque);
            Console.WriteLine($"{SaldoAposSaque}");
        }
        public void Depositar()
        {
            Deposito = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Você depositou: {Deposito}");
            SaldoAposDeposito = (SaldoAposSaque + Deposito);
            Console.WriteLine($"{SaldoAposDeposito}");
        }
    }
}