using System;
using Code.classes;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho cart = new Carrinho();

            Produto p1 = new Produto();
            p1.Codigo = 123;
            p1.Nome = "PS5";
            p1.Preco = 10000;

            Produto p2 = new Produto();
            p2.Codigo = 124;
            p2.Nome = "Xbox Series X";
            p2.Preco = 5000;

            Produto p3 = new Produto();
            p3.Codigo = 125;
            p3.Nome = "Nintendo Switch";
            p3.Preco = 3000;

            cart.Cadastrar(p1);
            cart.Cadastrar(p2);
            cart.Listar();

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("");
            cart.Alterar(p2.Codigo, p3);
            cart.Listar();

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("");
            cart.Deletar(p1.Codigo);
            cart.Listar();
        }
    }
}
