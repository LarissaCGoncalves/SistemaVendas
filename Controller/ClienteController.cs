using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller
{
    public class ClienteController : BaseController<Cliente>
    {
        public List<Cliente> Listar()
        {
            List<Cliente> clientes = new List<Cliente>();
            string[] linhas = ObterLinhasArquivo();

            foreach (string linha in linhas)
            {
                string [] campos = linha.Split(';');
                clientes.Add(new Cliente()
                {
                    Nome = campos[0],
                    CPF = campos[1],
                    Endereco = new EnderecoController().ObterEndereco(campos[2])
                });
            }
            return clientes;
        }

        public string Incluir(Cliente cliente)
        {
            string mensagem = ValidarCliente(cliente);
            if (mensagem != "")
                return mensagem;

            List<Cliente> clientes = new List<Cliente>();
            clientes.Add(cliente);

            SalvarArquivo(clientes);

            return "";
        }

        public string EditarNome(int idCliente, string novoNome)
        {
            List<Cliente> clientes = Listar();

            if (string.IsNullOrWhiteSpace(novoNome))
                return "Novo nome é inválido.";

            Cliente cliente = FiltrarClientePorId(idCliente);
            if (cliente == null)
                return "O Id informado é inválido.";

            cliente.Nome = novoNome;
            SalvarArquivo(clientes);

            return "";
        }

        public string EditarCPF(int idCliente, string novoCpf)
        {
            List<Cliente> clientes = Listar();

            if (string.IsNullOrWhiteSpace(novoCpf))
                return "Novo novo CPF informado é inválido.";

            Cliente cliente = FiltrarClientePorId(idCliente);
            if (cliente == null)
                return "O Id informado é inválido.";

            cliente.CPF = novoCpf;
            SalvarArquivo(clientes);

            return "";
        }

        public string EditarEndereco(int idCliente, Endereco novoEndereco)
        {
            List<Cliente> clientes = Listar();

            if (novoEndereco == null)
                return "O novo endereço infrmado é inválido.";

            Cliente cliente = FiltrarClientePorId(idCliente);
            if (cliente == null)
                return "O Id informado é inválido.";

            cliente.Endereco = novoEndereco;
            SalvarArquivo(clientes);

            return "";
        }


        public string Excluir(int id)
        {
            Cliente clienteExcluir = FiltrarClientePorId(id);
            if (clienteExcluir == null)
                return "O Id informado é inválido.";

            List<Cliente> clientes = new List<Cliente>();
            clientes.Remove(clienteExcluir);

            SalvarArquivo(clientes);

            return "";
        }

        public string Excluir(Cliente clienteExcluir)
        {
            if (clienteExcluir == null)
                return "O Cliente informado é inválido.";

            List<Cliente> clientes = new List<Cliente>();
            clientes.Remove(clienteExcluir);

            SalvarArquivo(clientes);

            return "";
        }

        private string ValidarCliente(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nome))
                return "Nome inválido.";
            if (string.IsNullOrWhiteSpace(cliente.CPF))
                return "O CPF do cliente é inválido.";
            if (cliente.Endereco == null)
                return "O campo endereço do cliente está vazio.";

            return "";
        }
        public Cliente FiltrarClientePorId(int id)
        {
            return Listar().Where(x => x.Id == id).FirstOrDefault();
        }

        public Cliente FiltrarClientePorCPF(string cpf)
        {
            return Listar().Where(x => x.CPF == cpf).FirstOrDefault();
        }
    }
}
