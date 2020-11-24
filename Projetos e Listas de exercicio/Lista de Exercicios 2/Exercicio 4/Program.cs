using System;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o menor valor lido.

            int[] num = new int[10];
            int menor = 0, maior = 0;

            Console.WriteLine( "Informe 10 números inteiros:" );

            for( int i = 0; i < 10; i++ )
            {

                Console.Write( ( i + 1 ) + "º número: " );
                num[i] = int.Parse(Console.ReadLine());

                if( i == 0 ){
                    menor = num[0];
                    maior = num[0];
                }

                if( num[i] < menor ){
                    menor = num[i];
                }

                else if( num[i] > maior ){
                    maior = num[i];
                }

            }

            Console.WriteLine( "O menor número é:" + menor );
            Console.WriteLine( "O maior número é:" + maior );
        }
    }
}
