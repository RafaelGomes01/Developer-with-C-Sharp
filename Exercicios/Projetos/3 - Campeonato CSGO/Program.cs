using System;

namespace Campeonato_CSGO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Bem vindo a seletive para o time de Counter-Strike");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Você gostaria de participar ? Sim ou Não");
            string resposta1 = Console.ReadLine();

            if (resposta1 == "Sim" || resposta1 == "sim" || resposta1 == "SIM"){
                Console.WriteLine("Que legal, agora vamos analizar seu curriculo");
                Console.WriteLine("Insira sua media escolar");
                int media = int.Parse(Console.ReadLine());
                Console.WriteLine("Digita sua quantidade de faltas");
                int faltas = int.Parse(Console.ReadLine());
                
                if(media>=50 && faltas<=10){
                    Console.WriteLine("Parabens, seja bem vindo");
                }else{
                    Console.WriteLine("Que pena, você precisa melhorar suas notas e faltas");
                }
            }else{
                Console.WriteLine("Blz, Passar bem");
            }
        }
    }
}
