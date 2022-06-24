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

namespace Eletrica {
   public static class Lampada {
      
      // public NovaAbstracao MyAbstraction { get; set; }
      // public Lampada(NovaAbstracao MyAbstraction) {
      //    this.MyAbstraction = MyAbstraction;
      // }
      static void Main() {
     
         System.Console.WriteLine("Acender a lâmpada? (sim ou não)");
         
         LigadoDesligado();

         System.Console.WriteLine("Apagar a lâmpada? (SIM)");

         LigadoDesligado();

         NovaAbstracao.WattsAndVolts();
      
      }
      public static void LigadoDesligado() {

         var estaLigadoOuDesligado = Console.ReadLine();

         string ligadoOuDesligado = (estaLigadoOuDesligado == "sim") ?
            
            "Ligada! Não esqueça de desligar quando sair :)" : "Desligada";
         
         System.Console.WriteLine(ligadoOuDesligado);
      }
   }
   public class NovaAbstracao {
      public double Potencia { get; set; }
      public double Tensao { get; set; }
      public NovaAbstracao() {
         Potencia = 100;
         Tensao = 120;
      }
      public static void WattsAndVolts() {
         NovaAbstracao watts = new NovaAbstracao();
         System.Console.WriteLine($"{watts.Potencia} W");

         NovaAbstracao volts = new NovaAbstracao();
         System.Console.WriteLine($"{volts.Tensao} V");
      }
   }
}
