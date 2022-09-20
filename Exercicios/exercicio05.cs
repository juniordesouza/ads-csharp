/* 5. Crie um algoritmo que leia dois valores inteiros e informe se eles são iguais.
Caso sejam diferentes, informe qual deles é o maior. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio05
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

            if (num1 == num2)
            {
                Console.WriteLine("São iguais!");
            }
            else
            {
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
}
