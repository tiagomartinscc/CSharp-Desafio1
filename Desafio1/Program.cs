namespace Desafio1;
public class Program
{
    public static void Main()
    {
        ConsoleKeyInfo keyInfo;
        bool sair;
        do
        {
            Console.Clear();
            Console.WriteLine(">> Digite um número de 1 a 6 para Executar o programa.");
            Console.WriteLine("\n>> ESC para SAIR <<\n");
            keyInfo = Console.ReadKey();
            sair = keyInfo.Key.Equals(ConsoleKey.Escape);
            switch (keyInfo.KeyChar)
            {
                case '1':
                    Exercicio1.Executar();
                    break;
                case '2':
                    Exercicio2.Executar();
                    break;
                case '3':
                    Exercicio3.Executar();
                    break;
                case '4':
                    Exercicio4.Executar();
                    break;
                case '5':
                    Exercicio5.Executar();
                    break;
                case '6':
                    Exercicio6.Executar();
                    break;
                default:
                    break;
            }
        } while (!sair);
    }
}