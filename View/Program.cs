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
                Console.WriteLine("Digite 2 para Cliente");
                Console.WriteLine("Digite 3 para Endereco");
                Console.WriteLine("Digite 4 para Fornecedor");
                Console.WriteLine("Digite 5 para Produtos");



                Console.WriteLine("Digite 0 para sair");
                entrada = Console.ReadLine();

                if (entrada == "1")
                    ExibirMenuCategoria();

                else if (entrada == "2")
                    ExibirMenuCliente();

                else if (entrada == "3")
                    ExibirMenuEndereco();

                else if (entrada == "4")
                    ExibirMenuFornecedor();

                else if (entrada == "5")
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
            else if (entrada == "3")
            {
                Console.Write("Digite o Id do Produto a ser excluido: ");
                string id = Console.ReadLine();
                string mensagem = produtoController.Excluir(Int32.Parse(id));
                if (mensagem != "")
                    Console.WriteLine(mensagem);
                else
                    Console.WriteLine("Categoria excluida com sucesso!");

            }
            else if (entrada == "4")
            {
                Console.Write("Digite o Id do Produto a ser editado: ");
                string id = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Digite o novo nome da categoria: ");
                string novoNome = Console.ReadLine();
                string mensagem = produtoController.EditarNome(Int32.Parse(id), novoNome);
                if (mensagem != "")
                    Console.WriteLine(mensagem);
                else
                    Console.WriteLine("Produto editado com sucesso!");

            }
        }

        public static void ExibirMenuCliente()
        {
            ClienteController clienteController = new ClienteController();
            Console.WriteLine("Digite 1 para Incluir");
            Console.WriteLine("Digite 2 para Listar");
            Console.WriteLine("Digite 3 para Excluir");
            Console.WriteLine("Digite 4 para Editar");
            string entrada = Console.ReadLine();

            if (entrada == "1")
            {
                EnderecoController enderecoController = new EnderecoController();

                Console.Write("Digite o nome do Cliente: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o CPF do Cliente: ");
                string cpf = Console.ReadLine();

                Console.WriteLine("Digite o id do Endereço do Cliente: ");
                int id = Int32.Parse(Console.ReadLine());
                Endereco endereco = enderecoController.FiltrarPorId(id);

                Console.Write("Digite o Telefone do Cliente: ");
                string telefone = Console.ReadLine();

                Console.Write("Digite o Email do Cliente: ");
                string email = Console.ReadLine();

                string mensagem = clienteController.Incluir(new Cliente()
                {
                    Nome = nome,
                    CPF = cpf,
                    Endereco = endereco,
                    Telefone = telefone,
                    Email = email
                });

                if (mensagem != "")
                    Console.WriteLine(mensagem);
                else
                    Console.WriteLine("Cliente incluído com sucesso!");
            }

            else if (entrada == "2")
            {
                foreach (Cliente cliente in clienteController.Listar())
                    Console.WriteLine($"{cliente.Id} - {cliente.Nome} - {cliente.CPF} - " +
                        $"{cliente.Endereco.Logradouro}, {cliente.Endereco.Numero}, {cliente.Endereco.Bairro}, " +
                        $"{cliente.Endereco.Complemento}, {cliente.Endereco.Cidade}, {cliente.Endereco.Estado}" +
                        $"{cliente.Endereco.CEP} - " +
                        $"{cliente.Telefone} - {cliente.Email}");
            }

            else if (entrada == "3")
            {
                Console.Write("Digite o Id do Cliente a ser excluido: ");
                string id = Console.ReadLine();
                string mensagem = clienteController.Excluir(Int32.Parse(id));
                if (mensagem != "")
                    Console.WriteLine(mensagem);
                else
                    Console.WriteLine("Cliente excluido com sucesso!");
            }
            else if (entrada == "4")
            {
                Console.Write("Digite o Id do Cliente a ser editado: ");
                string id = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Digite o novo nome do cliente: ");
                string novoNome = Console.ReadLine();
                string mensagem = clienteController.EditarNome(Int32.Parse(id), novoNome);
                if (mensagem != "")
                    Console.WriteLine(mensagem);
                else
                    Console.WriteLine("Cliente editado com sucesso!");
            }
        }
        public static void ExibirMenuEndereco()
        {
            EnderecoController enderecoController = new EnderecoController();
            Console.WriteLine("Digite 1 para Incluir");
            Console.WriteLine("Digite 2 para Listar");
            Console.WriteLine("Digite 3 para Excluir");
            Console.WriteLine("Digite 4 para Editar");
            string entrada = Console.ReadLine();

            if (entrada == "1")
            {
                Console.Write("Digite o nome do Logradouro: ");
                string logradouro = Console.ReadLine();

                Console.Write("Digite o número: ");
                string numero = Console.ReadLine();

                Console.Write("Digite o Bairro: ");
                string bairro = Console.ReadLine();

                Console.Write("Digite o complemento, caso haja: ");
                string complemento = Console.ReadLine();

                Console.Write("Digite a Cidade: ");
                string cidade = Console.ReadLine();

                Console.Write("Digite o Estado: ");
                string estado = Console.ReadLine();

                Console.Write("Digite o CEP: ");
                string cep = Console.ReadLine();

                string mensagem = enderecoController.Incluir(new Endereco()
                {
                    Logradouro = logradouro,
                    Numero = numero,
                    Bairro = bairro,
                    Complemento = complemento,
                    Cidade = cidade,
                    Estado = estado,
                    CEP = cep
                });

                if (mensagem != "")
                    Console.WriteLine(mensagem);
                else
                    Console.WriteLine("Endereco incluido com sucesso!");
            }

            else if (entrada == "2")
            {
                foreach (Endereco endereco in enderecoController.Listar())
                    Console.WriteLine($"{endereco.Id} - " +
                        $"{endereco.Logradouro} - {endereco.Numero} - {endereco.Bairro}, " +
                        $"{endereco.Complemento} - {endereco.Cidade} - {endereco.Estado} - {endereco.CEP}");
            }

            else if (entrada == "3")
            {
                Console.Write("Digite o Id do Endereco a ser excluido: ");
                string id = Console.ReadLine();
                string mensagem = enderecoController.Excluir(Int32.Parse(id));
                if (mensagem != "")
                    Console.WriteLine(mensagem);
                else
                    Console.WriteLine("Endereco excluido com sucesso!");
            }

            else if (entrada == "4")
            {
                Console.Write("Digite o Id do Endereco a ser editado: ");
                string id = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Digite o novo nome do cliente: ");
                string novoLogradouro = Console.ReadLine();
                string mensagem = enderecoController.EditarLogradouro(Int32.Parse(id), novoLogradouro);
                if (mensagem != "")
                    Console.WriteLine(mensagem);
                else
                    Console.WriteLine("Logradouro editado com sucesso!");
            }
        }

        public static void ExibirMenuFornecedor()
        {
            FornecedorController fornecedorController = new FornecedorController();
            Console.WriteLine("Digite 1 para Incluir");
            Console.WriteLine("Digite 2 para Listar");
            Console.WriteLine("Digite 3 para Excluir");
            Console.WriteLine("Digite 4 para Editar");
            string entrada = Console.ReadLine();

            if (entrada == "1")
            {
                Console.Write("Digite o nome do Fornecedor: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o número do Tipo Pessoa do Fornecedor: ");
                int tipoPessoa = Int32.Parse(Console.ReadLine());


                Console.Write("Digite o CPF ou CNPJ do Fornecedor: ");
                string identificacao = Console.ReadLine();

                string mensagem = fornecedorController.Incluir(new Fornecedor()
                {
                    Nome = nome,
                    Identificacao = identificacao,
                    TipoPessoa = tipoPessoa == 1 ? ETipoPessoa.Fisica : tipoPessoa == 2 ? ETipoPessoa.Juridica : ETipoPessoa.NaoInformado
                });

                if (mensagem != "")
                    Console.WriteLine(mensagem);
                else
                    Console.WriteLine("Fornecedor incluido com sucesso!");
            }

            else if (entrada == "2")
            {
                foreach (Fornecedor fornecedor in fornecedorController.Listar())
                    Console.WriteLine($"{fornecedor.Id} - {fornecedor.Nome} - {fornecedor.TipoPessoa} - {fornecedor.Identificacao}");
            }

            else if (entrada == "3")
            {
                Console.Write("Digite o Id do Fornecedor a ser excluido: ");
                string id = Console.ReadLine();
                string mensagem = fornecedorController.Excluir(Int32.Parse(id));
                if (mensagem != "")
                    Console.WriteLine(mensagem);
                else
                    Console.WriteLine("Fornecedor excluido com sucesso!");
            }

            else if (entrada == "4")
            {
                Console.Write("Digite o Id do Fornecedor a ser editado: ");
                string id = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Digite o novo nome do fornecedor: ");
                string novoNome = Console.ReadLine();
                string mensagem = fornecedorController.EditarNome(Int32.Parse(id), novoNome);
                if (mensagem != "")
                    Console.WriteLine(mensagem);
                else
                    Console.WriteLine("Fornecedor editado com sucesso!");
            }
        }
    }
}
