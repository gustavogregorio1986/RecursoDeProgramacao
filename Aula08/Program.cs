namespace Aula08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============Operadores não relacionais================ \n");

            Console.WriteLine("Digite o primeiro numero: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int y = Convert.ToInt32(Console.ReadLine());

            bool result;

            // Operador de igualdade (==)
            if (x == y)
            {
                Console.WriteLine($"Os numeros {x} e {y} são iguais.");
            }
            else
            {
                Console.WriteLine($"Os numeros {x} e {y} não são diferentes.");
            }

            // Operador de igualdade (==)
            if (x != y)
            {
                Console.WriteLine($"Os numeros {x} e {y} são difeentes.");
            }
            else
            {
                Console.WriteLine($"Os numeros {x} e {y} não são iguais.");
            }

            if (x >= y)
            {
                Console.WriteLine($"{x} é menor ou igual que {y}.");
            }
            else
            {
                Console.WriteLine($"{x} é maior ou igual que {y}.");
            }
        }
    }
}