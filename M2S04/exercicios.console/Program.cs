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
      public NovaLampada Lamp { get; set; }
      public Lampada() {
         Lamp = new NovaLampada();
      }
      static void Main() {

         Lampada lampada = new Lampada();

         lampada.Lamp = new NovaLampada();

         lampada.Lamp.Potencia = 9.8;
         lampada.Lamp.Tensao = 127;

         Lampada.Ligar();

         Console.WriteLine($"Potência da lâmpada: {lampada.Lamp.Potencia} W");
         Console.WriteLine($"Tensão Elétrica: {lampada.Lamp.Tensao} V");

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
   }
}
