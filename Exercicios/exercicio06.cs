/* 6. Faça um algoritmo que receba um número e diga se este está ou não no
intervalo entre 200 e 300. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double num;
            Console.WriteLine("Digite o número");
            num = Double.Parse(Console.ReadLine());
            if (num >= 200 && num <= 300)
            {
                Console.WriteLine("{0} está entre 200 e 300.", num);
            }

        }
    }
}
