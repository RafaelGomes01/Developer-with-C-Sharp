using System;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome"); // Comando para escrever na tela (Digite seu nome).
            string a = Console.ReadLine(); // Variavel armazenando oque o usuario escreveu na linha (nomeDoUsuario).
            Console.WriteLine("Bem vindo: " + a); // Comando para escrever na tela (Bem vindo + nomeDoUsuario).

            //Programa - Soma de dois números
            Console.WriteLine("Digite o primeiro numero");  // Comando para escrever na tela (Digite o numero 1).
            int numero1 = int.Parse(Console.ReadLine()); // Variavel transformada de string para int (Parse()) e armazenando oque o usuario escreveu na linha (numero1).
            
            Console.WriteLine("Digite o segundo numero"); // Comando para escrever na tela (Digite o numero 2).
            int numero2 = int.Parse(Console.ReadLine()); // Variavel transformada de string para int (Parse()) e armazenando oque o usuario escreveu na linha (numero2).

            int resultado = numero1 + numero2; // Variavel que vai armazenar a soma entre o numero1 e numero2 (Resultado)

            Console.WriteLine(numero1 + " + " + numero2 + " = " + resultado); // Comando para escrever na tela (numero1 + numero2 = resultado).
        }
    }
}
