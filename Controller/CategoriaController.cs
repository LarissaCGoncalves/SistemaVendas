using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Controller
{
    public class CategoriaController : BaseController<Categoria>
    {
 
        public string Incluir(Categoria novaCategoria)
        {
            if (string.IsNullOrWhiteSpace(novaCategoria.Nome))
                return "Nome da categoria é invalido.";
            if (Listar().Where(x => x.Nome.ToLower() == novaCategoria.Nome.ToLower()).Count() > 0)
                return "Categoria já existente.";

            List<Categoria> categorias = Listar();
            novaCategoria.Id = ObterProximoId();
            categorias.Add(novaCategoria);
            SalvarArquivo(categorias);

            return "";
        }

        public string Excluir (int id)
        {
            if (FiltrarCategoriaPorId(id) == null)
                return "Id inválido";

            List<Categoria> categorias = Listar();
            int index = categorias.IndexOf(categorias.Where(categoria => categoria.Id == id).FirstOrDefault());
            categorias.Remove(categorias[index]);

            SalvarArquivo(categorias);

            return "";
        }

        public string Editar(int id, Categoria categoriaAtualizada)
        {
            if (FiltrarCategoriaPorId(id) == null)
                return "Id inválido.";

            if (string.IsNullOrWhiteSpace(categoriaAtualizada.Nome))
                return "Nome da categoria informado é inválido";

            List<Categoria> categorias = this.Listar();
            int index = categorias.IndexOf(categorias.Where(categoria => categoria.Id == id).FirstOrDefault());

            categorias[index].Nome = categoriaAtualizada.Nome;
            SalvarArquivo(categorias);

            return "";
        }

        public List<Categoria> Listar()
        {
            List<Categoria> categorias = new List<Categoria>();
            var linhas = ObterLinhasArquivo();
            foreach (string linha in linhas)
            {
                categorias.Add(new Categoria()
                {
                    Id = Int32.Parse(linha.Split(';')[0]),
                    Nome = linha.Split(';')[1]
                });
            }
            return categorias;
        }

        public Categoria FiltrarCategoriaPorId(int id)
        {
            return Listar().Where(x => x.Id == id).FirstOrDefault();
        }

        private int ObterProximoId()
        {
            return Listar().OrderByDescending(x => x.Id).Select(x => x.Id).FirstOrDefault() + 1;
        }
    }
}
