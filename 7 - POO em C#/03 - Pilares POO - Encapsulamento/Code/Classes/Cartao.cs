namespace Code.Classes
{
    public class Cartao
    {
        //Private

        private string numero;

        public string Numero{
            get{return numero;} // Capturar valor
            set{numero = value;} // Definir valor
        }

        private string nomeTitular;

        public string NomeTitular{get{return nomeTitular;} set{nomeTitular = value;}}

        private string bandeira;

        public string Bandeira{get{return bandeira;} set{bandeira = value;}}

        protected string token = "qwertyui";

        public string Token{get{return token;}}

        private string cvv;

        public string Cvv{get;set;}

        protected float limite = 5000;

        public string Limite{get;set;}

        public string RegistrarCompra(bool validado){
            return "Ola mundo";
        }

        private bool ValidarCompra(float saldo){
            return true;
        }

        protected string ValidarToken(string teste){
            return "";
        }

        
    }
}