namespace ExemploFor;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"N: ");

        int n = int.Parse(Console.ReadLine() ?? "");

        int soma = 0;

        for(int i = 0; i <= n; i++ ){
            
            soma+= i; //soma = soma + i
            Console.WriteLine(i);
            
        }

        Console.WriteLine($"Soma: " + soma);
    }
}
