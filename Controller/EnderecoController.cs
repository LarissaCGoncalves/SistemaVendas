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

        public string Incluir(Endereco novoEndereco)
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

        public string EditarLogradouro(int id, string novoLogradouro)
        {
            string mensagem = ValidarId(id);
            if (string.IsNullOrWhiteSpace(novoLogradouro))
                return "Novo logradouro inválido.";
            else if (mensagem != "")
                return mensagem;

            List<Endereco> enderecos = Listar();
            Endereco endereco = FiltrarPorId(id);
            endereco.Logradouro = novoLogradouro;
            SalvarArquivo(enderecos);

            return "";
        }

        public string Excluir(int id)
        {
            string mensagem = ValidarId(id);
            if (mensagem != "")
                return mensagem;

            List<Endereco> enderecos = Listar();
            enderecos.Remove(FiltrarPorId(id));
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
            ///Obtém o endereço pelo Id informado.
        {
            return Listar().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Endereco> FiltrarPorCEP(string cep)
        {
            return Listar().Where(x => x.CEP == cep).ToList();
        }

        private string ValidarEndereco(Endereco endereco)
        {
            int resultado;
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
            else if (string.IsNullOrWhiteSpace(endereco.CEP) || !Int32.TryParse(endereco.CEP, out resultado))
                return "CEP inválido.";

            return "";
        }

        private string ValidarId(int id)
        {
            if (FiltrarPorId(id) == null)
                return "O Id informado é inválido.";
            else
                return "";
        }
        private int ObterProximoId()
        {
            return Listar().OrderByDescending(x => x.Id).Select(x => x.Id).FirstOrDefault() + 1;
        }
    }
}
