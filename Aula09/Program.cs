namespace Aula07
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============Operadores Lógicos==================");
            
            bool isLogged = true;
            bool hasAdminAccess = false;

            Console.WriteLine("\nInformações do Usuário");
            Console.WriteLine("Usuário logado:");
            Console.WriteLine("Acesso ao painel de administrador: " + hasAdminAccess);

            //Operador (||) - OU
            if (isLogged || hasAdminAccess)
            {
                Console.WriteLine("Acesso concedido ao sistema.");
            }
            

            //operador (&&) - E
            if (isLogged && hasAdminAccess)
            {
                Console.WriteLine("Acesso concedido ao painel de administração.");
            }
            else
            {
                Console.WriteLine("Acesso negado ao painel de administração.");
            }
        }
    }
}