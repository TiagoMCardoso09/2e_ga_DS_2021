using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FOLHA_PAGAMENTO;

namespace FOLHA_TESTE
{
    class Program
    {
        static List<ICalculoSalario> lista;
        static void Main(string[] args)
        {
            lista = new List<ICalculoSalario>();

            lista.Add(
                new CalcularSalarioFuncionario(1, "João Pedro Correia Jardim", 160)
            );

            lista.Add(
                new CalcularSalarioFuncionario(2, "Tiago Macedo Cardoso", 200)
            );
            lista.Add(
                new CalculoSalarioAposentado(3, "Jorge Lucas Ferreira Silva")
            );
            lista.Add(
                new CalculoSalarioEstagiario(4, "Monique Pedroso de Boa Ventura", 80)
            );

            lista.ForEach(i => i.Imprimir());

            Console.ReadKey();
        }
    }
}
