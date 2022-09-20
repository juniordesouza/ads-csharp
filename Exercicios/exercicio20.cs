/* 20. Faça um algoritmo que mostre os números de 100 a 1, usando comando (use o
comando WHILE ou FOR ) de repetição. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine(i);
            }

        }
    }
}
