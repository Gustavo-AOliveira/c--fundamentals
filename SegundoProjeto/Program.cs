using System.Runtime.ConstrainedExecution;

namespace PrimeiroPrograma;

class Program
{
    static void Main(string[] args)
    {
        string nome = "'";

        while(string.IsNullOrEmpty(nome)){
                Console.Write($"Por favor, Insira seu nome: ");
                nome = Console.ReadLine() ?? "";
        }       

        Console.WriteLine("Olá, " + nome);
    }
}
