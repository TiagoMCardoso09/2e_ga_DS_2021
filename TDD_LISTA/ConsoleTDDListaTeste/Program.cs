using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APP_LISTA;

namespace ConsoleTDDListaTeste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.Clear();
            Console.WriteLine("TESTE API LISTA");

            List<double> amostra = new List<double>();
            for (int x = 1; x <= 1000000; x++) amostra.Add(x);

            TimeSpan tempo = new TimeSpan();
            DateTime inicio = DateTime.Now;

            double resultado = ListaAPI.Somar(amostra);
            bool teste = resultado == 500000500000;

            if (teste) Console.WriteLine("Somar Success");
            else Console.WriteLine("Somar Fail");

            Console.WriteLine("Obtido: {0} || Esperado: {1}", resultado, 500000500000);

            DateTime final = DateTime.Now;
            tempo = final - inicio;
            double ms = tempo.TotalMilliseconds;

            Console.WriteLine("Tempo {0} ms", ms);

            Console.ReadKey();

            tempo = new TimeSpan();
            inicio = DateTime.Now;

            resultado = ListaAPI.Media(amostra);
            teste = resultado == 500000.5;

            if (teste) Console.WriteLine("\nMedia Success");
            else Console.WriteLine("Media Fail");

            Console.WriteLine("Obtido: {0} || Esperado: {1}", resultado, 500000.5);

            final = DateTime.Now;
            tempo = final - inicio;
            ms = tempo.TotalMilliseconds;

            Console.WriteLine("Tempo {0} ms", ms);

            Console.ReadKey();
        }
    }
}