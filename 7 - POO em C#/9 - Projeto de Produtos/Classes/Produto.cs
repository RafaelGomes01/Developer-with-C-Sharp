using System;
using System.Collections.Generic;

namespace Code.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca = new Marca();
        public Usuario Usuario = new Usuario();
        public List<Produto> ListaDeProdutos = new List<Produto>();

        public void Cadastrar(){
            Produto novoProduto = new Produto();

            Console.WriteLine($"Digite o Codigo do Produto: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o nome do produto: ");
            novoProduto.NomeProduto = Console.ReadLine();

            Console.WriteLine($"Digite o preco do produto: ");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            novoProduto.Marca = Marca.Cadastrar();

            novoProduto.Usuario = new Usuario();

            ListaDeProdutos.Add(novoProduto);
        }
        public void Listar(){
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (Produto item in ListaDeProdutos)
            {
                System.Console.WriteLine($"Codigo: {item.Codigo}");
                System.Console.WriteLine($"Marca: {item.NomeProduto}");
                System.Console.WriteLine($"Preço: {item.Preco}");
                System.Console.WriteLine($"Data do Cadastro: {item.DataCadastro}");
                System.Console.WriteLine($"Marca: {item.Marca.NomeMarca}");
                System.Console.WriteLine($"Cadastrado Por: {item.Usuario.Nome}");
            }

            Console.ResetColor();
        }
        public void Deletar(int cod){
            Produto prodDelete = ListaDeProdutos.Find(x => x.Codigo == cod);
            ListaDeProdutos.Remove(prodDelete);
        }
    }
}