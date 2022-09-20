/* 9. Escreva um programa que diga qual é o maior de dois números distintos. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1, num2;
            Console.WriteLine("Digite o 1º número:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º número:");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("{0} é maior", num1);
            }
            else
            {
                Console.WriteLine("{0} é maior", num2);
            }

        }
    }
}
