namespace Aula18
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.IO.File.WriteAllText("file.txt", "Hello World!");

            Console.WriteLine("Arquivo criado com suceso!");
        }
    }
}