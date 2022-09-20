/* 3. Elabore um algoritmo que leia o nome de um vendedor, o seu salário fixo e o
total de vendas efetuadas por ele no mês (em dinheiro). Sabendo que esse
vendedor ganha 20% de comissão sobre suas vendas efetuadas, faça que o
algoritmo informe o seu nome, o salário fixo e salário no final do mês. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome;
            double salario, vendas;
            Console.WriteLine("Digite o nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o salário");
            salario = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o total de vendas");
            vendas = Double.Parse(Console.ReadLine());
            double salarioFinal = salario + (vendas * 0.2);
            Console.WriteLine(nome + "\n" + salario + "\n" + salarioFinal);

        }
    }
}
