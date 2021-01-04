namespace Codigo.Classes
{
    public class PessoaFisica : Pessoa // : --> Herdar de uma classe
    {
        public string cpf;
        public string rg;

        public bool ValidarCpf(string documento){
            if(documento != ""){
                return true;
            }
            return false;
        }
    }
}