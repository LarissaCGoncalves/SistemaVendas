using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Cliente : BaseClass
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public Endereco Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{Id};{Nome};{CPF};{Endereco.Id};{Telefone};{Email}";
        }
    }
}
