using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoAPI
{
    public class Livro:Produto
    {
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public Livro(int Id, string Nome, string Fabricante, string Autor, string ISBN): base(Id, Nome, Fabricante)
        {
            this.Autor = Autor;
            this.ISBN = ISBN;
        }

        public override void imprimir()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("PRODUTO LIVRO");
            Console.WriteLine("ID: {0}", Id);
            Console.WriteLine("NOME: {0}", Nome);
            Console.WriteLine("EDITORA: {0}", Fabricante);
            Console.WriteLine("AUTOR: {0}", Autor);
            Console.WriteLine("ISBN: {0}", ISBN);
        }
    }
}
