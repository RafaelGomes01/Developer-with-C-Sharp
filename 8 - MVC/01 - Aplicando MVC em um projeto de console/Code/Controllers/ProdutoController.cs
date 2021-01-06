using Code.Models;
using Code.Views;

namespace Code.Controllers
{
    public class ProdutoController
    {
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void ListarProduto(){
            produtoView.Listar(produto.Ler());
        }

        public void Cadastrar(){
            produto.Inserir(produtoView.CadastrarProduto());
        }
    }
}