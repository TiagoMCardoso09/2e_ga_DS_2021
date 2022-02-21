using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjRetanguloSRP.controle
{
    class RetanguloGrafico
    {
        public modelo.RetanguloMatematico Ret { get; set; }

        public RetanguloGrafico(modelo.RetanguloMatematico Ret)
        {
            this.Ret = Ret;
        }

        public void Desenhar(double x, double y, Graphics g)
        {
            Pen caneta = new Pen(Color.Green,2);
            g.DrawRectangle(caneta, (int)x, (int)y, (int) Ret.L1, (int) Ret.L2);
            caneta.Color = Color.Blue;
            g.DrawEllipse(caneta, (int)x, (int)y, (int)Ret.L1, (int)Ret.L2);
        }
    }
}
