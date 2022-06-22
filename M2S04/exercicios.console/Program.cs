/* Ex 1
Desenvolva uma abstração de uma lâmpada.

Desenvolva uma abstração de uma lâmpada, a qual pode ser ligada e desligada. 
Também deve ser possível observar o estado da lâmpada (se desligada ou ligada).
*/

public class Lampada {
    bool ligada;
    public void Ligar() {
       ligada = true;
    }
    public void Desligar() {
       ligada = false;

    }
}
