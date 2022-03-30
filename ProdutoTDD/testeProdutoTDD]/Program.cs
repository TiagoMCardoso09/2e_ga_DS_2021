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
            IProdutoRepositorio banco = new ProdutoRepositorio (new List<Produto>());

            banco.Adicionar(
                    new Livro(
                        1,
                        "DOM CASMURRO",
                        "RECORD",
                        "MACHADO DE ASSIS",
                        "123456"
                    )
                );

            banco.Adicionar(
                 new DVD(
                         1,
                         "Gente Grande",
                         "Columbia Pictures",
                         "Adam Sandler",
                         "2010"
                     )
                 );

            banco.Adicionar(
                new CD(
                        3,
                        "CARMINA BURANA",
                        "DECA",
                        "EURODITO",
                        1989
                    )
                );

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            banco.ler();

            Console.ReadKey();
        }
    }
}
