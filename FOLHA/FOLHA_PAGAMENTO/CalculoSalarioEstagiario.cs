using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_PAGAMENTO
{
    public class CalculoSalarioEstagiario : ICalculoSalario
    {
        public int CodEmp { get; set; }
        public string Nome { get; set; }
        public double Adicional { get; set; }

        public CalculoSalarioEstagiario(int CodEmp, string Nome, double Adicional)
        {
            this.CodEmp = CodEmp;
            this.Nome = Nome;
            this.Adicional = Adicional;
        }

        public double Calcular(double SalarioHora)
        {
            return (SalarioHora * 0.5 * 80) + Adicional;
        }

        public double Imposto(double Valor)
        {
            return 0;
        }

        public void Imprimir()
        {
            double sb = Calcular(18);
            double desconto = Imposto(sb);
            Console.ForegroundColor = ConsoleColor.Red;
            if (CodEmp > 1)
            {
                Console.WriteLine("\nCálculo do salário do empregrado:\n\n\tCódigo: {0}\n\tNome: {1}\n\tSalário Bruto: {2}\n\tImposto: {3}", CodEmp, Nome, sb, desconto);
            }
            else
            {
                Console.WriteLine("Cálculo do salário do empregrado:\n\n\tCódigo: {0}\n\tNome: {1}\n\tSalário Bruto: {2}\n\tImposto: {3}", CodEmp, Nome, sb, desconto);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n\tO salário líquido do funcionário foi de: {0}", sb - desconto);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n-----------------------------------------------------------------------------------------");
        }
    }
}
