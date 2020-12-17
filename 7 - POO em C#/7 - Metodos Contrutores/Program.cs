using System;
using Code.Classes;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
           // declaração de variaveis:
            int codigo;
            string nome;
            string descricao;
            int estoque;

            Console.Clear();
            Console.WriteLine("Cadastro de mercadoria");

            Console.Write("Codigo do produto: ");
            codigo = int.Parse(Console.ReadLine());
            
            Console.Write("Nome do produto: ");
            nome = Console.ReadLine();

            Console.Write("Descrição do produto: ");
            descricao = Console.ReadLine();

            Console.Write("Quantidade no estoque: ");
            estoque = int.Parse(Console.ReadLine());

            Produto produto1 = new Produto(codigo, nome, descricao, estoque);

            Console.WriteLine("\nInformações do produto:");
            Console.WriteLine("==================================");
            Console.WriteLine($"CÓDIGO: {produto1.Codigo}");
            Console.WriteLine($"NOME: {produto1.Nome}");
            Console.WriteLine($"DESCRIÇÃO: {produto1.Descricao}");
            Console.WriteLine($"ESTOQUE: {produto1.Estoque}");
            Console.WriteLine("==================================");
        }
    }
}
