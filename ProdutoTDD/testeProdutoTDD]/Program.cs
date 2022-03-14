using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProdutoAPI;

namespace testeProdutoTDD_
{
    class Program
    {
        static void Main(string[] args)
        {
            IProdutoRepositorio produto = new ProdutoRepositorio();

            produto.cadastrar();
            produto.ler();

            Console.ReadKey();
        }
    }
}
