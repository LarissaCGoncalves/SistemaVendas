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
            return new List<Endereco>();
        }

        public Endereco ObterEndereco(int id)
            ///Obtém o endereço pelo Id informado.
        {
            return Listar().Where(x => x.Id == id).FirstOrDefault();
        }

        public Endereco ObterEndereco(string cep)
        ///Obtém o endereço pelo Id informado.
        {
            return Listar().Where(x => x.CEP == cep).FirstOrDefault();
        }

        public List<Cliente> FiltrarPorCEP(string cep)
        {
            return new List<Cliente>();
        }
    }
}
