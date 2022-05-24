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
            novoFornecedor.Id = ObterProximoId();
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
                    Id = Int32.Parse(campos[0]),
                    Nome = campos[1],
                    TipoPessoa = IdentificarTipoPessoaPorInteiro(Int32.Parse(campos[2])),
                    Identificacao = campos[3]
                });
            }
            return fornecedores;
        }

        public string Editar(int id, Fornecedor fornecedorAtualizado)
        {
            if (FiltrarFornecedorPorId(id) == null)
                return "Id inválido.";

            string mensagem = ValidarEntradas(fornecedorAtualizado);
            if (mensagem != "")
                return mensagem;

            List<Fornecedor> fornecedores = Listar();
            int index = fornecedores.IndexOf(fornecedores.Where(fornecedor => fornecedor.Id == id).FirstOrDefault());
            fornecedores[index].Nome = fornecedorAtualizado.Nome;
            fornecedores[index].Identificacao = fornecedorAtualizado.Identificacao;
            fornecedores[index].TipoPessoa = fornecedorAtualizado.TipoPessoa;

            SalvarArquivo(fornecedores);
            return "";
        }

        //public string Excluir(Fornecedor fornecedorExcluir)
        //{
        //    if (fornecedorExcluir == null)
        //        return "Fornecedor informado é inválido.";

        //    List<Fornecedor> fornecedores = Listar();
        //    fornecedores.Remove(fornecedorExcluir);

        //    SalvarArquivo(fornecedores);

        //    return "";
        //}

        public string Excluir (int id)
        {
            if (FiltrarFornecedorPorId(id) == null)
                return "Id inválido.";

            List<Fornecedor> fornecedores = Listar();
            int index = fornecedores.IndexOf(fornecedores.Where(fornecedor => fornecedor.Id == id).FirstOrDefault());

            fornecedores.Remove (fornecedores[index]);

            SalvarArquivo (fornecedores);

            return "";
        }

        public Fornecedor FiltrarFornecedorPorId(int id)
        {
            return Listar().Where(x => x.Id == id).FirstOrDefault();
        }
        public Fornecedor FiltrarFornecedorPorIdentificacao (string identificacao)
            //Filtra o fornecedor pelo CPF ou CNPJ.
        {
            return Listar().Where(x => x.Identificacao == identificacao).FirstOrDefault();
        }

        private ETipoPessoa IdentificarTipoPessoaPorInteiro (int inteiro)
        {
            if (inteiro == 0)
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

        private int ObterProximoId()
        {
            return Listar().OrderByDescending(x => x.Id).Select(x => x.Id).FirstOrDefault() + 1;
        }
    }
}
