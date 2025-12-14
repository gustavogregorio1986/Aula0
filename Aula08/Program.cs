namespace Aula07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============Operadores Relçacionais==============");
            Console.WriteLine("Digite o primeiro numwero: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int y = Convert.ToInt32(Console.ReadLine());

            string result;

            if(x == y)
            {
                result = "x é igual a y";
            }
            else
            {
                result = "x é diferente de y";
            }

            Console.WriteLine("\nIgualdade (==): " + result);

            //Operador de Diferença (!=)
            if (x != y)
            {
                result = "x é diferente a y";
            }
            else
            {
                result = "x é igual de y";
            }

            Console.WriteLine("\nDiferença (!=): " + result);

            if (x < y)
            {
                result = "x é menor que y";
            }
            else
            {
                result = "x é maior que y";
            }

            Console.WriteLine("\nMenor que (<): " + result);


            if (x <= y)
            {
                result = "x é menor ou igual y";
            }
            else
            {
                result = "x é maior ou igual  y";
            }

            Console.WriteLine("\nMenor ou igual (<): " + result);
        }
    }
}