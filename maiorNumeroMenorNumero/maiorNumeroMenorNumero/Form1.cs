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

namespace maiorNumeroMenorNumero
{
    public partial class Form1 : Form
    {
        decimal valorA = 0, valorB = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRecalcular_Click(object sender, EventArgs e)
        {
            txtValorA.Text = "";
            txtValorB.Text = "";
            txtMaiorValor.Text = "";
            txtMenorValor.Text = "";
            txtIgual.Text = "";
            txtValorA.Focus();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            valorA = decimal.Parse(txtValorA.Text, CultureInfo.InvariantCulture);
            valorB = decimal.Parse(txtValorB.Text, CultureInfo.InvariantCulture);

            if (valorA == valorB)
            {
                txtIgual.Text = Convert.ToString("Os valores são iguais");
            }
            else
            {
                decimal maior = (valorA > valorB) ? valorA : valorB;
                decimal menor = (valorA < valorB) ? valorA : valorB;

                txtMaiorValor.Text = maior.ToString(CultureInfo.InvariantCulture);
                txtMenorValor.Text = menor.ToString(CultureInfo.InvariantCulture);
            }

        }
    }
}
