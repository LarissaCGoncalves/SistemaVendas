using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Controller
{
    public class BaseController<T>
    {
        string diretorioArquivo = Directory.GetCurrentDirectory() + $"\\Dados\\{typeof(T).Name}.txt";
        protected string[] ObterLinhasArquivo()
        {
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\Dados"))
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Dados");
            if (!File.Exists(diretorioArquivo))
            {
                var arquivo = File.Create(diretorioArquivo);
                arquivo.Close();
            }

            return File.ReadAllLines(diretorioArquivo);
        }

        protected void SalvarArquivo(List<T> itens)
        {
            List<string> linhas = new List<string>();
            foreach (T item in itens)
                linhas.Add(item.ToString());

            File.WriteAllLines(diretorioArquivo, linhas);
        }
    }
}
