using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoAPI
{
    public class CD: Produto
    {
        public string Gereno { get; set; }
        public int Lancamento { get; set; }

        public CD(int ID, string Nome, string Fabricante, string Genero, int Lancamento)
            : base(ID, Nome, Fabricante)
        {
            this.Gereno = Gereno;
            this.Lancamento = Lancamento;
        }

        public override void imprimir()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("PRODUTO CD");
            Console.WriteLine("ID: {0}", Id);
            Console.WriteLine("TÍTULO: {0}", Nome);
            Console.WriteLine("GRAVADORA: {0}", Fabricante);
            Console.WriteLine("GÊNERO: {0}", Gereno);
            Console.WriteLine("LANÇAMENTO: {0}", Lancamento);
        }
    }
}
