// See https://aka.ms/new-console-template for more information
using Interpreter;

Console.WriteLine("Hello, World!");

try
{
    //TODO: Verificar o tempo de execução com o código atual e usando o método avalia, passando o resultado como número.
    Soma soma = new(new Numero(10), new Numero(20));
    Subtracao subtracao = new(soma, new Numero(15));
    Soma resultado = new(soma, subtracao);
    Console.WriteLine($"O resultado é: {resultado.Avalia()}");


    Divisao divisao = new(resultado, new Numero(3));
    Multiplicacao multiplicacao = new(divisao, new Numero(1));
    Console.WriteLine($"O resultado 2 é: {multiplicacao.Avalia()}");
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}


