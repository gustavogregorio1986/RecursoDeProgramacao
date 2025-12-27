namespace Aula17
{
    public class Program
    {
        static void Main(string[] args)
        {
            string separator = "-------------------------------";

            //1. Declaração com inic ialização de valores
            List<string> fruits = new List<string>() 
            {  
                "Manga",
                "Abacate", 
                "Pera"
            };

            //2. Acessar os valords
            Console.WriteLine(fruits[2]);

            Console.WriteLine(separator);

            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            //Adicionar elementos
            fruits.Add("Limão");
            fruits.Add("Laranja");

            

            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine(separator);

            //4. Remover elementos
            fruits.Remove("Limão");


            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine(separator);

            //5. Cpntagem de Eleemtos
            Console.WriteLine("Quantidade de Frutas: " + fruits.Count);

            //6. Modificar um elemento
            fruits[2] = "Maracuja";

            Console.WriteLine(separator);

            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine(separator);

            //7. Limpara lista
            fruits.Clear();

            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine(separator);

            //8. Declara sem incializar
            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(50);
            numbers.Add(78);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}