namespace Aula14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

               for(condicao 1; condicao 2; condicao 3)
               {
                     //bloco de codigo
               }

             Declaração 1 é executada uma vez no início do loop.
               
             Declaração 2 é a condição de continuação do loop. Enquanto   for verdadeira, o loop continua.
             
             Declaração 3 é executada no final de cada iteração do loop.
            */

            //ex1:
            for(int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    Console.Write($" {i * j, 6} ");
                }
                Console.WriteLine();
            }
        }
    }
}