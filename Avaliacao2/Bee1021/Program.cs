using System;

namespace Bee1021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Valor = double.Parse(Console.ReadLine());

            Console.WriteLine("NOTAS:");

            double qtdNotas = Valor / 100;
            Valor = Valor % 100;
            Console.WriteLine($"{(int)qtdNotas} nota(s) de R$ 100.00");

            qtdNotas = Valor / 50;
            Valor = Valor % 50;
            Console.WriteLine($"{(int)qtdNotas} nota(s) de R$ 50.00");

            qtdNotas = Valor / 20;
            Valor = Valor % 20;
            Console.WriteLine($"{(int)qtdNotas} nota(s) de R$ 20.00");

            qtdNotas = Valor / 10;
            Valor = Valor % 10;
            Console.WriteLine($"{(int)qtdNotas} nota(s) de R$ 10.00");

            qtdNotas = Valor / 5;
            Valor = Valor % 5;
            Console.WriteLine($"{(int)qtdNotas} nota(s) de R$ 5.00");

            qtdNotas = Valor / 2;
            Valor = Valor % 2;
            Console.WriteLine($"{(int)qtdNotas} nota(s) de R$ 2.00");

            //// MOEDAS ///

            Console.WriteLine("MOEDAS:");
            Valor = Valor * 100;

            double Moeda1 = Valor / 100;
            Valor = Valor % 100;
            Console.WriteLine($"{(int)Moeda1} moeda(s) de R$ 1.00");

            double Moeda2 = Valor / 50;
            Valor = Valor % 50;
            Console.WriteLine($"{(int)Moeda2} moeda(s) de R$ 0.50");

            double Moeda3 = Valor / 25;
            Valor = Valor % 25;
            Console.WriteLine($"{(int)Moeda3} moeda(s) de R$ 0.25");

            double Moeda4 = Valor / 10;
            Valor = Valor % 10;
            Console.WriteLine($"{(int)Moeda4} moeda(s) de R$ 0.10");

            double Moeda5 = Valor / 5;
            Valor = Valor % 5;
            Console.WriteLine($"{(int)Moeda5} moeda(s) de R$ 0.05 ");

            double Moeda6 = Valor / 1;
            Valor = Valor % 1;
            Console.WriteLine($"{(int)Moeda6} moeda(s) de R$ 0.01");
        }
    }
}
