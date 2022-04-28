using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller
{
    public class FornecedorController: BaseController<Fornecedor>
    {

        public string Incluir(Fornecedor novoFornecedor)
        {
            string mensagem = ValidarEntradas(novoFornecedor);
            if (mensagem != "")
                return mensagem;

            List<Fornecedor> fornecedores = Listar();
            fornecedores.Add(novoFornecedor);
            SalvarArquivo(fornecedores);

            return "";
        }

        public List<Fornecedor> Listar()
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>();
            var linhas = ObterLinhasArquivo();

            foreach (string linha in linhas)
            {
                string[] campos = linha.Split(';');
                fornecedores.Add(new Fornecedor()
                {
                    Nome = campos[0],
                    TipoPessoa = IdentificarTipoPessoaPorInteiro(Int32.Parse(campos[1])),
                    Identificacao = campos[2]
                });
            }
            return fornecedores;
        }

        public string EditarNome(int id, string novoNome)
        {
            if (string.IsNullOrWhiteSpace(novoNome))
                return "Novo nome é inválido.";

            Fornecedor fornecedorEditar = FiltrarFornecedorPorId(id);
            if (fornecedorEditar == null)
                return "O id informado é inválido.";

            fornecedorEditar.Nome = novoNome;
            List<Fornecedor> fornecedores = new List<Fornecedor>();

            SalvarArquivo(fornecedores);
            return "";
        }

        public string EditarTipoPessoa (int id, ETipoPessoa novoTipoPessoa)
        {
            Fornecedor fornecedorEditar = FiltrarFornecedorPorId(id);
            if (fornecedorEditar == null)
                return "O id informado é inválido.";

            fornecedorEditar.TipoPessoa = novoTipoPessoa;
            List<Fornecedor> fornecedores = new List<Fornecedor>(); //testar se funciona com a lista no fim do código

            SalvarArquivo(fornecedores);
            return "";

        }

        public string EditarIdentificacao (int id, string novaIdentificacao)
            ///Edita o CPF ou CNPJ do Fornecedor
        {
            if (string.IsNullOrWhiteSpace(novaIdentificacao))
                return "Novo CPF ou CNPJ inválido.";

            Fornecedor fornecedorEditar = FiltrarFornecedorPorId(id);
            if (fornecedorEditar == null)
                return "O id informado é inválido.";

            fornecedorEditar.Identificacao = novaIdentificacao;
            List<Fornecedor> fornecedores = new List<Fornecedor>();

            SalvarArquivo(fornecedores);
            return "";
        }

        public string Excluir(Fornecedor fornecedorExcluir)
        {
            if (fornecedorExcluir == null)
                return "Fornecedor informado é inválido.";

            List<Fornecedor> fornecedores = Listar();
            fornecedores.Remove(fornecedorExcluir);

            SalvarArquivo(fornecedores);

            return "";
        }

        public string Excluir (int id)
        {
            Fornecedor fornecedorExcluir = FiltrarFornecedorPorId(id);
            if (fornecedorExcluir == null)
                return "O id informado é inválido.";

            List<Fornecedor> fornecedores = Listar();
            fornecedores.Remove (fornecedorExcluir);

            SalvarArquivo (fornecedores);

            return "";
        }

        public Fornecedor FiltrarFornecedorPorId(int id)
        {
            return Listar().Where(x => x.Id == id).FirstOrDefault();
        }
        public Fornecedor FiltrarFornecedorPorIdentificacao (string identificacao)
            ///Filtra o fornecedor pelo CPF ou CNPJ.
        {
            return Listar().Where(x => x.Identificacao == identificacao).FirstOrDefault();
        }

        private ETipoPessoa IdentificarTipoPessoaPorInteiro (int inteiro)
        {
            if (inteiro == 1)
                return ETipoPessoa.Fisica;
            else
                return ETipoPessoa.Juridica;
        }
        private string ValidarEntradas(Fornecedor fornecedor)
        {
            if (string.IsNullOrWhiteSpace(fornecedor.Nome))
                return "Nome inválido.";
            else if (string.IsNullOrWhiteSpace(fornecedor.Identificacao))
                return "CPF ou CNPJ inválido.";

            return "";
        }
    }
}
