namespace Aula07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============Operadores de Aytribuição===============");

            //Inicializar a variavel
            int x = 30;
            Console.WriteLine("Valor inicial da Variavel de x? " + x);

            //Operadores de Atribuição
            x = 20;

            Console.WriteLine("Atribuição Simples (=)");
            Console.WriteLine("Valor de x: " + x);

            //Atribuição Completa (incremento)
            x++; // Equivale a x = x + 1

            Console.WriteLine("\n Atribuição Composta Incremento (++)");
            Console.WriteLine("Novo valor sw x:  (++) " + x);

            //Atribuição Completa (+=)
            x += 10; // Equivale a x = x + 1

            Console.WriteLine("\n Atribuição Composta Incremento (++)");
            Console.WriteLine("Novo valor sw x:  (++) " + x);

            //Atribuição Completa (-=)
            x -= 10; // Equivale a x = x - 1

            Console.WriteLine("\n Atribuição Composta Incremento (++)");
            Console.WriteLine("Novo valor sw x:  (++) " + x);
        }
    }
}