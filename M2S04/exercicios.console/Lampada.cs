namespace Iluminacao
{
    public class Lampada
    {
        private static bool ligada;
        private static bool queimada;
        public NovaLampada Lamp { get; set; }
        public Lampada()
        {
            Lamp = new NovaLampada();
        }
        public static void Ligar()
        {

            Console.WriteLine("Lâmpada Ligada!");

            ligada = true;

            while (ligada)
            {

                Console.WriteLine("Não se esqueça de desligar ao sair!");

                ligada = Convert.ToBoolean(Console.ReadLine());

            }

            Lampada.Desligar();

            Lampada.TestRandom();

        }
        public static void Desligar()
        {

            ligada = false;

            Console.WriteLine("Desligada!\n");

        }
        public static void TestRandom() {

            queimada = false;
        
            Random rnd = new Random();

            string[] lampada = { "Ligada", "Desligada", "Queimada" };

            for (int i = 0; i <= 3; i++) {

                int mIndex = rnd.Next(lampada.Length);

                Console.WriteLine("{0}", lampada[mIndex]);

            }
        }

    }

}
