using System.Text.RegularExpressions;

namespace Desafio1;

/// <summary>
/// Crie um programa em que o usuário precisa digitar a placa de um veículo 
/// e o programa verifica se a placa é válida, 
/// seguindo o padrão brasileiro válido até 2018:
/// 
/// A placa deve ter 7 caracteres alfanuméricos;
/// Os três primeiros caracteres são letras(maiúsculas ou minúsculas);
/// Os quatro últimos caracteres são números;
/// Ao final, o programa deve exibir
/// *** Verdadeiro*** se a placa for válida e *** Falso*** caso contrário.
/// </summary>
public class Exercicio5
{
    public static void Executar()
    {
        Console.Clear();
        Console.WriteLine("Exercício 5:\n\n");

        Console.WriteLine("Digite uma placa:\n\n");
        string? placa = Console.ReadLine();

        if (placa != null)
        {
            if (Regex.IsMatch(placa, "^[a-zA-Z]{3}[0-9]{4}"))
            {
                Console.WriteLine("*** Verdadeiro ***");
            }
            else 
            {
                Console.WriteLine("*** Falso ***");
            }
        }

        Console.WriteLine("Digite algo para continuar...");
        ConsoleKeyInfo keyInfo = Console.ReadKey();
    }
}
