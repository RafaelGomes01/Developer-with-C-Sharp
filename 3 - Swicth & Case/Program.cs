using System;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
           // Perguntar a operação
            Console.WriteLine("Qual operação deseja realizar? \nSoma, Subtração, Multiplicação, Divisão");
            string operação = Console.ReadLine().ToLower();

            // Pedir o primeiro numero
            Console.WriteLine("Digite o primeiro numero");
            float num1 = float.Parse(Console.ReadLine());

            //Pedir o segundo numero
            Console.WriteLine("Digite o segundo numero");
            float num2 = float.Parse(Console.ReadLine());

            //Fazer o Calculo
            float resultado = 0;
        
            switch(operação){
                case "soma":
                    resultado = num1 + num2;
                    break;

                case "subtração":
                    resultado = num1 - num2;
                    break;

                case "multiplicação":
                    resultado = num1 * num2;
                    break;
                
                case "divisão":
                    resultado = num1 / num2;
                    break;
                
                default:
                    operação = "invalida";
                    break;
            }

            // Mostrar o resultado
            if(operação != "invalida"){
                 Console.WriteLine($"Calculo: {num1} com {num2} = {resultado}");
            }else{
                Console.WriteLine("Operação Invalida");
            }
        }
    }
}
