using System;
using Code.Controllers;
using Code.Models;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            ProdutoController prod = new ProdutoController();
            prod.Cadastrar();
            prod.ListarProduto();
        }
    }
}
