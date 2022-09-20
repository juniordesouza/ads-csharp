/* 11. Escreva um programa que receba um número inteiro do usuário e diga se ele é
par ou impar. Dica: Um número é par se o resto (use a função modulo %) da
divisão dele por 2 for zero. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num;
            Console.WriteLine("Digite um número:");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("{0} é par.", num);
            }
            else
            {
                Console.WriteLine("{0} é impar.", num);
            }

        }
    }
}
