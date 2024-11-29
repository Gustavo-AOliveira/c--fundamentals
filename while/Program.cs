namespace Estrutura_Repeticao;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("N: ");
        int n = int.Parse(Console.ReadLine());

        int soma = 0;
        int cont = 1;

        while(cont <= n){
            soma = soma + cont;
            cont = cont + 1;
        }

        Console.WriteLine("Soma: " + soma);
        
    }
}
