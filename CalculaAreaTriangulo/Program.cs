namespace CalculaArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = -1;

            while (p != 1)
            {
                Console.WriteLine("Você gostaria de calcular a área do seu triângulo?\n");
                Console.WriteLine("Sim = 1");
                Console.WriteLine("Não = 0");

                Console.WriteLine($"Digite um número válido, 0 ou 1");
                

                string input = Console.ReadLine() ?? "";
                try
                {
                    p = int.Parse(input);

                    if (p == 0)
                    {
                        Console.WriteLine("Programa encerrado!");
                        Environment.Exit(0);
                    }
                    else if (p != 1)
                    {
                        Console.WriteLine("\nPor favor, insira um número válido (0 ou 1).");
                        Console.WriteLine($" -------------------------------");
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error message: " + ex.Message);
                    Console.WriteLine($" -------------------------------");
                }
            }

            double b = 0;
            double a = 0;

            // Loop para garantir que o usuário insira um valor válido para a base
            while (true)
            {
                try
                {
                    Console.Write($"Digite a base: ");
                    b = double.Parse(Console.ReadLine() ?? "");
                    break; // Sai do loop se a conversão for bem-sucedida
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Entrada inválida. Por favor, insira um número válido para a base.");
                    Console.WriteLine($"Error message: " + ex.Message);
                }
            }

            // Loop para garantir que o usuário insira um valor válido para a altura
            while (true)
            {
                try
                {
                    Console.Write($"Digite a altura: ");
                    a = double.Parse(Console.ReadLine() ?? "");
                    break; // Sai do loop se a conversão for bem-sucedida
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Entrada inválida. Por favor, insira um número válido para a altura.");
                    Console.WriteLine($"Error message: " + ex.Message);
                }
            }

            double area = (b * a) / 2;
            Console.WriteLine($"\nA área do seu triângulo é: " + area);
        }
    }
}
