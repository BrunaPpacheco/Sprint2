using System;
using System.Globalization;

namespace Bee1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ValorTotal1 = Console.ReadLine().Split(' ');
            int CodPeca1 = Int32.Parse(ValorTotal1[0]);
            int NumPeca1 = Int32.Parse(ValorTotal1[1]);
            double ValorUni1 = double.Parse(ValorTotal1[2], CultureInfo.InvariantCulture);

            string[] ValorTotal2 = Console.ReadLine().Split(' ');
            double CodPeca2 = Int32.Parse(ValorTotal2[0]);
            double NumPeca2 = Int32.Parse(ValorTotal2[1]);
            double ValorUni2 = double.Parse(ValorTotal2[2], CultureInfo.InvariantCulture);

            double Total = (NumPeca1 * ValorUni1) + (NumPeca2
                * ValorUni2);
            //Falta converter para 2 casas pós virgula;
            Console.WriteLine("VALOR A PAGAR: R$ {0:0.00}", Total);
        }
    }
}
