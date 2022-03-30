using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoAPI
{
    public class ProdutoRepositorio: IProdutoRepositorio
    {
        public List<Produto> Produtos { get; set; }

        public ProdutoRepositorio(List<Produto> Produtos)
        {
            this.Produtos = Produtos;
        }

        public void ler()
        {
            Produtos.ForEach(i => i.imprimir());
        }

        public void Adicionar(Produto P)
        {
            Produtos.Add(P);
        }
    }
}
