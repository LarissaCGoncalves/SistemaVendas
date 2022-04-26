using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Categoria :  BaseClass
    {
        public string Nome { get; set; }

        public override string ToString()
        {
            return $"{Id};{Nome}";
        }
    }


}
