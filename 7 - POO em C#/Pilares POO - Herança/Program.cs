using System;
using Codigo.Classes;

namespace Codigo
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            PessoaJuidica pj = new PessoaJuidica();

            pf.cpf = "457.720.318-99";
            pf.nome = "Rafael Gomes";
            Console.WriteLine(pf.DarBoasVindas());
        }
    }
}
