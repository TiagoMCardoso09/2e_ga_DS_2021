using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuncoesMatematicas;

namespace prjTesteDLL
{
    public partial class Form1 : Form
    {
        public Form1()  
        {
            InitializeComponent();
        }

        private void btnPar_Click(object sender, EventArgs e)
        {
            bool teste;
            int num = Int16.Parse(txtNum.Text);
            teste = NumeroNatural.IsPar(num);
            lbResultado.Text = teste ? "Número par" : "Número Ímpar";
        }

        private void btnPrimo_Click(object sender, EventArgs e)
        {
            bool teste;
            int num = Int16.Parse(txtNum.Text);
            teste = NumeroNatural.Primo(num);
            lbResultado.Text = teste ? "Número Primo" : "Número não primo";
        }

        private void btnPerfeito_Click(object sender, EventArgs e)
        {
            bool teste;
            int num = Int16.Parse(txtNum.Text);
            teste = NumeroNatural.Perfeito(num);
            lbResultado.Text = teste ? "Número perfeito" : "Número imperfeito";
        }
    }
}