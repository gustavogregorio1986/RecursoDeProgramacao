namespace Aula05
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================Calculadora Bem Simples=====================");

            Console.WriteLine("Digite o numro 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o numro 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;
            int subtraction = number1 - number2;
            int multiplication = number1 * number2;
            int division = number2 / number1;
            int module = number2 % number1;

            Console.WriteLine("A soma é: " + sum);
            Console.WriteLine("A subtração é: " + subtraction);
            Console.WriteLine("A multiplicação é: " + multiplication);
            Console.WriteLine("A divisão é: " + division);
            Console.WriteLine("O resto da divisão é: " + module);
        }
    }
}