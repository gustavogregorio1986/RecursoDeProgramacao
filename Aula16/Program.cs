namespace Aula16
{
    public class Program
    {
        static void Main(string[] args)
        {
            string separator = "----------------------------------";

            string[] fruits = { "Maça", "Banana", "Caju", "Manga" };

            Console.WriteLine(separator);

            //1. Acessar os valores
            Console.WriteLine(fruits[0]);

            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}