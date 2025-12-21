namespace Aula06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================Verificador de Numeros pares ou impares==============");

            Console.WriteLine("Diogite um numero: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = number % 2;


            if (result == 0)
            {
                Console.WriteLine($"O numero {number} é par");
            }
            else
            {
                Console.WriteLine($"O numero {number} é impar");
            }
        }
    }
}