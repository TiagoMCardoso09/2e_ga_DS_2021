using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjRetanguloSRP.visao
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        modelo.RetanguloMatematico ret;
        controle.RetanguloGrafico rg;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ret = new modelo.RetanguloMatematico(
                Double.Parse(txtL1.Text),
                    Double.Parse(txtL2.Text)
                );
            lbArea.Text = "AREA: " + ret.Area();
            lbPerimetro.Text = "PERÍMETRO: " + ret.Perimetro();
        }

        private void btnPlotar_Click(object sender, EventArgs e)
        {
            if (ret != null)
            {
                rg = new controle.RetanguloGrafico (ret);
                rg.Desenhar(0,0,pnGrafico.CreateGraphics());
            }
            else
            {
                MessageBox.Show("Calcule o retângulo primeiro!");
            }
        }

        private void pnGrafico_MouseClick(object sender, MouseEventArgs e)
        {
            if (rg == null)
            {
                rg = new controle.RetanguloGrafico(ret);
            }
            rg.Desenhar(e.X, e.Y, pnGrafico.CreateGraphics());
        }
    }
}
