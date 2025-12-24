namespace Aula10
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool boolValue = true;

            //switch (boolValue)
            //{
            //case true:
            //    Console.WriteLine("O valor é true");
            //    break;
            //case false:
            //    Console.WriteLine("O valor é false");
            //    break;
            //}
            //Console.WriteLine("===============Dia da semana===============");
            //Console.WriteLine("Digite um numero de 1 a 7:");
            //int dayOfWeek = Convert.ToInt32(Console.ReadLine());
            //switch (dayOfWeek)
            //{
            //    case 1:
            //        Console.WriteLine("O dia da semana é Domingo");
            //        break;
            //    case 2:
            //        Console.WriteLine("O dia da semana é Segunda-feira");
            //        break;
            //    case 3:
            //        Console.WriteLine("O dia da semana é Terça-feira");
            //        break;
            //    case 4:
            //        Console.WriteLine("O dia da semana é Quarta-feira");
            //        break;
            //    case 5:
            //        Console.WriteLine("O dia da semana é Quinta-feira");
            //        break;
            //    case 6:
            //        Console.WriteLine("O dia da semana é Sexta-feira");
            //        break;
            //    case 7:
            //        Console.WriteLine("O dia da semana é Sabado");
            //        break;

            //}

            //Ex3:
            Console.WriteLine("================Desempenho Escolar=================");
            Console.WriteLine("Digite sua nota? ");
            int score = Convert.ToInt32(Console.ReadLine());

            switch (score)
            { 
                case 10:
                case 9:
                    Console.WriteLine("Otimo");
                    break;
                case 8:
                case 7:
                    Console.WriteLine("Bom");
                    break;

                case 6:
                    Console.WriteLine("Regular");
                    break;
                case 5:
                    Console.WriteLine("Ruim");
                    break;
                default:
                    Console.WriteLine("Horrivel");
                    break;

            }

        }
    }
}