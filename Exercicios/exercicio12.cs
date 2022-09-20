/* 12. Escreva um programa que leia o nome de um aluno e as notas que ele obteve
nas três provas do semestre. No final, o programa deve informar o nome do
aluno e a sua média aritmética. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome;
            double[] notas = new double[3];
            double media, soma;
            soma = 0;

            Console.WriteLine("Digite o nome do Aluno:");
            nome = Console.ReadLine();
            for (int i = 0; i <= notas.Length - 1; i++)
            {
                Console.WriteLine("Digite a nota {0}:", i + 1);
                notas[i] = Double.Parse(Console.ReadLine());
                soma += notas[i];

            }

            media = soma / notas.Length;
            Console.WriteLine("A média de {0} é {1}", nome, Math.Ceiling(media));

        }
    }
}
