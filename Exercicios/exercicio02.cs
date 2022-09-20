/* 2. Desenhe um algoritmo que receba dois números e mostre a soma, a subtração,
a multiplicação e a divisão dos números. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double n1, n2, n3;
            Console.WriteLine("Digite o 1º numero: ");
            n1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º numero: ");
            n2 = Double.Parse(Console.ReadLine());
            n3 = n1 + n2;
            Console.WriteLine("Soma: " + n3);
            n3 = n1 - n2;
            Console.WriteLine("Subtração: " + n3);
            n3 = n1 * n2;
            Console.WriteLine("Multiplicação: " + n3);
            n3 = n1 / n2;
            Console.WriteLine("Divisão: " + n3);

        }
    }
}
