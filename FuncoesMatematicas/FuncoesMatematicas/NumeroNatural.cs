using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncoesMatematicas
{
    public class NumeroNatural
    {
        public static bool IsPar (int n)
        {
            if (n % 2 == 0) return true;
            else return false;
        }

        public static bool Primo(int n)
        {
            int cont = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) cont++;
            }
            if (cont == 2) return true;
            else return false;
        }

        public static bool Perfeito(int n)
        {
            int soma = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0) soma += i;
            }
            if (soma == n) return true;
            else return false;
        }
    }
}
