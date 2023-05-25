using console_MVC.Models;
using console_MVC;

namespace console_MVC.Controller
{
    public class ProdutoController
    {
        //instanciar objeto produto e produtoView
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        //metodo controlador para acessar a listagem de produtos
        public void ListarProdutos()
        {
            //lista de produtos chamada pela model
            List<Produto> produtos = produto.Ler();

            //chamada do metodo de exibicao(view) recebendo como argumento a 
            produtoView.Listar(produtos);
        }

        //metodo controlador para acessar o cadastro de produto
        public void CadastrarProduto()
        {
            //chamada para a view que recebe cada objeto a ser inserido no csv 
            Produto novoProduto = produtoView.Cadastrar();

            //chamada para a model inserir esse objeto no csv
            produto.Inserir(novoProduto);
        }

    }
}