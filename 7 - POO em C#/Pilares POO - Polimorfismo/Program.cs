using System;
using Code.Classes;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMan megaman = new MegaMan();
            Zero zero = new Zero();

            Console.WriteLine("==================");
            Console.WriteLine("Megaman");
            Console.WriteLine(megaman.Correr());
            Console.WriteLine(megaman.Pular());

            Console.WriteLine("==================");
            Console.WriteLine("Zero");
            Console.WriteLine(zero.Correr());
            Console.WriteLine(zero.Pular());
            Console.WriteLine("==================");
        }
    }
}
