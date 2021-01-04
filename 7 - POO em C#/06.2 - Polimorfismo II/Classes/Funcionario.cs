using System;

namespace Code.Classes
//Sobrecarga são metodos diferentes, com um mesmo nome, aonde podemos passar outros paramentros para o metodo.
{
    public class Funcionario
    {
        public string[] _lista = {"Rafael", "Soares", "Gomes"};

        public void Mostrar(){
            foreach (var item in _lista){
                Console.WriteLine(item);
            }
        }

        public void Mostrar(int indice){
            Console.WriteLine($"Resultado de busca (indice): {indice}");
        }

        public void Mostrar(string busca){
            foreach (var item in _lista){
                if(item == busca){
                    Console.WriteLine($"Resultado de busca (nome): {busca}");
                }
            }
        }
    }
}