// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Seu nome.");

// var nome = Console.ReadLine();

// Console.WriteLine($"Olá, {nome}");

// var umaString = "string";
// var numeroInt = 5;
// var numeroFloat = 5.4f;
// var numeroDouble = 5.4;
// var numeroDecimal = 5.4m;
// var array = new int[3] { 1, 2, 3 };
// var caractere = 'a';
// var date = new DateTime(2002, 13, 4);

// Console.WriteLine("Digite uma opção de 1 a 3");
// var opcao = Console.ReadLine();

// if (opcao == "1")
// {
//     Console.WriteLine("Menu de cadastro");
// }
// else if (opcao == "2")
// {
//     Console.WriteLine("Menu de reclamação");
// }

// else
// {
//     Console.WriteLine("Opção inválida");
// }

// switch (opcao)
// {
//     case "1":
//         Console.WriteLine("Menu de cadastro");
//         break;
//     case "2":
//         Console.WriteLine("Menu de reclamação");
//         break;
//     default:
//         Console.WriteLine("Opção inválida");
//         break;
// }

// var valores = Console.ReadLine();
// var valoresArray = valores.Split(" ");

// for (var i = 0; i < valoresArray.Length; i++)
// {
//     Console.Write("FOR ->>" + valoresArray[i] + " ");
// }

// Console.WriteLine();

// var contador = 0;

// while (contador < valoresArray.Length)
// {
//     Console.Write("WHILE ->>" + valoresArray[contador] + " ");

//     contador++;
// }

// Console.WriteLine();

// foreach (var item in valoresArray)
// {
//     Console.Write("FOREACH ->>" + item + " ");
// }

var notas = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var anyNota1 = notas.Any(n => n == 1);
var firstNota10 = notas.First(n => n == 10);
var singleNota8 = notas.Single(n => n == 8);
var orderNotas = notas.OrderBy(n => n);
var max = notas.Max();
var min = notas.Min();
var sum = notas.Sum();
var average = notas.Average();

Console.WriteLine($"Max: {max}");
Console.WriteLine($"Min: {min}");
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Average: {average}");

foreach (var nota in orderNotas)
{
    Console.Write(nota + " ");
}