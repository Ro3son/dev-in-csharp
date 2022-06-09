/* 
Calcular Salário do Funcionário
Entrada: O nome, ano de nascimento, salário do funcionário e a % de reajuste.
Saída: Mostrar o nome do funcionário, idade e o valor do salário já reajustado.
*/

// System.Console.WriteLine("Digite o nome do Funcionário: ");
// var nomeFuncionario = Console.ReadLine();

// System.Console.WriteLine("Digite o ano de Nascimento: ");

// int anoAtual = 2022;
// int anoNascimento = System.Convert.ToInt32(Console.ReadLine());

// int idadeFuncionario = (anoAtual - anoNascimento);

// System.Console.WriteLine("Digite o salário: ");
// var salarioFuncionario = System.Convert.ToDecimal(Console.ReadLine());

// System.Console.WriteLine("Digite a porcentagem: ");
// var porcentagem = System.Convert.ToDecimal(Console.ReadLine());

// decimal valorSalarioReajustado = (((porcentagem / 100) * salarioFuncionario) + salarioFuncionario);

// string salarioReajustado = valorSalarioReajustado.ToString("N2");

// System.Console.WriteLine(
//     $"Nome: {nomeFuncionario} Idade: {idadeFuncionario} Salário Reajustado: {salarioReajustado}");

/*
Calcular Média de Alunos
Entrada: notas de seis alunos.
Saída: Mostrar a média da nota da prova e o total de quantos tiveram
notas maior que 7; nota menor que 7, maior que 0 e notas igual a 0.
*/

double[] notas = new double[6] { 7.5, 6.5, 8.5, 6.8, 5.3, 9.2 };

var media = Math.Round(notas.Average());

System.Console.WriteLine($"A média das notas é: {media}");

var qtdAlunosNotaMaiorQueSete = 0;

// for (int i = 0; i < notas.Length; i++) {
//     if (notas[i] > 7.0) {
//         System.Console.WriteLine(notas[i]);
//     }
// }

foreach (double n in notas) {
    if (n > 7.0) System.Console.WriteLine(n);
}



// int qtdAlunosNotaMenorQueSete =  3;
// int qtdAlunosNotasMaiorQueZero = 6;
// int qtdAlunosNotaIgualAZero = 0;

System.Console.WriteLine("Quantos alunos tiveram nota maior que sete? " + qtdAlunosNotaMaiorQueSete);

// System.Console.WriteLine("Quantos alunos tiveram nota menor que sete? " + qtdAlunosNotaMenorQueSete);

// System.Console.WriteLine("Quantos alunos tiveram nota maior que zero? " + qtdAlunosNotasMaiorQueZero);

// System.Console.WriteLine("Quantos alunos tiveram nota igual a zero? " + qtdAlunosNotaIgualAZero);