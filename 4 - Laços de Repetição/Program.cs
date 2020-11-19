using System;

namespace Aula_39___17._11._20___While
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escreva um algoritmo que receba o número inteiro e exiba sua tabuada até 10
        
            string repetir = "sim";
            while(repetir == "sim"){
                //Entrada de dados
                Console.WriteLine("Digite qual tabuada é para ser exibida - 0 a 10");
                int tabuada = int.Parse(Console.ReadLine());

                // Calculos
                for(int i = 0; i < 11; i++){
                    int resultado = tabuada * i;

                    //Saida para o Usuario
                    Console.WriteLine($"{tabuada} X {i} = {resultado}");
                }

                Console.WriteLine("Deseja repetir a consulta ?");
                repetir = Console.ReadLine();

                if(repetir != "sim"){Console.WriteLine("Agradecemos pela preferencia :)");}
            }
            
        }
    }
}
