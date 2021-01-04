namespace Code.classes
{
    public interface ICarrinho
    {
        void Cadastrar(Produto produto);

        void Listar();

        void Alterar(int cod, Produto novoProduto);

        void Deletar(int cod);
    }
}