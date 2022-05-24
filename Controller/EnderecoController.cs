using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller
{
    public class EnderecoController : BaseController<Endereco>
    {
        public List<Endereco> Listar()
        {
            List<Endereco> enderecos = new List<Endereco>();
            string [] linhas = ObterLinhasArquivo();
            foreach (string linha in linhas)
            {
                string [] campos = linha.Split(';');
                enderecos.Add(new Endereco
                {
                    Id = Int32.Parse(campos[0]),
                    Logradouro = campos[1],
                    Numero = campos[2],
                    Bairro = campos[3],
                    Complemento = campos[4],
                    Cidade = campos[5],
                    Estado = campos[6],
                    CEP = campos[7]
                });
            }

            return enderecos;
        }

        public string IncluirEndereco(Endereco novoEndereco)
        {
            string mensagem = ValidarEndereco(novoEndereco);
            if (mensagem != "")
                return mensagem;
            List<Endereco> enderecos = Listar();

            enderecos.Add(novoEndereco);
            novoEndereco.Id = ObterProximoId();
            SalvarArquivo(enderecos);
            return "";
        }

        public string Editar(int idEndereco, Endereco enderecoAtualizado)
        {
            string mensagem = ValidarEndereco(enderecoAtualizado);
            if (mensagem != "")
                return mensagem;

            List<Endereco> enderecos = Listar();
            int index = enderecos.IndexOf(enderecos.Where(endereco => endereco.Id == idEndereco).FirstOrDefault()); 

            if (FiltrarPorId(idEndereco) == null)
                return "Id inválido.";

            SubstituirEndereco(enderecos[index], enderecoAtualizado);

            SalvarArquivo(enderecos);

            return "";
        }

        public string Excluir(int id)
        {
            if (FiltrarPorId(id) == null)
                return "Id inválido.";

            List<Endereco> enderecos = Listar();
            int index = enderecos.IndexOf(enderecos.Where(endereco => endereco.Id == id).FirstOrDefault());
            enderecos.Remove(enderecos[index]);

            SalvarArquivo(enderecos);

            return "";
        }

        public string Excluir (Endereco enderecoExcluir)
        {
            if (enderecoExcluir == null)
                return "O endereço informado é inválido.";

            List<Endereco> enderecos = Listar();
            enderecos.Remove(enderecoExcluir);
            SalvarArquivo (enderecos);

            return "";
        }

        public Endereco FiltrarPorId(int id)
        {
            return Listar().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Endereco> FiltrarPorCEP(string cep)
        {
            return Listar().Where(x => x.CEP == cep).ToList();
        }

        public string ValidarEndereco(Endereco endereco)
        {
            if (string.IsNullOrWhiteSpace(endereco.Logradouro))
                return "Logradouro inválido.";
            else if (string.IsNullOrWhiteSpace(endereco.Numero))
                return "Número inválido.";
            else if (string.IsNullOrWhiteSpace(endereco.Bairro))
                return "Bairro inválido.";
            else if (string.IsNullOrWhiteSpace(endereco.Cidade))
                return "Cidade inválida.";
            else if (string.IsNullOrWhiteSpace(endereco.Estado))
                return "Estado inválido.";
            else if (string.IsNullOrWhiteSpace(endereco.CEP))
                return "CEP inválido.";

            return "";
        }

        private void SubstituirEndereco (Endereco enderecoAntigo, Endereco enderecoNovo)
        {
            enderecoAntigo.Logradouro = enderecoNovo.Logradouro;
            enderecoAntigo.Numero = enderecoNovo.Numero;
            enderecoAntigo.Bairro = enderecoNovo.Bairro;
            enderecoAntigo.Complemento = enderecoNovo.Complemento;
            enderecoAntigo.Cidade = enderecoNovo.Cidade;
            enderecoAntigo.Estado = enderecoNovo.Estado;
            enderecoAntigo.CEP = enderecoNovo.CEP;
        }

        private int ObterProximoId()
        {
            return Listar().OrderByDescending(x => x.Id).Select(x => x.Id).FirstOrDefault() + 1;
        }
    }
}
