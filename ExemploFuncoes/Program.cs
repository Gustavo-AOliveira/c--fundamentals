namespace ExemploFuncoes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Diga seu nome:");
        
        string nome = Console.ReadLine();
        digaOla(nome);
    }

    static void funcao(){
        Console.WriteLine($"ola");
        
    }

    static void digaOla(string nome){
        Console.WriteLine($"Olá " + nome);
    }
}
