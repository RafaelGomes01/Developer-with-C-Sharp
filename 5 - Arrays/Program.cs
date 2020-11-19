using System;

namespace Aula_41___19._11._20___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] listaDeCompras = {"maçã", "batata", "cenoura"};
           double[] preços = {1.1, 2.3, 4.5};
           int[] idades = {16, 17, 18};

           string[] nomes = new string[5]; //Nova lista de string, vazia e com 5 itens

        //    Console.WriteLine("Trocar batata por qual item");
        //    string item = Console.ReadLine();
        //    listaDeCompras[1] = item;
        //    Console.WriteLine(listaDeCompras.Length);
            Console.WriteLine("--------------------------------------");
            for (var i = 0; i < listaDeCompras.Length; i++){
                Console.WriteLine(listaDeCompras[i]);
            }
            Console.WriteLine("--------------------------------------");
            for (var i = 0; i < preços.Length; i++){
                Console.WriteLine(preços[i]);
            }
            Console.WriteLine("--------------------------------------");
            for (var i = 0; i < idades.Length; i++){
                Console.WriteLine(idades[i]);
            }
        }
    }
}