using System;
using Code.Classes;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(1, "The Last of Us" , 399f);
            Produto p2 = new Produto(2, "FIFA 20" , 199f);
            Produto p3 = new Produto(3, "GTA V" , 299f);
            Produto p4 = new Produto(4, "Rocket League" , 399f);

            Carrinho car = new Carrinho();
            car.AdicionarProduto(p1);
            car.AdicionarProduto(p2);
            car.AdicionarProduto(p3);
            car.AdicionarProduto(p4);

            car.MostrarProdutos();

            Produto p5 = new Produto(5, "Mario Bross", 90f);

            car.AlterarItem(1, p5);

            car.MostrarProdutos();
        }
    }
}
