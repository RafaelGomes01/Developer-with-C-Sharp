using System;
using System.Collections.Generic;

namespace Code
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<Marca> ListaDeMarcas = new List<Marca>();
        
        public Marca Cadastrar(){
            // Instanciar o Objeto
            Marca novaMarca = new Marca();

            // Pedir o codigo ao usuario
            Console.WriteLine("Digite o codigo da marca: ");
            novaMarca.Codigo = int.Parse(Console.ReadLine());

            // Pedir o nome ao usuario
            Console.WriteLine("Digite o nome da marca: ");
            novaMarca.NomeMarca = Console.ReadLine();

            // Definir o horario do sistema
            DataCadastro = DateTime.UtcNow;

            ListaDeMarcas.Add(novaMarca);

            return novaMarca;
        }

        public void Listar(){
            Console.ForegroundColor = ConsoleColor.Magenta;
            
            foreach (Marca item in ListaDeMarcas){
                System.Console.WriteLine($"Codigo: {item.Codigo}");
                System.Console.WriteLine($"Marca: {item.NomeMarca}");
                System.Console.WriteLine($"Data do Cadastro: {item.DataCadastro}");
            }

            Console.ResetColor();
        }
        
        public void Deletar(int cod){
            Marca marcaDelete = ListaDeMarcas.Find(x => x.Codigo == cod);
            ListaDeMarcas.Remove(marcaDelete);
        }

    }
}