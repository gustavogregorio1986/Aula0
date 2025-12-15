namespace Aula07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool boolValue = true;

            //switch(boolValue)
            //{
            //    case true:
            //        Console.WriteLine("O valor é verdadeiro.");
            //        break;
            //    case false:
            //        Console.WriteLine("O valor é falso.");
            //        break;
            //}

            Console.WriteLine("=============Dia da Semwna===============");
            Console.WriteLine("Digite um número de 1 a 7:");
            int dayIfWeek = Convert.ToInt32(Console.ReadLine());

            switch (dayIfWeek) 
            { 
                 case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda-feira");
                    break;
                case 3:
                    Console.WriteLine("Terça-feira");
                    break;
                case 4:
                    Console.WriteLine("Quarta-feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta-feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta-feira");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;
                default:
                    Console.WriteLine("Número inválido! Digite um número entre 1 e 7.");
                    break;
            }

            //Ex3:
            Console.WriteLine("===========Desempenho Escolar================");
            Console.WriteLine("Digite sua nota: ");
            int score = Convert.ToInt32(Console.ReadLine());

            switch (score)
            {
                case 10:
                case 9:
                    Console.WriteLine("Otimo");
                    break;

            }


        }
    }
    
}