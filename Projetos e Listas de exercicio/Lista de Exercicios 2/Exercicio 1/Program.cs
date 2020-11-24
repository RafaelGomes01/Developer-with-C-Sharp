using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).
            Console.WriteLine("Digite o ano atual, e seu ano de nascimento");
            Console.Write("Ano Atual: ");
            int anoAtual = int.Parse(Console.ReadLine());
            Console.Write("Ano de Nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());

            int idade = anoAtual - anoNascimento;

            if(idade >= 16){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Você ja tem idade para votar.");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você ainda nao tem idade para votar, espere até completar 16 anos no minimo.");
                Console.ResetColor();
            }
        }
    }
}
