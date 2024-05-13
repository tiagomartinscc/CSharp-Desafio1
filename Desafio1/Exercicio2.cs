namespace Desafio1;

/// <summary>
/// Crie um programa que concatene um nome e um sobrenome inseridos pelo 
/// usuário e ao final exiba o nome completo.
/// </summary>
public class Exercicio2
{
    public static void Executar()
    {
        Console.Clear();
        Console.WriteLine("Exercício 2:\n\n");
        Console.WriteLine("Digite seu nome: ");
        string? nome = Console.ReadLine();
        Console.WriteLine("Digite seu sobrenome: ");
        string? sobrenome = Console.ReadLine();
        Console.WriteLine(string.Concat(nome, " ", sobrenome));
        Console.WriteLine("Digite algo para continuar...");
        ConsoleKeyInfo keyInfo = Console.ReadKey();
    }
}
