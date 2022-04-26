using Controller;
using Model;
using System;
using System.IO;

namespace View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada = "";
            Console.WriteLine("Bem vindo ao Vendas MVC");
            while (entrada != "0")
            {

                Console.WriteLine("Digite 1 para Categorias");
                Console.WriteLine("Digite 2 para Produtos");


                Console.WriteLine("Digite 0 para sair");
                entrada = Console.ReadLine();

                if (entrada == "1") //Categorias
                    ExibirMenuCategoria();

                if (entrada == "2") //Produtos
                    ExibirMenuProdutos();

            }

        }

        public static void ExibirMenuCategoria()
        {
            CategoriaController categoriaController = new CategoriaController();
            Console.WriteLine("Digite 1 para Incluir");
            Console.WriteLine("Digite 2 para Listar");
            Console.WriteLine("Digite 3 para Excluir");
            Console.WriteLine("Digite 4 para Editar");
            string entrada = Console.ReadLine();
            if (entrada == "1")
            {
                Console.Write("Digite o nome da Categoria: ");
                entrada = Console.ReadLine();
                string mensagem = categoriaController.Incluir(new Categoria()
                {
                    Nome = entrada
                });

                if (mensagem != "")
                    Console.WriteLine(mensagem);
                else
                    Console.WriteLine("Categoria incluida com sucesso!");

            }
            else if (entrada == "2")
            {
                foreach (Categoria categoria in categoriaController.Listar())
                    Console.WriteLine($"{categoria.Id} - {categoria.Nome}");

            }
            else if (entrada == "3")
            {
                Console.Write("Digite o Id da Categoria a ser excluida: ");
                entrada = Console.ReadLine();
                string mensagem = categoriaController.Excluir(Int32.Parse(entrada));
                if (mensagem != "")
                    Console.WriteLine(mensagem);
                else
                    Console.WriteLine("Categoria excluida com sucesso!");

            }
            else if (entrada == "4")
            {
                Console.Write("Digite o Id da Categoria a ser editada: ");
                entrada = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Digite o novo nome da categoria: ");
                string novoNome = Console.ReadLine();
                string mensagem = categoriaController.Editar(Int32.Parse(entrada), novoNome);
                if (mensagem != "")
                    Console.WriteLine(mensagem);
                else
                    Console.WriteLine("Categoria editada com sucesso!");

            }
        }
        public static void ExibirMenuProdutos()
        {
            ProdutoController produtoController = new ProdutoController();
            CategoriaController categoriaController = new CategoriaController();
            Console.WriteLine("Digite 1 para Incluir");
            Console.WriteLine("Digite 2 para Listar");
            Console.WriteLine("Digite 3 para Excluir");
            Console.WriteLine("Digite 4 para Editar");
            string entrada = Console.ReadLine();
            if (entrada == "1")
            {

                Console.Write("Digite o nome do Produto: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o descricao do Produto: ");
                string descricao = Console.ReadLine();

                Console.Write("Digite uma preço para o produto: ");
                double preco = Double.Parse(Console.ReadLine());

                Console.WriteLine("Categorias: ");
                foreach (Categoria cat in categoriaController.Listar())
                    Console.Write($"{cat.Id} - {cat.Nome} / ");
                Console.WriteLine();
                Console.Write("Digite o Id da categoria: ");
                int categoriaId = Int32.Parse(Console.ReadLine());
                Categoria categoria = categoriaController.FiltrarCategoriaPorId(categoriaId);



                string mensagem = produtoController.Incluir(new Produto()
                {
                    Nome = nome,
                    Descricao = descricao,
                    Preco = preco,
                    Categoria = categoria
                });

                if (mensagem != "")
                    Console.WriteLine(mensagem);
                else
                    Console.WriteLine("Produto incluido com sucesso!");

            }
            else if (entrada == "2")
            {
                foreach (Produto produto in produtoController.Listar())
                    Console.WriteLine($"{produto.Id} - {produto.Nome} - {produto.Descricao} - {produto.Preco} - {produto.Estoque} - {produto.Categoria.Nome}");

            }
            /*else if (entrada == "3")
            {
                Console.Write("Digite o Id da Categoria a ser excluida: ");
                entrada = Console.ReadLine();
                string mensagem = produtoController.Excluir(Int32.Parse(entrada));
                if (mensagem != "")
                    Console.WriteLine(mensagem);
                else
                    Console.WriteLine("Categoria excluida com sucesso!");

            }
            else if (entrada == "4")
            {
                Console.Write("Digite o Id da Categoria a ser editada: ");
                entrada = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Digite o novo nome da categoria: ");
                string novoNome = Console.ReadLine();
                string mensagem = produtoController.Editar(Int32.Parse(entrada), novoNome);
                if (mensagem != "")
                    Console.WriteLine(mensagem);
                else
                    Console.WriteLine("Categoria editada com sucesso!");

            }*/
        }
    }
}
