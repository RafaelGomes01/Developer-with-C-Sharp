using System;
using Code.Classes;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encapsulamento - Capacidade de esconder tudo que não desejamos que o usuario tenha acesso
            //Exemplo pilula dor de cabeça - Sabemos para que serve, mas não importa como ela foi feita, ou como funciona no corpo.

            // mc.Numero = "11212"; //Utilizado Set
            // Console.Write(mc.Numero); // Utilizado Get

            Mastercard mc = new Mastercard();

            mc.NomeTitular = "Rafael Gomes";
            mc.Numero = "11212";
            mc.Bandeira = "MasterCard";

            Console.WriteLine($"{mc.Token}");

            
        }
    }
}
