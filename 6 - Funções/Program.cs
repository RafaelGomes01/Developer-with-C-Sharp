using System;

namespace _6___Funções
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 - Faça um programa que receba o nome e quatro notas de 10 alunos e armazene essas notas em vetores. Calcule e mostre:
            // A. A Média do aluno - Função
            // B. A quantidade de Aprovados (Média >=7)
            // C. A quantidade de Reprovados (Méida < 7)
            // D. A Média geral dos 10 alunos.

            string[] nomes = new string [10];

            float[] nota1 = new float [10];
            float[] nota2 = new float [10];
            float[] nota3 = new float [10];
            float[] nota4 = new float [10];

            float [] media = new float[10];

            for (var i = 1; i < 11; i++){
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Digite o nome e as quatro notas do aluno " + i);
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.Write($"Nota 1: ");
                nota1[i] = float.Parse(Console.ReadLine());
                Console.Write($"Nota 2: ");
                nota2[i] = float.Parse(Console.ReadLine());
                Console.Write($"Nota 3: ");
                nota3[i] = float.Parse(Console.ReadLine());
                Console.Write($"Nota 4: ");
                nota4[i] = float.Parse(Console.ReadLine());
            }

            for (var i = 1; i < 11; i++){
                media[i] = (nota1[i] + nota2[i] + nota3[i] + nota4[i]) / 4;
            }

            for (var i = 1; i < media.Length; i++)
            {
                if(media[i] >= 7){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"O aluno {nomes[i]} ficou com uma media de {media[i]}");
                    Console.WriteLine("Portanto o aluno foi aprovado");
                    Console.ResetColor();
                    Console.WriteLine("------------------------------------------------------");
                }else{
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"O aluno {nomes[i]} ficou com uma media de {media[i]}");
                    Console.WriteLine("Portanto o aluno " + nomes[i] +  " não foi aprovado");
                    Console.ResetColor();
                    Console.WriteLine("------------------------------------------------------");
                }
            }
            Console.WriteLine("")
            float mediaGeral = (media[1] + media[2] + media[3] + media[4]) + media[5] + media[6] + media[7] + media[8] + media[9] + media[10]/ 10;
            Console.WriteLine("A media geral foi de " + mediaGeral + " Pontos ao total");
        }
    }
}
