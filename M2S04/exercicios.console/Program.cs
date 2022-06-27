/* Ex 1, 2, 3, 4

Desenvolva uma abstração de uma lâmpada, a qual pode ser ligada e desligada. 
Também deve ser possível observar o estado da lâmpada (se desligada ou ligada).

Desenvolva um novo tipo de abstração para a lâmpada de forma a incluir as características de potência e voltagem. 
Garanta que seja possível tanto ler quanto alterar os valores de potência e voltagem de uma lâmpada. 
Essa nova classe deve ser usada como um tipo de uma propriedade da classe Lâmpada.

Desenvolva um programa para testar as classes desenvolvidas nos exercícios 1 e 2. 
Crie uma nova lâmpada, apresente no console as informações de estado (se ligada ou desligada, potência e voltagem), 
ligue a lâmpada e apresente novamente as informações de estado.

Modiﬁque a abstração da lâmpada criada anteriormente para incluir o caso de uma lâmpada queimar ao ser ligada. 
Sabe-se que existe uma chance de 15% da lâmpada queimar ao ser ligada. 
Dica: neste exercício é importante pesquisar na biblioteca de classes 
fornecida pela linguagem de programação uma classe que dê suporte à geração de números aleatórios.

*/

namespace Iluminacao {
   public class Lampada {
      private static bool ligada;
      private static bool estaQueimada;
      static void Main() {

         Lampada2 lampada = new Lampada2();

         lampada.Potencia = 9.8;
         lampada.Tensao = 127;

         Lampada.Ligar();

         Lampada.QueimouAoLigar();

         Console.WriteLine($"Potência da lâmpada: {lampada.Potencia} W");
         Console.WriteLine($"Tensão Elétrica: {lampada.Tensao} V");

      }
      public static void Ligar() {

         Console.WriteLine("Lâmpada Ligada!");

         ligada = true;

         while (ligada) {
            
            Console.WriteLine("Não se esqueça de desligar ao sair!");

            ligada = Convert.ToBoolean(Console.ReadLine());

         }

         Lampada.Desligar();
         
      }
      public static void Desligar() {

         ligada = false;

         Console.WriteLine("Desligada!\n");
         
      }
      public static void QueimouAoLigar() {

         Console.WriteLine("Lâmpada Ligada!");

         estaQueimada = true && false;

         Console.WriteLine("Queimou! Não se esqueça de trocar a lâmpada.\n");
         
      }
   
   }
   public class Lampada2 {
      public double Potencia { get; set; }
      public int Tensao { get; set; }

   }
   public class Lampada3 { }
}

// Random rnd = new Random();

// string[] lampada = { "Ligada", "Desligada", "Queimada" };

// for (int i = 0; i <= 4; i++) {

//     int mIndex = rnd.Next(lampada.Length); // Generate random indexes

//     Console.WriteLine("{0}", lampada[mIndex]);

// }

// Generate and display 5 random integers between 0 and 100.
// Console.WriteLine("Five random integers between 0 and 100:");
// for (int ctr = 0; ctr <= 4; ctr++)
//     Console.Write("{0,8:N0}", rand.Next(101));
// Console.WriteLine();

// public class Class1 {
//    public Class2 Obj { get; set; }
//    public Class1() {
//      Obj = new Class2();
//    }
//    static void Main() {

//     Class1 obj1 = new Class1();

//     obj1.Obj = new Class2();

//     obj1.Obj.Potencia = 100;

//     obj1.Obj.Tensao = 100;

//    }

// }
// public class Class2 {
//     public double Potencia { get; set; }
//     public int Tensao { get; set; }

// }