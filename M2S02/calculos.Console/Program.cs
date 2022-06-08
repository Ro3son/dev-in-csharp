/* 
Calcular Salário do Funcionário
Entrada: O nome, ano de nascimento, salário do funcionário e a % de reajuste.
Saída: Mostrar o nome do funcionário, idade e o valor do salário já reajustado.
*/

System.Console.WriteLine("Digite o nome do Funcionário: ");
var nomeFuncionario = Console.ReadLine();

System.Console.WriteLine("Digite o ano de Nascimento: ");

int anoAtual = 2022;
int anoNascimento = System.Convert.ToInt32(Console.ReadLine());

int idadeFuncionario = (anoAtual - anoNascimento);

System.Console.WriteLine("Digite o salário: ");
var salarioFuncionario = System.Convert.ToDecimal(Console.ReadLine());

System.Console.WriteLine("Digite a porcentagem: ");
var porcentagem = System.Convert.ToDecimal(Console.ReadLine());

decimal valorSalarioReajustado = (((porcentagem / 100) * salarioFuncionario) + salarioFuncionario);

string salarioReajustado = valorSalarioReajustado.ToString("N2");

System.Console.WriteLine(
    $"Nome: {nomeFuncionario} Idade: {idadeFuncionario} Salário Reajustado: {salarioReajustado}");
