namespace Aula05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========Calculadora Bem simples==============");
            Console.WriteLine("Digite o numero 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o numero 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;
            int subtract = number1 - number2;
            int multiplication = number1 * number2;
            int division = number1 / number2;
            int module = number1 % number2;

            Console.WriteLine("O valor da soma é: " + sum);
            Console.WriteLine("O valor da sibtração é: " + subtract);
            Console.WriteLine("O valor da multiplicação é: " + multiplication);
            Console.WriteLine("O valor da divisão é: " + division);
            Console.WriteLine("O resto da divisão é: " + module);
        }
    }
}