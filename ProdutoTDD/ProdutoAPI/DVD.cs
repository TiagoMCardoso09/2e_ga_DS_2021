    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoAPI
{
    public class DVD:Produto
    {
        public string Ano { get; set; }
        public string Diretor { get; set; }

        public DVD (int Id, string Nome, string Fabricante, string Ano, string Diretor): base(Id, Nome, Fabricante)
        {
            this.Ano = Ano;
            this.Diretor = Diretor;
        }

        public override void imprimir()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("PRODUTO DVD");
            Console.WriteLine("ID: {0}", Id);
            Console.WriteLine("TÍTULO: {0}", Nome);
            Console.WriteLine("ESTÚDIO: {0}", Fabricante);
            Console.WriteLine("DIRETOR: {0}", Diretor);
            Console.WriteLine("ANO: {0}", Ano);
        }
    }
}
