using System;
using Code.Controllers;
using Code.Models;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produto = new ProdutoController();
            produto.ListarProduto();
        }
    }
}
