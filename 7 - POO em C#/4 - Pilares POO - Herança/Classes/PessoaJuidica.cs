namespace Codigo.Classes
{
    public class PessoaJuidica : Pessoa // : --> Herdar de uma classe
    {
        public string cnpj;
        public string inscricaoEstadual;

        public bool ValidarCNPJ(string documento){
            if(documento != " "){
                return true;
            }
            return false;
        }
    }
}