/* 8. Escreva um programa que informe a categoria de um jogador de futebol,
considerando sua idade: infantil (até 13 anos), juvenil (até 17 anos) ou sênior
(acima de 17 anos). */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] categorias = { "Infantil", "Juvenil", "Senior" };
            int idade;
            Console.WriteLine("Digite a idade:");
            idade = int.Parse(Console.ReadLine());

            if (idade <= 13)
            {
                Console.WriteLine("Categoria: " + categorias[0]);
            }
            else if (idade > 13 && idade <= 17)
            {
                Console.WriteLine("Categoria: " + categorias[1]);
            }
            else
            {
                Console.WriteLine("Categoria: " + categorias[2]);
            }

        }
    }
}
