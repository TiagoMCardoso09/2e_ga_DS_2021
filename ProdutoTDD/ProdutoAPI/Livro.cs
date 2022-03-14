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
        public Livro()
        {
            Autor = "";
            ISBN = "";
        }
    }
}
