namespace Aula12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;

            //while(i <= 5)
            //{
            //    Console.WriteLine("Loop Inifinito");
            //    i++;
            //}

            double budget = 100;

            while(budget > 0)
            {
                Console.WriteLine(budget);
                //realizando alguma operação

                budget--;
            }

            Console.WriteLine("Atenção! Saldo insuficiente!");
        }
    }
}