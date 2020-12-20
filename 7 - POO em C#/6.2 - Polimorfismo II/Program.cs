using System;
using Code.Classes;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Funcionario fun = new Funcionario();
            fun.Mostrar();
            fun.Mostrar(2);
            fun.Mostrar("Rafael");
        }
    }
}