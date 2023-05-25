using console_MVC.Controller;
using console_MVC.Models;

Produto p = new Produto();

//instancia do objeto produto
Produto P = new Produto();

//instancia do objeto produtoController
ProdutoController controller = new ProdutoController();

//chamada do metodo controlador 
controller.CadastrarProduto();

//chamada do metodo controlador
controller.ListarProdutos();