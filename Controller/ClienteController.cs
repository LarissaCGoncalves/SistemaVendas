using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Controller
{
    public class ClienteController : BaseController<Cliente>
    {
        private EnderecoController _enderecoController = new EnderecoController();
        public List<Cliente> Listar()
        {
            List<Cliente> clientes = new List<Cliente>();
            string[] linhas = ObterLinhasArquivo();

            foreach (string linha in linhas)
            {
                string[] campos = linha.Split(';');
                clientes.Add(new Cliente()
                {
                    Id = Int32.Parse(campos[0]),
                    Nome = campos[1],
                    CPF = campos[2],
                    Endereco = new EnderecoController().FiltrarPorId(Int32.Parse(campos[3])),
                    Telefone = campos[4],
                    Email = campos[5]
                });
            }
            return clientes;
        }

        public string IncluirClienteComEndereco(Cliente novoCliente)
        {
            string mensagem = ValidarClienteComEndereco(novoCliente);
            if (mensagem != "")
                return mensagem;

            List<Cliente> clientes = Listar();
            novoCliente.Id = ObterProximoId();
            clientes.Add(novoCliente);

            EnderecoController enderecoController = new EnderecoController();
            enderecoController.IncluirEndereco(novoCliente.Endereco);

            SalvarArquivo(clientes);

            return "";
        }

        public string Editar(int idCliente, Cliente clienteAtualizado)
        {
            string mensagem = ValidarClienteComEndereco(clienteAtualizado);

            if (mensagem != "")
                return mensagem;
            else if (FiltrarClientePorId(idCliente) == null)
                return "Id inválido.";

            List<Cliente> clientes = Listar();
            int index = clientes.IndexOf(clientes.Where(cliente => cliente.Id == idCliente).FirstOrDefault());

            clientes[index].Nome = clienteAtualizado.Nome;
            clientes[index].CPF = clienteAtualizado.CPF;
            clientes[index].Telefone = clienteAtualizado.Telefone;
            clientes[index].Email = clienteAtualizado.Email;

            if (clienteAtualizado.Endereco != default)
            {
                mensagem = _enderecoController.Editar(clientes[index].Endereco.Id, clienteAtualizado.Endereco);
                if (mensagem != "")
                    return mensagem;
            }

            SalvarArquivo(clientes);

            return "";
        }

        public string Excluir(int id)
        {
            if (FiltrarClientePorId(id) == null)
                return "Id inválido.";

            List<Cliente> clientes = Listar();
            int index = clientes.IndexOf(clientes.Where(cliente => cliente.Id == id).FirstOrDefault());

            _enderecoController.Excluir(clientes[index].Endereco.Id);
            clientes.Remove(clientes[index]);

            SalvarArquivo(clientes);

            return "";
        }

        //public string Excluir(Cliente clienteExcluir)
        //{
        //    if (clienteExcluir == null)
        //        return "O Cliente informado é inválido.";

        //    List<Cliente> clientes = Listar();
        //    clientes.Remove(clienteExcluir);

        //    SalvarArquivo(clientes);

        //    return "";
        //}

        private string ValidarClienteComEndereco(Cliente cliente)
        {
            EnderecoController enderecoController = new EnderecoController();
            if (string.IsNullOrWhiteSpace(cliente.Nome))
                return "Nome inválido.";
            else if (string.IsNullOrWhiteSpace(cliente.CPF))
                return "O CPF do cliente é inválido.";
            else if (enderecoController.ValidarEndereco(cliente.Endereco) != "")
                return enderecoController.ValidarEndereco(cliente.Endereco);

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

        private int ObterProximoId()
        {
            return Listar().OrderByDescending(x => x.Id).Select(x => x.Id).FirstOrDefault() + 1;
        }
    }
}
