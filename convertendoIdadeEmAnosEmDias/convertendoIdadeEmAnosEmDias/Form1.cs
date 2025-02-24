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

namespace convertendoIdadeEmAnosEmDias
{
    public partial class Form1 : Form
    {
        decimal idadeEmDias = 0, anos = 365, dias = 30, valorEmAnos = 0, valorEmMeses = 0, valorEmDias = 0;

        private void btnRecalcular_Click(object sender, EventArgs e)
        {
            txtAnos.Text = "";
            txtMeses.Text = "";
            txtDias.Text = "";
            txtResultado.Text = "";
            txtAnos.Focus();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtAnos.Text != "" && txtMeses.Text != "" && txtDias.Text != "")
            {
                valorEmAnos = decimal.Parse(txtAnos.Text, CultureInfo.InvariantCulture);
                valorEmMeses = decimal.Parse(txtMeses.Text, CultureInfo.InvariantCulture);
                valorEmDias = decimal.Parse(txtDias.Text, CultureInfo.InvariantCulture);

                idadeEmDias = (valorEmAnos * anos) + (valorEmMeses * dias) + valorEmDias;

                txtResultado.Text = Convert.ToString(idadeEmDias);
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente.");
            }
        }
    }
}
