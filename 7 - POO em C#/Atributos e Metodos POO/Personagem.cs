namespace Atributos_e_Metodos_POO
{
     public class Personagem
    {
        public string nome;
        public int idade;
        public string armadura;
        public string iA = "Jarvis";
        public int vida = 100;
        public int Ataque1(){
            return 100;
        }
        
        public int Ataque2(){
            return 20;
        }

        public int Defesa(int ataque){
            this.vida = this.vida - ataque;
            return this.vida = this.vida - ataque;
        }
    }
}