/* 7. Escreva um programa que resolva o seguinte problema: uma cópia “xerox”
custa R$ 0,50 por folha, mas acima de 200 folhas esse valor cai para R$ 0,30 por
unidade. Dado o total de cópias, informe o valor a ser pago. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int paginas;
            double valor = 0.50, valorFinal;
            Console.WriteLine("Digite a quantidade de páginas:");
            paginas = int.Parse(Console.ReadLine());
            if (paginas > 200)
            {
                valor = 0.30;
                valorFinal = paginas * valor;
                Console.WriteLine("Valor a pagar: " + valorFinal);
            }
            else
            {
                valorFinal = paginas * valor;
                Console.WriteLine("Valor a pagar: " + valorFinal);
            }

        }
    }
}
