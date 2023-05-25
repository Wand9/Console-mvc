using console_MVC;
using console_MVC.Models;


namespace console_MVC
{
    public class ProdutoView
    {

        //metodo para exibir os dados da lista de produtos
        public void Listar(List<Produto>produto)
        {
            Console.Clear();
            //foreach para ler a lista passada como parametro do metodo
            foreach (var item in produto)
            {
                Console.WriteLine($" Codigo: {item.Codigo}");
                Console.WriteLine($"");
                
                Console.WriteLine($" Nome: {item.Nome}");
                Console.WriteLine($"");
                
                Console.WriteLine($" Preco: {item.Preco}");
                Console.WriteLine($"");
                
                
            }
        }

        public Produto Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"Informe o codigo: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o Nome: ");
            novoProduto.Nome = Console.ReadLine();

            Console.WriteLine($"Informe o preco: ");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            return novoProduto;
        }

    }
}