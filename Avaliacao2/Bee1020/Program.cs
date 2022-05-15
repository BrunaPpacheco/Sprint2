using System;

namespace Bee1020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int IdadeDias = int.Parse(Console.ReadLine());

            int TotalAnos = IdadeDias / 365;
            IdadeDias = IdadeDias % 365;

            int TotalMeses = IdadeDias / 30;
            IdadeDias = IdadeDias % 30;

            Console.WriteLine(TotalAnos + " ano(s)");
            Console.WriteLine(TotalMeses + "mes(es)");
            Console.WriteLine(IdadeDias + " dia(s)");
        }
    }
}
