using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoAPI
{
    public class ProdutoRepositorio: IProdutoRepositorio
    {
        public Produto p { get; set; }
        public void cadastrar()
        {
            p = new Livro();
            p.Id = 1;
            p.Nome = "DOM CASMURRO";
            p.Fabricante = "Record";
        }

        public void ler()
        {
            Console.WriteLine("{0}  {1}  {2}", p.Id, p.Nome, p.Fabricante);
        }
    }
}
