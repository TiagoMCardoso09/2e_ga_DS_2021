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

        public Produto()
        {
            Id = 0;
            Nome = "";
            Fabricante = "";
        }
    }
}
