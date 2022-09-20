/* 17. Efetue a leitura de quatro valores reais referentes a quatro notas escolares de
um aluno e apresente mensagem informando que o aluno está aprovado caso o
valor da média escolar seja maior ou igual a 5. Caso o aluno não seja aprovado,
apresente mensagem informando que o aluno encontra-se reprovado. Ao final,
além das mensagens, apresente o valor da média do aluno. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome;
            double[] notas = new double[4];
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

            Math.Ceiling(media = soma / notas.Length);
            if (media >= 5)
            {
                Console.WriteLine("A média de {0} é {1}\nAluno Aprovado", nome, media);
            }
            else
            {
                Console.WriteLine("A média de {0} é {1}\nAluno Reprovado", nome, media);
            }

        }
    }
}
