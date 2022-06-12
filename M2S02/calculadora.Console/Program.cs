/*
Criar uma aplicação de console para simular de maneira simples uma calculadora.
Entrada: Receber dois valores, Informação de Operação.
Saída: Baseado nos valores e a operação mostrar o valor.
Ter uma opção no menu para parar a aplicação, 
senão enquanto isso, após o resultado mostra para selecionar a outra operação.

3. Crie um menu para escolher a operação Adição, Subtração, Multiplicação, Divisão 
e uma opção SAIR para interromper o programa.
- Listar opções junto com o caractere de seleção.

4. Receber informação de operação e Informar dois números
- Receber a opção e ir para a validação selecionada
- Receber dois valores
- Enquanto o caractere da opção SAIR não for selecionada deve continuar a escolha da operação após o resultado.

5. Criar métodos para cada operação, recebendo por parâmetro os dois valores e 
retornando o resultado dessa operação. 
- deve mostrar o resultado do processamento baseado nas entradas e a operação informada.
*/
class Calculator { 
    static void Main() {

        System.Console.WriteLine("\n\n --------- Calculadora ---------- \n");
        System.Console.WriteLine("+ Adição");
        System.Console.WriteLine("- Subtração");
        System.Console.WriteLine("* Multiplicação");
        System.Console.WriteLine("/ Divisão\n");

        ExecuteProgramWhile();
        
    }
    static void ExecuteProgramWhile() {
    
        var option = "";

        while (option != "S") {
            MenuOperators();
            option = Console.ReadLine();
        }
    }
    static void MenuOperators() {

       System.Console.WriteLine("Escolha um operador: ");

       char options;
       bool value;

       value = Char.TryParse(Console.ReadLine(), out options);

        switch (options) {
            case '+':
                System.Console.WriteLine("Adição");
                Somar();
                break;
            case '-':
                System.Console.WriteLine("Subtração");
                Subtrair();
                break;
            case '*':
                System.Console.WriteLine("Multiplicação");
                Multiplicar();
                break;
            case '/':
                System.Console.WriteLine("Divisão");
                Dividir();
                break;
            case 'S':
                System.Console.WriteLine("Sair");
                break;
            default:
            System.Console.WriteLine("Opção Inválida");
            break;
        }

    }
    static void Somar() {
        
        System.Console.WriteLine("Digite o primeiro número: ");

        int number1 = System.Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Digite o segundo número: ");

        int number2 = System.Convert.ToInt32(Console.ReadLine());

        int soma = (number1 + number2);

        System.Console.WriteLine($"O resultado é: {number1} + {number2} = {soma} ");
    }
    static void Subtrair() {

        System.Console.WriteLine("Digite o primeiro número: ");

        int number1 = System.Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Digite o segundo número: ");

        int number2 = System.Convert.ToInt32(Console.ReadLine());

        int subtrai = (number1 - number2);

        System.Console.WriteLine($"O resultado é: {number1} - {number2} = {subtrai} ");
    }
    static void Dividir() {

        System.Console.WriteLine("Digite o primeiro número: ");

        int number1 = System.Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Digite o segundo número: ");

        int number2 = System.Convert.ToInt32(Console.ReadLine());

        int divide = (number1 / number2);

        System.Console.WriteLine($"O resultado é: {number1} / {number2} = {divide} ");
    }
    static void Multiplicar() {

        System.Console.WriteLine("Digite o primeiro número: ");

        int number1 = System.Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Digite o segundo número: ");

        int number2 = System.Convert.ToInt32(Console.ReadLine());

        int multiplica = (number1 * number2);

        System.Console.WriteLine($"O resultado é: {number1} * {number2} = {multiplica} ");
    }

}
