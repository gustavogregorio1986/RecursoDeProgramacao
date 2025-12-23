namespace Aula09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================Operadores Lógicos=================");

            bool isLogged = true;
            bool hasAdminAcess = false;

            Console.WriteLine("Informações de Usuário:");
            Console.WriteLine("Usuario Logado: " + isLogged);
            Console.WriteLine("Acesso ao painel de administrador:" + hasAdminAcess);

            Console.WriteLine("\nPermissões");

            //Operador (E) &&

            if (isLogged == true && hasAdminAcess == true)
            {
                Console.WriteLine("Acesso ao painel de administrador permitido");
            }
            else
            {
                Console.WriteLine("Acesso negado!");
            }

            //OPerador (||) - Ou
            if(isLogged || hasAdminAcess)
            {
                Console.WriteLine("Acesso ao painel de administrador permitido");
            }
            else
            {
                Console.WriteLine("Acesso negado!");
            }

            //Operador NOT (!)
            if(!isLogged)
            {
                Console.WriteLine("Usuário não está logado!");
            }
            else
            {
                Console.WriteLine("Usuário logado no sistema!");
            }

        }
    }
}