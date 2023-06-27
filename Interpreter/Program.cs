// See https://aka.ms/new-console-template for more information
using Interpreter;

Console.WriteLine("Hello, World!");

Soma soma = new Soma(new Numero(10), new Numero(20));
Subtracao subtracao = new Subtracao(soma, new Numero(15));
Soma resultado = new Soma(soma, subtracao);
Console.WriteLine($"O resultado é: {resultado.Avalia()}");