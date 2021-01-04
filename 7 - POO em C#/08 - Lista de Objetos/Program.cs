using System;
using Code.Classes;
using System.Collections.Generic;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar a Lista.
            List<Produto> produtos = new List<Produto>();
            
            // Adicionar itens a lista com o metodo construtor.
            produtos.Add(new Produto(1, "S20 Plus", 3700f));
            produtos.Add(new Produto(2, "S20", 3300f));
            produtos.Add(new Produto(3, "S10 Plus", 2800f));
            produtos.Add(new Produto(4, "S10", 2700f));
            produtos.Add(new Produto(5, "S10e", 2300f));

            // Adicionar itens a lista com os atributos da classe.
            Produto iphone = new Produto();
            iphone.Codigo = 6;
            iphone.Nome = "Iphone 6";
            iphone.Preco = 1200f;
            produtos.Add(iphone);

            // Remover um produto de acordo com seu indice.
            produtos.RemoveAt(1);

            // Remover um produto de acordo com uma validação lambda.
            produtos.RemoveAll(x => x.Nome == "Iphone 6");

            // Exibir a lista de produtos.
            foreach (Produto p in produtos){
                Console.WriteLine($"{p.Nome} - R${p.Preco}");
            }

            

            



        }
    }
}
