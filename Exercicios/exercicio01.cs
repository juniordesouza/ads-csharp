/* 1.Construa um algoritmo que calcule o valor da área de um triangulo, 
 * a partir do valor da base e altura. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double area, b, h;
            Console.WriteLine("Digite a altura: ");
            altura = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Base: ");
            b = Double.Parse(Console.ReadLine());
            area = (b * h) / 2;
            Console.WriteLine("Area do triangulo é: " + area);

        }
    }
}
