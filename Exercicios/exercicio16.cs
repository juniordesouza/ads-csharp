/* 16. Efetue a leitura de três valores (variáveis A, B e C) de qualquer tipo e apresente
os valores em ordem crescente. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] idade = new int[3];
            for (int i = 0; i <= idade.Length - 1; i++)
            {
                Console.WriteLine("Digite a {0}ª idade ", i);
                idade[i] = int.Parse(Console.ReadLine());
            }

            if (idade[0] > idade[1] && idade[0] > idade[2])
            {
                if (idade[1] < idade[2])
                {
                    Console.WriteLine("{0}\n{1}\n{2}", idade[1], idade[2], idade[0]);
                }
                else
                {
                    Console.WriteLine("{0}\n{1}\n{2}", idade[2], idade[1], idade[0]);
                }
            }
            else if (idade[1] > idade[0] && idade[1] > idade[2])
            {
                if (idade[2] < idade[0])
                {
                    Console.WriteLine("{0}\n{1}\n{2}", idade[2], idade[0], idade[1]);
                }
                else
                {
                    Console.WriteLine("{0}\n{1}\n{2}", idade[0], idade[2], idade[1]);
                }
            }
            else if (idade[2] > idade[1] && idade[2] > idade[0])
            {
                if (idade[1] < idade[0])
                {
                    Console.WriteLine("{0}\n{1}\n{2}", idade[1], idade[0], idade[2]);
                }
                else
                {
                    Console.WriteLine("{0}\n{1}\n{2}", idade[0], idade[1], idade[2]);
                }
            }

        }
    }
}
