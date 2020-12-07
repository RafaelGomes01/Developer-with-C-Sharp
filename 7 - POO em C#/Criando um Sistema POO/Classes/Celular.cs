namespace Criando_um_sistema_orientado_à_objetos
{
    public class Celular

        // - Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
        // - Só será possível executar tais métodos se o celular estiver ligado.
        // - Suba o projeto para um repositório no Github, com o título "AulaPOOCelular".
        // - Envie o link do repositório como entrega desta atividade.
    {
        //Atributos da classe Celular
        public string cor;
        public string modelo;
        public float tamanho;
        public bool ligado;

        public bool Desligar(){
            return false;
        }

        public string FazerLigacao(string nomeLigacao){
            return "Ligando para: " + nomeLigacao;
        }

        public string MandarMensagem(string nomeMensagem, string conteudoMensagem){
            return "Mensagem enviada para " + nomeMensagem + " com a seguinte mensagem \n" + conteudoMensagem +":";
        }



    }
}