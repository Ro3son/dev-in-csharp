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
   public static class Lampada {
      private static string tipoDeLampada = "LED";
      static void Main() {
         
         LigadoDesligado();

         System.Console.WriteLine("\n ------ Característica ------ \n");

         System.Console.WriteLine($"Tipo de Lâmpada: {tipoDeLampada}");

         NovaAbstracao.Unidades();
      
      }
      public static void LigadoDesligado() {

         Console.WriteLine("Acender a lâmpada? (sim ou não)");

         var estaLigada = Console.ReadLine();

         if (estaLigada == "sim") {
         
         Console.Write("Ligada! Não esqueça de desligar quando sair :)\n");

         Console.Write("Apagar a lâmpada? (SIM)\n");
           
         var apagarLampada = Console.ReadLine();

         string apaga = (apagarLampada == "SIM") ? "Desligada" : "Ligada";

         System.Console.WriteLine(apaga);

         }
      }
      public class NovaAbstracao {
         private double potencia = 9.8;
         private string tensao = "Bivolt";
         private int lumen = 1100;
         public double Potencia { get; set; }
         public string Tensao { get; set; }
         public int Lumen { get; set; }
         public NovaAbstracao() {
            Potencia = potencia;
            Tensao = tensao;
            Lumen = lumen;
         }
         public static void Unidades() {
            NovaAbstracao watts = new NovaAbstracao();
            System.Console.WriteLine($"Potência da Lâmpada: {watts.Potencia} W");

            NovaAbstracao volts = new NovaAbstracao();
            System.Console.WriteLine($"Tensão Elétrica: {volts.Tensao} ");

            NovaAbstracao lumens = new NovaAbstracao();
            System.Console.WriteLine($"Quanto Ilumina: {lumens.Lumen} lm");
         }
      }
   }
}
