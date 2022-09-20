/* 14. Efetue a leitura de uma temperatura medida em graus Celsius e faça a
conversão em graus Fahrenheit. A fórmula para a conversão das temperaturas
é F = (9 * C + 160)/5, sendo F a temperatura em Fahrenheit e C em Celsius. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double tempC, tempF;
            Console.WriteLine("Digite a temperatura");
            tempC = Double.Parse(Console.ReadLine());
            tempF = (9 * tempC + 160) / 5;
            Console.WriteLine("Temperatura: " + tempF);

        }
    }
}
