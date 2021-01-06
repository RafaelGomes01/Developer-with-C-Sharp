using System;
using System.Collections.Generic;
using Code.Models;

namespace Code.Views
{
    public class ProdutoView
    {
        public void Listar(List<Produto> lista){
            foreach (Produto item in lista)
            {
                Console.WriteLine($"Produto {item.Codigo}: {item.Nome} - {item.Preco}");
            }
        }

        public Produto CadastrarProduto(){
            
            Produto produto = new Produto();
            Console.Write($"Digite um codigo: ");
            produto.Codigo = int.Parse(Console.ReadLine());

            Console.Write($"Digite um nome: ");
            produto.Nome = Console.ReadLine();
            
            Console.Write($"Digite o preço: ");
            produto.Preco = float.Parse(Console.ReadLine());

            return produto;
        }
    }
}