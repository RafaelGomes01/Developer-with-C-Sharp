using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Álcool:
            //  até 20 litros, desconto de 3% por litro Álcool
            //  acima de 20 litros, desconto de 5% por litro

            //Gasolina:
            //  até 20 litros, desconto de 4% por litro Gasolina
            //  acima de 20 litros, desconto de 6% por litro

            //Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
            //da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
            //sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.

            float total = 0;
            bool continuar = true;

            while(continuar == true){
                
                Console.WriteLine("----------------------------");
                Console.WriteLine("Calculadora de Descontos");
                Console.Write("Qnt. Litros: ");
                float litros = float.Parse(Console.ReadLine());
                Console.Write("Tipo Combustivel (A-Alcool, G-Gasolina): ");
                string tipo = Console.ReadLine().ToLower();
                
                if(tipo == "a" && litros <= 20){
                    // Desconto = 3% por litro = 1L = 4,90
                    float preçoAlcool = 4.90F; 
                    float noDesconto = litros * preçoAlcool;
                    float desconto = noDesconto * 0.03f;
                    total = noDesconto - desconto;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("O preço total a pagar é de: " + total);
                    Console.ResetColor();
                }

                else if(tipo == "a" && litros > 20){
                    // Desconto = 5% por litro = 1L = 4,90
                    float preçoAlcool = 4.90F; 
                    float noDesconto = litros * preçoAlcool;
                    float desconto = noDesconto * 0.05f;
                    total = noDesconto - desconto;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("O preço total a pagar é de: " + total);
                    Console.ResetColor();
                }

                else if(tipo == "g" && litros <=20){
                    // Desconto = 4% por litro = 1L = 5,30
                    float preçoGasolina = 5.30F; 
                    float noDesconto = litros * preçoGasolina;
                    float desconto = noDesconto * 0.04f;
                    total = noDesconto - desconto;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("O preço total a pagar é de: " + total);
                    Console.ResetColor();
                }

                else if(tipo == "g" && litros > 20){
                    // Desconto = 6% por litro = 1L = 5,30
                    float preçoGasolina = 5.30F; 
                    float noDesconto = litros * preçoGasolina;
                    float desconto = noDesconto * 0.06f;
                    total = noDesconto - desconto;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("O preço total a pagar é de: " + total);
                    Console.ResetColor();
                }

                else{
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Alguma informação foi colocada de maneira errada tente novamente");
                    Console.ResetColor();
                }

                Console.WriteLine("----------------------------");
                Console.WriteLine("Deseja refazer a operação");
                string resposta = Console.ReadLine().ToLower();
                
                if(resposta != "sim"){
                    continuar = false;
                    Console.WriteLine("----------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Agradeçemos a preferencia :)");
                    Console.WriteLine("Att. Equipe Rafael Gomes");
                    Console.ResetColor();
                    Console.WriteLine("----------------------------");
                }else{}
            }
        }
    }
}
