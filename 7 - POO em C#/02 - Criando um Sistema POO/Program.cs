using System;

namespace Criando_um_sistema_orientado_à_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //Atributos dos Objetos.
            Celular celular1 = new Celular();
            celular1.cor = "Preto";
            celular1.modelo = "Samsung Galaxy S10";
            celular1.ligado = false;
            celular1.tamanho = 12.10f;

            Celular celular2 = new Celular();
            celular1.cor = "Rosa";
            celular1.modelo = "Iphone 12";
            celular1.ligado = false;
            celular1.tamanho = 15.10f;

            Celular celular3 = new Celular();
            celular1.cor = "Azul";
            celular1.modelo = "Moto G9";
            celular1.ligado = false;
            celular1.tamanho = 16.10f;

            Celular celular4 = new Celular();
            celular1.cor = "Branco";
            celular1.modelo = "LG10";
            celular1.ligado = false;
            celular1.tamanho = 18.10f;
            
            string modelo;
            int menuEscolha;
            bool menuLoop = true;
            bool ligado = true;
            string ligarCelular;
            bool desligar;
            string nomeLigacao;

            //Metodos, Ações aos Objetos.

            Console.WriteLine("Digite qual é o modelo de seu celular");
            Console.WriteLine("Modelos: Samsung Galaxy S10 || Iphone 12 || Moto G9 || LG10 ||");
            Console.WriteLine("Modelos:         S          ||     I     ||    M    ||   L  ||");
            Console.Write("Resposta: ");
            modelo = Console.ReadLine().ToLower();

            switch (modelo){
                case "s":
                    // Celular1
                    Console.WriteLine("\n==================================");
                    Console.WriteLine("Propriedades de seu aparelho");
                    Console.WriteLine($"Cor: {celular1.cor}");
                    if(celular1.ligado == true){Console.WriteLine($"Celular: Ligado");}
                    else{
                        Console.WriteLine($"Celular: Desligado");
                            ligado = false;
                        }
                    Console.WriteLine($"Tamanho: {celular1.tamanho}");
                    Console.WriteLine("==================================\n");
                    break;
                
                case "i":
                    // Celular2
                    Console.WriteLine("\n==================================");
                    Console.WriteLine("Propriedades de seu aparelho");
                    Console.WriteLine($"Cor: {celular2.cor}");
                    if(celular2.ligado == true){Console.WriteLine($"Celular: Ligado");}
                    else{
                        Console.WriteLine($"Celular: Desligado");
                            ligado = false;
                        }
                    Console.WriteLine($"Tamanho: {celular2.tamanho}");
                    Console.WriteLine("==================================\n");
                    break;
                
                case "m":
                    // Celular1
                    Console.WriteLine("\n==================================");
                    Console.WriteLine("Propriedades de seu aparelho");
                    Console.WriteLine($"Cor: {celular3.cor}");
                    if(celular3.ligado == true){Console.WriteLine($"Celular: Ligado");}
                    else{
                        Console.WriteLine($"Celular: Desligado");
                            ligado = false;
                        }
                    Console.WriteLine($"Tamanho: {celular3.tamanho}");
                    Console.WriteLine("==================================\n");
                    break;
                
                case "l":
                    // Celular2
                    Console.WriteLine("\n==================================");
                    Console.WriteLine("Propriedades de seu aparelho");
                    Console.WriteLine($"Cor: {celular4.cor}");
                    if(celular4.ligado == true){Console.WriteLine($"Celular: Ligado");}
                    else{
                        Console.WriteLine($"Celular: Desligado");
                            ligado = false;
                        }
                    Console.WriteLine($"Tamanho: {celular4.tamanho}");
                    Console.WriteLine("==================================\n");
                    break;
            }

            if(ligado == false){
                do{
                    Console.WriteLine("========================================================");
                    Console.WriteLine("Por favor ligue seu celular escrevendo ligar no terminal");
                    Console.Write("Resposta: ");
                    ligarCelular = Console.ReadLine().ToLower();
                    Console.WriteLine("");
                }while(ligarCelular != "ligar");
            }

            do{
                Console.WriteLine("\n==========MENU==========");
                Console.WriteLine("1 - Desligar");
                Console.WriteLine("2 - Fazer Ligação");
                Console.WriteLine("3 - Enviar Mensagem");
                Console.WriteLine("========================\n");
                Console.WriteLine("Selecione uma opção");
                Console.Write("Resposta: ");
                menuEscolha = int.Parse(Console.ReadLine());

                switch(menuEscolha){
                    case 1:
                        desligar = celular1.Desligar();
                        Console.WriteLine("Obrigado pela preferencia :)");
                        menuLoop = desligar;
                        break;
                    
                    case 2:
                        Console.WriteLine("Digite o nome para quem deseja ligar");
                        nomeLigacao = Console.ReadLine();
                        Console.WriteLine(celular1.FazerLigacao(nomeLigacao));
                        break;
                    
                    case 3:
                        Console.WriteLine("Digite o nome para quem deseja enviar uma mensagem, e seu conteudo.");
                        Console.Write("Nome: ");
                        string nomeMensagem = Console.ReadLine();
                        Console.Write("Mensagem: ");
                        string conteudoMensagem = Console.ReadLine();
                        Console.WriteLine(celular1.MandarMensagem(nomeMensagem, conteudoMensagem));
                        break;

                }
            }while(menuLoop);
        }
    }
}
