using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Endereco : BaseClass
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }

        public override string ToString()
        {
            return $"{Id}; {Logradouro}; {Numero}; {Bairro};" +
                $"{Complemento}; {Cidade}; {Estado}; {CEP}";
        }
    }
}
