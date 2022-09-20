/* 13. Escreva um programa que receba um número e diga se ele está no intervalo
entre 100 e 200. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double num;
            Console.WriteLine("Digite o número");
            num = Double.Parse(Console.ReadLine());
            if (num >= 100 && num <= 200)
            {
                Console.WriteLine("{0} está entre 100 e 200.", num);
            }

        }
    }
}
