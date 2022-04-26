using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller
{
    public class ProdutoController : BaseController<Produto>
    {
        public string Incluir(Produto novoProduto)
        {
            string mensagem = ValidarEntradas(novoProduto);
            if (mensagem != "")
                return mensagem;

            List<Produto> produtos = Listar();
            produtos.Add(novoProduto);
            SalvarArquivo(produtos);

            return "";
        }
        
        public string Excluir(int id)
        {
            List<Produto> produtos = Listar();
            Produto produtoExcluir = ObterProdutoPorId(id);

            string mensagem = ValidarId(id);
            if (mensagem != "")
                return mensagem;

            produtos.Remove(produtoExcluir);
            SalvarArquivo(produtos);

            return "";
        }

        public string Excluir(Produto produtoExcluir)
        {
            if (produtoExcluir == null)
                return "O produto informado é inválido.";

            List<Produto> produtos = Listar();

            produtos.Remove(produtoExcluir);
            SalvarArquivo(produtos);

            return "";
        }

        public string Editar(int id, string novoNome)
        {
            List<Produto> produtos = this.Listar();
            Produto produtoEditar = ObterProdutoPorId(id);

            string mensagem = ValidarId(id);
            if (mensagem != "")
                return mensagem;

            else if (string.IsNullOrWhiteSpace(novoNome))
                return "Nome informado é inválido.";

            produtoEditar.Nome = novoNome;
            SalvarArquivo(produtos);

            return "";
        }

        
        public List<Produto> Listar()
        {
            CategoriaController categoriaController = new CategoriaController();
            FornecedorController fornecedorController = new FornecedorController();
            List<Produto> produtos = new List<Produto>();
            var linhas = ObterLinhasArquivo();
            foreach (string linha in linhas)
            {
                string[] campos = linha.Split(';');
                produtos.Add(new Produto()
                {
                    Id = Int32.Parse(campos[0]),
                    Nome = campos[1],
                    Descricao = campos[2],
                    Preco = Double.Parse(campos[3]),
                    Estoque = Int32.Parse(campos[4]),
                    Fornecedor = fornecedorController.FiltrarFornecedorPorIdentificacao(campos[5]),
                    Categoria = categoriaController.FiltrarCategoriaPorId(Int32.Parse(campos[6]))
                });
            }
            return produtos;
        }

        public string AdicionarAoEstoque (int quantidade, int id)
        {
            string mensagem = ValidarId(id);
            if (mensagem != "")
                return mensagem;

            Produto produto = ObterProdutoPorId(id);
            produto.Estoque += quantidade;

            return "";
        }

        public string RemoverDoEstoque (int quantidade, int id)
        {
            string mensagem = ValidarId(id);
            if (mensagem != "")
                return mensagem;

            Produto produto = ObterProdutoPorId(id);
            if (produto.Estoque < quantidade)
                return "Quantidade em estoque insuficiente.";

            produto.Estoque -= quantidade;

            return "";
        }
        private Produto ObterProdutoPorId(int id)
        {
            return Listar().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Produto> FiltrarProdutosPorCategoria (Categoria categoria)
        {
            List<Produto> produtosFiltrados = Listar().Where(x => x.Categoria == categoria).ToList();

            return produtosFiltrados;
        }
        public List<Produto> FiltrarProdutosPorCategoria(int idCategoria)
        {
            List<Produto> produtosFiltrados = Listar().Where( x => x.Categoria.Id == idCategoria).ToList();

            return produtosFiltrados;
        }

        public List<Produto> FiltrarPorPalavra(string palavra)
        {
            List<Produto> produtosFiltrados = Listar().Where(x => x.Nome.Contains(palavra, StringComparison.OrdinalIgnoreCase)).ToList();

            return produtosFiltrados;
        }

        public List<Produto> FiltrarPorEstoqueMaximo (int maximaQuantidadeEmEstoque)
            ///Retorna uma lista de produtos com estoque igual ou inferior a quantidade informada.
        {
            List<Produto> produtosFiltrados = Listar().Where(x => x.Estoque <= maximaQuantidadeEmEstoque).ToList();

            return produtosFiltrados;
        }
        public List<Produto> FiltrarPorEstoqueMinimo(int maximaQuantidadeEmEstoque)
        ///Retorna uma lista de produtos com estoque igual ou maior a quantidade informada.
        {
            List<Produto> produtosFiltrados = Listar().Where(x => x.Estoque >= maximaQuantidadeEmEstoque).ToList();

            return produtosFiltrados;
        }

        public List<Produto> FiltrarPorPrecoMaximo (double preco)
            ///Retorna uma lista de produtos com preço igual ou inferior ao valor informado.
        {
            List<Produto> produtosFiltrados = Listar().Where(x => x.Preco <= preco).ToList();

            return produtosFiltrados;
        }

        public List<Produto> FiltrarPorPrecoMinimo(double preco)
        ///Retorna uma lista de produtos com preço igual ou maior ao valor informado.
        {
            List<Produto> produtosFiltrados = Listar().Where(x => x.Preco >= preco).ToList();

            return produtosFiltrados;
        }
        public List<Produto> FiltrarPorPreco(double preco)
        ///Retorna uma lista de produtos com preço igual ao valor informado.
        {
            List<Produto> produtosFiltrados = Listar().Where(x => x.Preco == preco).ToList();

            return produtosFiltrados;
        }

        private string ValidarEntradas(Produto produto)
        {
            if (string.IsNullOrWhiteSpace(produto.Nome))
                return "Nome inválido.";
            if (string.IsNullOrWhiteSpace(produto.Preco.ToString()))
                return "Preço inválido.";
            if (produto.Categoria == null)
                return "É necessário definir uma categoria para o produto.";
            return "";
        }

        private string ValidarId (int id)
        {
            if (ObterProdutoPorId(id) == null)
                return "O Id informado é inválido.";
            else
                return "";
        }
    }
}
