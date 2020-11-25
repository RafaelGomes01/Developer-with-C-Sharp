using System;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5 - Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10. Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.

            int tabuada, fator2, fator1;

            Console.WriteLine("");
            Console.WriteLine("Tabuada do 1");

            for (fator1 = 1; fator1 < 11; fator1++){
                 for (fator2 = 1; fator2 <= 10; ++fator2){
                    tabuada =  fator1 * fator2;
                    Console.WriteLine(fator1 + " X " + fator2 + " = " + tabuada);
                    if(fator1 == 1 && fator2 == 10){Console.WriteLine("\nTabuada do 02");}
                    else if(fator1 == 2 && fator2 == 10){Console.WriteLine("\nTabuada do 03");}
                    else if(fator1 == 3 && fator2 == 10){Console.WriteLine("\nTabuada do 04");}
                    else if(fator1 == 4 && fator2 == 10){Console.WriteLine("\nTabuada do 05");}
                    else if(fator1 == 5 && fator2 == 10){Console.WriteLine("\nTabuada do 06");}
                    else if(fator1 == 6 && fator2 == 10){Console.WriteLine("\nTabuada do 07");}
                    else if(fator1 == 7 && fator2 == 10){Console.WriteLine("\nTabuada do 08");}
                    else if(fator1 == 8 && fator2 == 10){Console.WriteLine("\nTabuada do 09");}
                    else if(fator1 == 9 && fator2 == 10){Console.WriteLine("\nTabuada do 10");}
                }
            }
        }
    }
}
