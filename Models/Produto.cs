using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace console_MVC.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        //Caminho da pasta e do arquivo definido
        private const string PATH = "Database/Produto.csv";
        
        // Criar um construtor
        public Produto()
        {
            //Obter o caminho da pasta
            string pasta = PATH.Split("/")[0]; //"Database"

            //Se nao existir uma pasta Database, entao cria-se uma
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            //Se nao existir um arquivo csv no caminho, entao cria-se um
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }
        public List<Produto> Ler()
        {
            //Instanciar uma lista de produto
            List<Produto> produtos = new List<Produto>();

            //array de string que recebe cada linha do csv
            string[] linhas = File.ReadAllLines(PATH);

            //Para a leitura das linhas
            foreach (string item in linhas)
            {
                //antes do split
                //001;Coca;6,50

                //Array que recebe os itens da linha separado por ";"
                string[] atributos = item.Split(";");

                //apos o split
                //atributo [0] = "001"
                //atributo [1] = "Coca"
                //atributo [2] = "6,50"

                //instancia de objeto
                Produto p = new Produto();

                //atributo os dados dentro de um objeto
                p.Codigo = int.Parse(atributos[0]);//001
                p.Nome = atributos[1];//"Coca"
                p.Preco = float.Parse(atributos[2]);//6,50f

                //adicion os objetos dentro da lista 
                produtos.Add(p);
            }
            //retorna a lista de produtos
            return produtos; 
        }

        //metodo para preparar a linha do csv
        public string prepararLinhasCSV(Produto p)
        {
            return $"{p.Codigo};{p.Nome};{p.Preco}";
        }

        //metodo para inserir um produto no arquivo csv
        public void Inserir(Produto p)
        {
            //array que vai armazenar as linhas(cada "objeto")
            string[] linhas = {prepararLinhasCSV(p)};

            //vai ate o arquivo e insere todas as linhas
            File.AppendAllLines(PATH, linhas); 
        }

        //lista de produtos chamada pela

        //metodo controlador para acessar o cadastro de produto 
        

    }
}