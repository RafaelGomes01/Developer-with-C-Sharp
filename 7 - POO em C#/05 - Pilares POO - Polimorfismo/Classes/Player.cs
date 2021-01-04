namespace Code.Classes
{
    public class Player
    {
        private float velocidade;
        private float forcaPulo;

        public virtual string Correr(){
            return "Velocidade = 10";
        }

        public virtual string Pular(){
            return "Salto = 1";
        }
    }
}