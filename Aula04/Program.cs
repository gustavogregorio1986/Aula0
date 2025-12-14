namespace Aula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------CADASTRO DE USUÁTIO----------------");

            // Solicitar o nome do usuário
            Console.WriteLine("Digite Seu Nome: ");
            string nome = Console.ReadLine();
            

            // Solicitar a idade do Usuario
            Console.WriteLine("Digite sua idade: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Nome do Usuário: " + nome);
            Console.WriteLine("Idade do Usuário: " + age);
        }
    }
}