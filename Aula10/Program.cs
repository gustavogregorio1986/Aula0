namespace Aula07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inicialização do programa
            Console.WriteLine("===========Calculadora Simples===============");
            Console.WriteLine("Digite o primeiro numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            //Selecionar o tipo de operação
            Console.WriteLine("znEscolha uma operação:");
            Console.WriteLine("1. Adição (+)");
            Console.WriteLine("2. Subtração (-)");
            Console.WriteLine("3. Multiplicação (*)");
            Console.WriteLine("4. Divisão (/)");
            Console.WriteLine("Digite o número da operação: ");
            int operation = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            if (operation == 1)
            {
                result = num1 + num2;
                Console.WriteLine($"O resultado da adição é: {result}");
            }
            else if (operation == 2)
            {
                result = num1 - num2;
                Console.WriteLine($"O resultado da subtração é: {result}");
            }
            else if (operation == 3)
            {
                result = num1 * num2;
                Console.WriteLine($"O resultado da multiplicação é: {result}");
            }
            else if (operation == 4)
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"O resultado da divisão é: {result}");
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                }
            }
            else
            {
                Console.WriteLine("Operação inválida. Por favor, selecione uma operação válida.");
            }
        }
    }
}