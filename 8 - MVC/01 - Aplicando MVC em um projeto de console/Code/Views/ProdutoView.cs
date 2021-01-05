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
    }
}