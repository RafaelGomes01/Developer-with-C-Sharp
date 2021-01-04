using System;
using System.Collections.Generic;
using Code.classes;

namespace Code
{
    public class Carrinho : ICarrinho
    {

        List<Produto> carrinho = new List<Produto>();

        
        public void Alterar(int cod, Produto novoProduto)
        {
            carrinho.Find(x => x.Codigo == cod).Nome = novoProduto.Nome;
            carrinho.Find(x => x.Codigo == cod).Preco = novoProduto.Preco;
            carrinho.Find(x => x.Codigo == cod).Codigo = novoProduto.Codigo;
        }

        public void Cadastrar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Deletar(int cod)
        {
            Produto prodDelete = carrinho.Find(x => x.Codigo == cod);
            if(prodDelete != null){
                carrinho.Remove(prodDelete);
            }
        }

        public void Listar()
        {
            if(carrinho != null){
                foreach (Produto item in carrinho)
                {
                    Console.WriteLine($"Código: {item.Codigo}");
                    Console.WriteLine($"Produto: {item.Nome} ");
                    Console.WriteLine($"Preço: {item.Preco}");
                }
            }else
            {
                Console.WriteLine("O carrinho está vazio!");
            }
        }
    }
}