using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_PAGAMENTO
{
    public class CalcularSalarioFuncionario : ICalculoSalario
    {
        public int CodEmp { get; set; }
        public string Nome { get; set; }
        public double HorasTabalhadas { get; set; }

        public CalcularSalarioFuncionario(int CodEmp, string Nome, double HorasTrabalhadas)
        {
            this.CodEmp = CodEmp;
            this.Nome = Nome;
            this.HorasTabalhadas = HorasTrabalhadas;
        }

        public double Calcular(double SalarioHora)
        {
            double sb = HorasTabalhadas * SalarioHora;
            return sb;
        }

        public double Imposto(double Valor)
        {
            double desconto = Valor * 0.02;
            return desconto;
        }

        public void Imprimir()
        {
            double sb = Calcular(18);
            double desconto = Imposto(sb);
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
