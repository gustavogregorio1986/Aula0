using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Aula03
{
    public class Program
    {
        static void Main(string[] args)
        {

            //var
            //dynamic
            //obj

            dynamic variable = 20;

            variable = "Antônio";

            Console.WriteLine("O avlor da variável é: " + variable);



            /*
             var variable = 500;

            variable = "500"; //erro de compilação

            Console.WriteLine("O avlor da variável é: " + variable);

            var variable = "Antônio";

            variable = 500; //erro de compilação

            Console.WriteLine("O avlor da variável é: " + variable);
            
            const int number = 1000;

            Console.WriteLine("O avlor da constante é: " + number);

            string name = "Antônio";

            name = "Antônio Rocha";

            Console.WriteLine("O valor antigo da variavel é: " + name);

            name = "Antônio Junior";

            Console.WriteLine("O valor antigo da variavel é: " + name);

            int number = 30;

            number = 20;

            Console.WriteLine("O valor antigo da variavel é: " + number);

            number = 10;

            Console.WriteLine("O valor novo da variavel é: " + number);
            */
        }
    }
}