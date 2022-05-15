using System;

namespace Bee1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int TotalSegundos = int.Parse(Console.ReadLine());

            int Horas = TotalSegundos / 3600;
            TotalSegundos = TotalSegundos % 3600;

            int Minutos = TotalSegundos / 60;
            TotalSegundos = TotalSegundos % 60;

            int Segundos = TotalSegundos;

            //Console.WriteLine( Horas + " horas " + Minutos + " minutos " + Segundos + " Segundos ");

            Console.WriteLine("{0}:{1}:{2}", Horas, Minutos, Segundos);
        }
    }
}
