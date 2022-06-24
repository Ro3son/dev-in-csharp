/* Ex 1, 2

Desenvolva uma abstração de uma lâmpada, a qual pode ser ligada e desligada. 
Também deve ser possível observar o estado da lâmpada (se desligada ou ligada).

Desenvolva um novo tipo de abstração para a lâmpada de forma a incluir as características de potência e voltagem. 
Garanta que seja possível tanto ler quanto alterar os valores de potência e voltagem de uma lâmpada. 
Essa nova classe deve ser usada como um tipo de uma propriedade da classe Lâmpada.
*/
public class Lampada {
   bool ligada;
   public NovaAbstracao MyAbstraction { get; set; }
   public void Ligar() {
       ligada = true;
       System.Console.WriteLine("Ligada");
   }
   public void Desligar() {
       ligada = false;
       System.Console.WriteLine("Desligada");
   }
}
public class NovaAbstracao {
   private double potencia;
   private double tensao;
      public double Potencia { get; set; }
      public double Tensao { get; set; }
         public static void Main() {
         NovaAbstracao watts = new NovaAbstracao();
         watts.Potencia = 100;
         System.Console.WriteLine($"{watts.Potencia} W");

         NovaAbstracao volts = new NovaAbstracao();
         volts.Tensao = 120;
         System.Console.WriteLine($"{volts.Tensao} V");
      }
}
