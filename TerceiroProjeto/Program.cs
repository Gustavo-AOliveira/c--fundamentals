namespace TerceiroPrograma;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o número que você quer saber o dobro: ");

        double numero = double.Parse(Console.ReadLine() ?? "");
        double resultado = numero * 2;

        Console.WriteLine($"O dobro de " + numero + " é " + resultado);
        
        }
        
    }
