using System;

namespace Bee1018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ler um valor inteiro
            int Valor = int.Parse(Console.ReadLine());

            //imprimir valor:
            Console.WriteLine(Valor);

            //Calcula e imprime a quantidade de cada cédula:


            int qtdNotas = Valor / 100;
            Valor = Valor % 100;
            Console.WriteLine($"{qtdNotas} nota(s) de R$ 100,00");

            qtdNotas = Valor / 50;
            Valor = Valor % 50;
            Console.WriteLine($"{qtdNotas} nota(s) de R$ 50,00");

            qtdNotas = Valor / 20;
            Valor = Valor % 20;
            Console.WriteLine($"{qtdNotas} nota(s) de R$ 20,00");

            qtdNotas = Valor / 10;
            Valor = Valor % 10;
            Console.WriteLine($"{qtdNotas} nota(s) de R$ 10,00");

            qtdNotas = Valor / 5;
            Valor = Valor % 5;
            Console.WriteLine($"{qtdNotas} nota(s) de R$ 5,00");

            qtdNotas = Valor / 2;
            Valor = Valor % 2;
            Console.WriteLine($"{qtdNotas} nota(s) de R$ 2,00");

            qtdNotas = Valor / 1;
            Valor = Valor % 1;
            Console.WriteLine($"{qtdNotas} nota(s) de R$ 1,00");

        }
    }
}
