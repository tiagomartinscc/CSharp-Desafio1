using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Desafio1;

/// <summary>
/// Crie um programa que solicita ao usuário a 
/// exibição da data atual em diferentes formatos:
/// 
/// - Formato completo (dia da semana, dia do mês, mês, 
/// ano, hora, minutos, segundos).
/// - Apenas a data no formato "01/03/2024".
/// - Apenas a hora no formato de 24 horas.
/// - A data com o mês por extenso.
/// </summary>
public class Exercicio6
{
    public static void Executar()
    {
        string dataFormatada;
        DateTime agora = DateTime.Now;

        Console.Clear();
        Console.WriteLine("Exercício 6:\n\n");

        Console.WriteLine("Escolha uma opção para exibição da data: \n\n");

        Console.WriteLine("(1) Formato completo: \n\n");
        Console.WriteLine("(2) Formato de data: \n\n");
        Console.WriteLine("(3) Formato 24 horas: \n\n");
        Console.WriteLine("(4) Formato mês por extenso: \n\n");

        ConsoleKeyInfo? opcao = Console.ReadKey();

        if (opcao != null)
        {
            dataFormatada = opcao.Value.KeyChar switch 
            { 
                '1' => agora.ToString("f"),
                '2' => agora.ToString("dd/MM/yyyy"),
                '3' => agora.ToString("dd/MM/yyyy HH:mm:ss"),
                '4' => agora.ToString("MMMM"),
                _ => "Opção inválida!"
            };
            Console.WriteLine(string.Concat("\n\n", dataFormatada));
        }

        Console.WriteLine("Digite algo para continuar...");
        ConsoleKeyInfo keyInfo = Console.ReadKey();
    }
}
