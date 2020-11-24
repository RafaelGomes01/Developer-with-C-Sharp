using System;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
            // lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
            // pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
            // entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.

            bool repeat = true;
            string[] nomes = new string[11];

            Console.WriteLine("Digite 10 nomes para cadastro");

            for(var i = 1; i < 11; i++){
                Console.Write("Nome " + i + ": ");
                nomes[i] = Console.ReadLine();
            }

            while(repeat == true){
                Console.WriteLine("------------------------------");
                Console.WriteLine("Digite um nome para busca");
                Console.Write("Nome: ");
                string nomeProcura = Console.ReadLine();

                foreach(var nome in nomes){
                    if(nome == nomeProcura){
                        Console.WriteLine($"O nome {nomeProcura} está cadastrado.");
                        Console.WriteLine("------------------------------");
                        break;
                    }
                }

                Console.WriteLine("Deseja repetir");
                string repeat1 = Console.ReadLine().ToLower();
                if(repeat1 != "sim"){
                    Console.WriteLine("Obrigado pela Preferencia");
                    Console.WriteLine("Att Equipe Rafael Gomes");
                    break;
                }else{}
            }
        }
    }
}
