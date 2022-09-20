/* 10. Escreva um programa que calcule a média aritmética de três números digitados
pelo usuário. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] numeros = new double[3];
            Console.WriteLine(numeros.Length);
            double media, soma;
            soma = 0;
            for (int i = 0; i <= numeros.Length - 1; i++)
            {
                Console.WriteLine("Digite um número:");
                numeros[i] = Double.Parse(Console.ReadLine());
                soma += numeros[i];

            }
            media = soma / numeros.Length;
            Console.WriteLine("Média: " + media);

        }
    }
}
