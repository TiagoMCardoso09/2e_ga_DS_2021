using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularArrobaDoBoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPeso.Text = "0";
            txtRendimento.Text = "0";
            txtValor.Text = "0";
            lbValor.Text = "R$ 00,00";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == ',') c = '.';
            if (!char.IsNumber(c) && c != '.') e.Handled = true;
            else e.Handled = false;
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == ',') c = '.';
            if (!char.IsNumber(c) && c != '.') e.Handled = true;
            else e.Handled = false;
        }

        private void txtValor_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == ',') c = '.';
            if (!char.IsNumber(c) && c != '.') e.Handled = true;
            else e.Handled = false;
        }

        private void txtRendimento_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == ',') c = '.';
            if (!char.IsNumber(c) && c != '.') e.Handled = true;
            else e.Handled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso = double.Parse(txtPeso.Text);
            double rc = double.Parse(txtRendimento.Text);
            double valor = double.Parse(txtValor.Text);

            double arroba = 0;
            double precofinal = 0;

            arroba = (peso * (rc / 100))/15;
            precofinal = arroba * valor;

            Convert.ToString(precofinal);

            lbValor.Text = "R$ " + precofinal.ToString("F2");
        }
    }
}
