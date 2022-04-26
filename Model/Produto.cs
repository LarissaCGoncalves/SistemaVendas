using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Produto : BaseClass
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public Categoria Categoria { get; set; }

        public override string ToString()
        {
            return $"{Id};{Nome};{Descricao};{Preco};{Estoque};{Categoria.Id}";
        }
    }
}
