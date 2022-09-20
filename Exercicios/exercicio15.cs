/* 15. Efetue a leitura de uma temperatura medida em graus Fahrenheit e a
apresente con- vertida em graus Celsius. A fórmula para a conversão é C = ((F -
32) * 5)/9, sendo F a temperatura em Fahrenheit e C a temperatura em Celsius. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double tempC, tempF;
            Console.WriteLine("Digite a temperatura");
            tempF = Double.Parse(Console.ReadLine());
            tempC = ((tempF - 32) * 5) / 9;
            Console.WriteLine("Temperatura: " + tempC);

        }
    }
}
