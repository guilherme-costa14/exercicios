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

namespace trocarVariavel
{
    public partial class Form1 : Form
    {
        decimal valorA = 0, valorB = 0, valorC = 0;

        private void btnRecalcular_Click(object sender, EventArgs e)
        {
            txtValorA.Text = "";
            txtValorB.Text = "";
            txtValorATrocado.Text = "";
            txtValorBTrocado.Text = "";
            txtValorA.Focus();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            if(txtValorA.Text != "" && txtValorB.Text != "")
            {
                valorA = decimal.Parse(txtValorA.Text, CultureInfo.InvariantCulture);
                valorB = decimal.Parse(txtValorB.Text, CultureInfo.InvariantCulture);

                valorC = valorA;
                valorA = valorB;
                valorB = valorC;

                txtValorATrocado.Text = Convert.ToString(valorA);
                txtValorBTrocado.Text = Convert.ToString(valorB);
            }
            else
            {
                MessageBox.Show("Digite os valores para efetuar as trocas.");
            }
        }
    }
}
