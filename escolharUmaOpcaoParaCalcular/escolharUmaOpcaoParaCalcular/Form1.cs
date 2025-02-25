using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace escolharUmaOpcaoParaCalcular
{
    public partial class Form1 : Form
    {

        decimal valorA = 0, valorB = 0, resultado = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (txtValorA.Text != "")
            {
                valorA = decimal.Parse(txtValorA.Text, CultureInfo.InvariantCulture);
                valorB = decimal.Parse(txtValorB.Text, CultureInfo.InvariantCulture);

                lblValorA.Text = Convert.ToString(valorA);
                lblValorB.Text = Convert.ToString(valorB);
                lblSinalOperacao.Text = "-";

                resultado = valorA - valorB;

                lblResultado.Text = Convert.ToString(resultado);
            }
            else
            {
                MessageBox.Show("Digite um valor para começar a operação.");
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (txtValorA.Text != "")
            {
                valorA = decimal.Parse(txtValorA.Text, CultureInfo.InvariantCulture);
                valorB = decimal.Parse(txtValorB.Text, CultureInfo.InvariantCulture);

                lblValorA.Text = Convert.ToString(valorA);
                lblValorB.Text = Convert.ToString(valorB);
                lblSinalOperacao.Text = "*";

                resultado = valorA * valorB;

                lblResultado.Text = Convert.ToString(resultado);
            }
            else
            {
                MessageBox.Show("Digite um valor para começar a operação.");
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if(txtValorA.Text != "")
            {
                valorA = decimal.Parse(txtValorA.Text, CultureInfo.InvariantCulture);
                valorB = decimal.Parse(txtValorB.Text, CultureInfo.InvariantCulture);

                lblValorA.Text = Convert.ToString(valorA);
                lblValorB.Text = Convert.ToString(valorB);
                lblSinalOperacao.Text = "/";

                resultado = valorA / valorB;

                lblResultado.Text = Convert.ToString(resultado);
            }
            else
            {
                MessageBox.Show("Digite um valor para começar a operação.");
            }
        }

        private void btnRecalcular_Click(object sender, EventArgs e)
        {
            txtValorA.Text = "";
            txtValorB.Text = "";

            lblValorA.Text = "";
            lblSinalOperacao.Text = "";
            lblValorB.Text = "";
            lblResultado.Text = "";

            txtValorA.Focus();

        }

        private void txtValorA_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            if (txtValorA.Text != "")
            {
                valorA = decimal.Parse(txtValorA.Text, CultureInfo.InvariantCulture);
                valorB = decimal.Parse(txtValorB.Text, CultureInfo.InvariantCulture);

                lblValorA.Text = Convert.ToString(valorA);
                lblValorB.Text = Convert.ToString(valorB);
                lblSinalOperacao.Text = "+";

                resultado = valorA + valorB;

                lblResultado.Text = Convert.ToString(resultado);
            }
            else
            {
                MessageBox.Show("Digite um valor para começar a operação.");
            }
            
            
        }
    }
}
