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

namespace ordemDecrescente
{
    public partial class Form1 : Form
    {
        decimal valorA = 0, valorB = 0, valorC = 0;

        private void btnRecalcular_Click(object sender, EventArgs e)
        {
            txtValorA.Text = "";
            txtValorB.Text = "";
            txtValorC.Text = "";
            txtExibirResultado.Text = "";
            txtValorA.Focus();
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valorA = decimal.Parse(txtValorA.Text, CultureInfo.InvariantCulture);
            valorB = decimal.Parse(txtValorB.Text, CultureInfo.InvariantCulture);
            valorC = decimal.Parse(txtValorC.Text, CultureInfo.InvariantCulture);

            decimal[] numeros = {valorA, valorB, valorC};
            Array.Sort(numeros);
            Array.Reverse(numeros);

            txtExibirResultado.Text = string.Join(" - ", numeros);
            
        }
    }
}
