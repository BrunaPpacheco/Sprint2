using System;

namespace Bee1259
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero = int.Parse(Console.ReadLine());
            int[] numero = new int[Numero];
            for (int i = 0; i < Numero; i++)

            //solicitando as entradas definidas pelo inteiro:
            {
                int num = int.Parse(Console.ReadLine());

                //array para inteiros:
                numero[i] = new int();

            }

            ///DAQUI EM DIANTE TRAVEI NO CÓDIGO!!!!
            foreach (int i in numero)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);

            }
        }
    }
}
