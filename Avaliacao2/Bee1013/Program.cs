using System;

namespace Bee1013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ValorMaior = Console.ReadLine().Split(' ');
            int ValorA = Int32.Parse(ValorMaior[0]);
            int ValorB = Int32.Parse(ValorMaior[1]);
            int ValorC = Int32.Parse(ValorMaior[2]);

            int Maior = (ValorA + ValorB + Math.Abs(ValorA - ValorB)) / 2;
            int EhMaior = (ValorC + Maior + Math.Abs(Maior - ValorC)) / 2;
            //Console.WriteLine(Maior.ToString("eh o maior"));
            Console.WriteLine(EhMaior + " eh o maior ");

        }
    }
}
