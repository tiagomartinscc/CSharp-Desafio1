using System.Text.RegularExpressions;

namespace Desafio1;

/// <summary>
/// Crie um programa em que o usuário digita uma ou mais palavras 
/// e é exibido a quantidade de caracteres que a palavra inserida tem.
/// 
/// Você pode fazer uma verificação e incrementar o contador apenas se for um caractere, 
/// ignorando os espaços caso o usuário digite mais que uma palavra, por exemplo.
/// </summary>
public class Exercicio4
{
    public static void Executar()
    {
        uint qtd = 0;

        Console.Clear();
        Console.WriteLine("Exercício 4:\n\n");

        Console.WriteLine("Digite uma frase:\n\n");
        string? frase = Console.ReadLine();

        if (frase != null)
        {
            qtd = (uint)Regex.Replace(frase, " ", string.Empty).Length;
            Console.WriteLine(string.Format("Você digitou {0} caracteres!", qtd));
        }

        Console.WriteLine("Digite algo para continuar...");
        ConsoleKeyInfo keyInfo = Console.ReadKey();
    }
}
