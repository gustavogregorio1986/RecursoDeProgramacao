namespace Aula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------CADASTRO DE USUÁRIO---------------");

            //Solicitar o nome do usuario
            Console.WriteLine("Digite o Seu Nome: ");
            string nome = Console.ReadLine();

            //Solicitar a idade do usuario
            Console.WriteLine("Digite Sua idade: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("Nome do Usuário: " + nome);
            Console.WriteLine("Ida do usuario: " + age);

        }
    }
}