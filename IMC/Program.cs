namespace IMC;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Seu peso: ");

        float peso = float.Parse(Console.ReadLine() ?? "");

        Console.WriteLine($"Altura: ");
        float altura = float.Parse(Console.ReadLine() ?? "");
        
        Console.WriteLine($"Peso: " + peso);
        Console.WriteLine($"Altura: " + altura);
        
        float imc = peso / (altura * altura);

        Console.WriteLine($"Seu IMC: " + imc);

        if(imc < 20){
            Console.WriteLine($"Você está abaixo do peso");
            
        }else if(imc < 25){
            Console.WriteLine($"Você está peso ideal");
            
        }else {
            Console.WriteLine($"Você está acima do peso");
        }
    }
}
