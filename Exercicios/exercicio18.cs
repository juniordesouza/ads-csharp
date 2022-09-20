/* 18. Efetue a leitura de dois valores numéricos inteiros e apresente o resultado da
diferença do maior valor pelo menor. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio18
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
            if (n1 > n2)
            {
                n3 = n1 - n2;
                Console.WriteLine("Diferença: " + n3);
            }
            else
            {
                n3 = n2 - n1;
                Console.WriteLine("Diferença: " + n3);
            }

        }
    }
}
