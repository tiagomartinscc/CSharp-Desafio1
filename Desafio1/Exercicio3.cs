namespace Desafio1;

/// <summary>
/// Crie um programa com 2 valores do tipo double já declarados que retorne:
/// - A soma entre esses dois números;
/// A subtração entre os dois números;
/// A multiplicação entre os dois números
/// A divisão entre os dois números(vale uma verificação se o segundo número é 0!);
/// A média entre os dois números.
/// </summary>
public class Exercicio3
{
    public static void Executar()
    {
        double a, b;
        double resultado;
        bool ok;

        Console.Clear();
        Console.WriteLine("Exercício 3:\n\n");

        do
        {
            (ok, a) = LerNumero();
        } while (!ok);

        do
        {
            (ok, b) = LerNumero();
        } while (!ok);

        Console.WriteLine($"Executando operações com os números {a} e {b}: ");

        resultado = a + b;
        Console.WriteLine($"Soma : {resultado}\n\n");
        resultado = a - b;
        Console.WriteLine($"Subtração : {resultado}\n\n");
        resultado = a * b;
        Console.WriteLine($"Multiplicação : {resultado}\n\n");
        if (b != 0)
        {
            resultado = a / b;
            Console.WriteLine($"Divisão : {resultado}\n\n");
        }
        else
        {
            Console.WriteLine("Divisão inválida pois o dividendo é zero!\n\n");
        }

        Console.WriteLine("Digite algo para continuar...");
        ConsoleKeyInfo keyInfo = Console.ReadKey();
    }

    private static (bool ok, double resultado) LerNumero()
    {
        double result;
        Console.WriteLine("Digite um número do tipo float");
        string? numero = Console.ReadLine();
        if (numero is null)
        {
            Console.WriteLine("Número não informado!");
            return (false, 0);
        }
        if (Double.TryParse(numero, out result))
        {
            return (true, result);
        }
        Console.WriteLine("Número não é um double válido!");
        return (false, 0);
    }
}
