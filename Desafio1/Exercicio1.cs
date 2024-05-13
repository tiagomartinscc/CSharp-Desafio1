namespace Desafio1;

/// <summary>
/// Crie um programa em que o usuário precisa digitar um nome e 
/// uma mensagem de boas vindas personalizada com o nome dele é exibida:  
/// Olá, Welisson! Seja muito bem-vindo!
/// </summary>
public class Exercicio1
{
    public static void Executar()
    {
        
        Console.Clear();
        Console.WriteLine("Exercício 1:\n\n");
        Console.WriteLine("Digite seu nome: ");
        string? nome = Console.ReadLine();
        if (nome is not null)
        {
            Console.WriteLine($"Olá, {nome}! Seja muito bem - vindo!");
        }
        else
        {
            Console.WriteLine("Não informou nome");
        }
        
        Console.WriteLine("Digite algo para continuar...");
        ConsoleKeyInfo keyInfo = Console.ReadKey();
    }
}
