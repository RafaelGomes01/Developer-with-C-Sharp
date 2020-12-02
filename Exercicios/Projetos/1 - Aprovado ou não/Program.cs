using System;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Projeto - Aprovado ou não
            string situacao = ""; // Comando para armazenar a situação do aluno dentro de uma variavel.

            Console.WriteLine("Digite sua primeira nota"); //Comando para escrever na tela ("Digite sua primeira nota").
            double nota1 = double.Parse(Console.ReadLine()); // Comando para armazenar oque o usuario escreveu na linha.

            Console.WriteLine("Digite sua segunda nota"); //Comando para escrever na tela ("Digite sua segunda nota").
            double nota2 = double.Parse(Console.ReadLine()); // Comando para armazenar oque o usuario escreveu na linha.

            double media = (nota1 + nota2) / 2; // Comando para armazenar a operação de soma e divisão (Media) dentro de uma variavel.

            if(media > 7){ // Comando para condicionar se a media for maior que 7:
                situacao = "Aprovado"; // A variavel situação passa a ser aprovado
            }
            else{ // Comando para condicionar se não for maior que 7:
                situacao = "Reprovado"; // A variavel situação passa a ser reprovado
            }

            Console.WriteLine(situacao);
        }
    }
}
