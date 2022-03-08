using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_LISTA
{
    public class ListaAPI
    {
        public static double Somar (List<double> vetor)
        {
            double sum = 0;
            foreach (double num in vetor)
            {
                sum += num;
            }
            return sum;
        }

        public static double Media (List<double> vetor)
        {
            return Somar(vetor) / vetor.Count();
        }
    }
}
