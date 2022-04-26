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
                return "Nome da categoria é invalido";
            if (Listar().Where(x => x.Nome.ToLower() == novaCategoria.Nome.ToLower()).Count() > 0)
                return "Nome de categoria já existente";

            List<Categoria> categorias = Listar();
            novaCategoria.Id = ObterProximoId();
            categorias.Add(novaCategoria);
            SalvarArquivo(categorias);

            return "";
        }

        public string Excluir (int id)
        {
            List<Categoria> categorias = this.Listar();
            Categoria categoriaExcluir = FiltrarCategoriaPorId(id);

            if (categoriaExcluir == null)
                return "Id inválido";

            categorias.Remove(categoriaExcluir);
            SalvarArquivo(categorias);

            return "";
        }

        public string Editar(int id, string novoNome)
        {
            List<Categoria> categorias = this.Listar();
            Categoria categoriaEditar = FiltrarCategoriaPorId(id);

            if (categoriaEditar == null)
                return "Id inválido";
            else if (string.IsNullOrWhiteSpace(novoNome))
                return "Nome informado é inválido";

            categoriaEditar.Nome = novoNome;
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
