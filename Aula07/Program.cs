namespace Aula07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========Operadores de Atribuição===========");

            // Inicializar a variável
            int x = 10;
            Console.WriteLine("\nValor inicial da Veriavel de x: " + x);

            //Opertador de Atribuição (=)
            x = 20;
            Console.WriteLine("Atribuição Simples");
            Console.WriteLine("Valor de x: " + x);


            //Atribuição Composta
            x++; // x = x + 20

            Console.WriteLine("\nAtribuição Composta Incremento (++)");
            Console.WriteLine("\nNovo Valor de x: (++) " + x);

            x += 10;
            Console.WriteLine("\nAtribuiçãao Composta (+=)");
            Console.WriteLine("Novo Valor de x: " + x);

            x *= 10;
            Console.WriteLine("\nAtribuiçãao Composta (*=)");
            Console.WriteLine("Novo Valor de x: " + x);

            x /= 10;
            Console.WriteLine("\nAtribuiçãao Composta (/=)");
            Console.WriteLine("Novo Valor de x: " + x);

        }
    }
   
}