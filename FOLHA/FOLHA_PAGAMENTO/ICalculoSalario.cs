using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_PAGAMENTO
{
    public interface ICalculoSalario
    {
        string Nome { get; set; }
        double Calcular(double SalarioHora);
        double Imposto(double Valor);
        void Imprimir();
    }
}
