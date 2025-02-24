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

namespace converterMoeda
{
    public partial class Form1 : Form
    {
        decimal valor1 =0, valorConvertido = 0;
        double taxa = 5.75;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtDolar.Text != "")
            {
                valor1 = decimal.Parse(txtDolar.Text, CultureInfo.InvariantCulture);
                valorConvertido = valor1 * (decimal)taxa;
                txtReal.Text = Convert.ToString(valorConvertido);
            }
            else
            {
                MessageBox.Show("Digite uma valor para realizar o calculo.");
            }
        }

        private void btnRecalcular_Click(object sender, EventArgs e)
        {
            txtDolar.Text = "";
            txtDolar.Focus();
            txtReal.Text = "";
        }

        private void txtDolar_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
