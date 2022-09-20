/* 4. Crie um algoritmo que leia o nome de um aluno e as notas das três provas que
ele obteve no semestre, com pesos 2, 4 e 6. No final, deve-se informar o nome
do aluno e a sua média ponderada. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome;
            int nota1, nota2, nota3, media;
            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a 1a nota: ");
            nota1 = int.Parse(Console.ReadLine());
            while (nota1 < 0 || nota1 > 2)
            {
                Console.WriteLine("Digite a nota corretamente");
                nota1 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite a 2a nota: ");
            nota2 = int.Parse(Console.ReadLine());
            while (nota2 < 0 || nota2 > 4)
            {
                Console.WriteLine("Digite a nota corretamente");
                nota2 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite a 3a nota: ");
            nota3 = int.Parse(Console.ReadLine());
            while (nota3 < 0 || nota3 > 6)
            {
                Console.WriteLine("Digite a nota corretamente");
                nota3 = int.Parse(Console.ReadLine());
            }
            media = nota1 + nota2 + nota3;
            Console.WriteLine("Aluno: " + nome + "\nMédia: " + media);

        }
    }
}
