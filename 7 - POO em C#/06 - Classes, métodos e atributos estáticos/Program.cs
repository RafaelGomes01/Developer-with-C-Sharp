using System;
using System.Threading;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            // Classes estaticas não podem ser instanciadas
            // Quando usamos classes estaticas --> Sistema de conversão, sistemas que não estão relacionadas 
            // diretamente com o core da aplicação, Featueres que podem servir para qualquer tipo de aplicação

            // Quando não criamos uma classe estatica --> Quando essa classe fazer parte do Core da aplicação, objetos e classes especificos de um tipo de aplicação.

            bool cancelar = false;

            do{
                Console.Clear();
                Console.WriteLine("==================================");
                Console.WriteLine("[1] - Conversor Real para Dolar");
                Console.WriteLine("[2] - Conversor Dolar para Real");
                Console.WriteLine("[3] - Conversor Real para Euro");
                Console.WriteLine("[4] - Conversor Euro para Real");
                Console.WriteLine("[5] - Cancelar");
                Console.WriteLine("==================================");
                Console.Write("Resposta: ");
                int menuEscolha1 = int.Parse(Console.ReadLine());

                switch (menuEscolha1)
                {
                    case 1:
                        
                        float valorConverterReal;
                        Console.WriteLine("Digite o valor em reais para converter para dolar");
                        Console.Write("Valor: ");
                        valorConverterReal = float.Parse(Console.ReadLine());
                        Console.WriteLine($"{valorConverterReal} em dolares é igual a: {Convesor.ConverterRealParaDolar(valorConverterReal)} Reais");
                        Thread.Sleep(3000);
                        break;
                    
                    case 2:
                        
                        float valorConverterDolar;
                        Console.WriteLine("Digite o valor em dolar para converter para real");
                        Console.Write("Valor: ");
                        valorConverterDolar = float.Parse(Console.ReadLine());
                        Console.WriteLine($"{valorConverterDolar} em reais é igual a: {Convesor.ConverterDolarParaReal(valorConverterDolar)} Dolares");
                        Thread.Sleep(3000);
                        break;
                    
                    case 3:
                        
                        float valorConverterReal2;
                        Console.WriteLine("Digite o valor em Euros para converter para Reais");
                        Console.Write("Valor: ");
                        valorConverterReal2 = float.Parse(Console.ReadLine());
                        Console.WriteLine($"{valorConverterReal2} em Euros é igual a: {Convesor.ConverterRealParaDolar(valorConverterReal2)} Reais");
                        Thread.Sleep(3000);
                        break;
                    
                    case 4:
                        
                        float valorConverterEuro;
                        Console.WriteLine("Digite o valor em Reais para converter para Euros");
                        Console.Write("Valor: ");
                        valorConverterEuro = float.Parse(Console.ReadLine());
                        Console.WriteLine($"{valorConverterEuro} em reais é igual a: {Convesor.ConverterDolarParaReal(valorConverterEuro)} Euros");
                        Thread.Sleep(3000);
                        break;
                    
                    case 5:
                        cancelar = true;
                        break;

                    default:
                        Console.WriteLine("Insira um valor valido");
                        break;
                }
            }while(cancelar == false);
            
        }
    }
}
