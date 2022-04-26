using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Fornecedor : BaseClass
    {
        public string Nome { get; set; }
        public ETipoPessoa TipoPessoa { get; set; }
        public string Identificacao { get; set; } //CPF ou CNPJ

    }
}
