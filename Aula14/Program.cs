namespace Aula14
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
              for (condicao 1; condição 2; iteração 3)
              {
                  // bloco de código
              }
              
              Declaração 1 é executada (uma vez) antes da execução do bloco de código.

              Declaração 2 define a condição para executar o bloco de código.

              Declaração 3 executa (todas as vezes) após o bloco de código ter sido executado.

             */

            //Ex1:
            //for(int i = 1; i <= 10; i++)
            //{,
            //    Console.WriteLine(i);
            //}

            //ex2:
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine($"{i} - {j}");
            //    }
            //}

            Console.WriteLine("===========tabela de Multiplicação===================");

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i * j,10}");
                }

                Console.WriteLine();
            }
        }
    }
}