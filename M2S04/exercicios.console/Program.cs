/* Ex 1, 2, 3

Desenvolva uma abstração de uma lâmpada, a qual pode ser ligada e desligada. 
Também deve ser possível observar o estado da lâmpada (se desligada ou ligada).

Desenvolva um novo tipo de abstração para a lâmpada de forma a incluir as características de potência e voltagem. 
Garanta que seja possível tanto ler quanto alterar os valores de potência e voltagem de uma lâmpada. 
Essa nova classe deve ser usada como um tipo de uma propriedade da classe Lâmpada.

Desenvolva um programa para testar as classes desenvolvidas nos exercícios 1 e 2. 
Crie uma nova lâmpada, apresente no console as informações de estado (se ligada ou desligada, potência e voltagem), 
ligue a lâmpada e apresente novamente as informações de estado.

*/

namespace Iluminacao {
   public class Lampada {
      private static bool ligada;
      static void Main() {

         Lampada2 lampada = new Lampada2();

         lampada.Potencia = 9.8;
         lampada.Tensao = 127;

         Console.WriteLine($"Potência da lâmpada: {lampada.Potencia} W");
         Console.WriteLine($"Tensão Elétrica: {lampada.Tensao} V");

         Ligar();
      }
      public static void Ligar() {
         Console.WriteLine("Acender a lâmpada? (true or false)");
         ligada = Convert.ToBoolean(Console.ReadLine());
         if (ligada) {
            Console.Write("Ligada");
         } else {
            Console.Write("Desligada");
         }
         
      }
      public void Desligar() {
         ligada = false;
      }
   }
   public class Lampada2 {
      public double Potencia { get; set; }
      public int Tensao { get; set; }

   }
   public class Lampada3 {

   }
}