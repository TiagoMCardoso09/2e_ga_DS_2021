using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoAPI
{
    public abstract class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Fabricante { get; set; }

        public Produto(int Id, string Nome, string Fabricante)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Fabricante = Fabricante;
        }

        public abstract void imprimir();
    }
}
