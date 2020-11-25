using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
            // preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
            // desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
            // - Se quantidade <= 5 o desconto será de 2%
            // - Se quantidade > 5 e quantidade <=10 o desconto será de 3%
            // - Se quantidade > 10 o desconto será de 5%

            Console.WriteLine("Digite o nome, a quantidade e o preço unitario do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Quantidade: ");
            float quantidade = float.Parse(Console.ReadLine());
            Console.Write("Preço: ");
            float preço = float.Parse(Console.ReadLine());

            float total = quantidade * preço;

            if(quantidade <= 5){
                //Desconto 2%
                float desconto = total * 0.02f;
                float totalPagar = total - desconto;
                Console.WriteLine("O valor total a pagar é de: " + total);
                Console.WriteLine("Seu desconto é de: " + desconto);
                Console.WriteLine("Com o desconto esse preço fica: " + totalPagar);
            }

            else if(quantidade >5 && quantidade <=10){
                //Desconto 3%
                float desconto = total * 0.03f;
                float totalPagar = total - desconto;
                Console.WriteLine("O valor total a pagar é de: " + total);
                Console.WriteLine("Seu desconto é de: " + desconto);
                Console.WriteLine("Com o desconto esse preço fica: " + totalPagar);
            }

            else if(quantidade > 10){
                //Desconto 5%
                float desconto = total * 0.05f;
                float totalPagar = total - desconto;
                Console.WriteLine("O valor total a pagar é de: " + total);
                Console.WriteLine("Seu desconto é de: " + desconto);
                Console.WriteLine("Com o desconto esse preço fica: " + totalPagar);
            }

            else{
                Console.WriteLine("Digite um valor valido");
            }
        }
    }
}
