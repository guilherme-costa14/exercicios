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

namespace imc
{
    public partial class Form1 : Form
    {
        decimal alturaCm = 0, alturaM = 0, pesoIdeal = 0;
        double homem = 72.7, mulher = 62.1, correcaoMulher = 44.7;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtPesoIdeal.Text = "";

            checkBoxFeminino.Checked = false;
            checkBoxMasculino.Checked = false;

            txtAltura.Focus();
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAltura.Text))
            {
                if (decimal.TryParse(txtAltura.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out decimal alturaConvertida))
                {
                    alturaCm = alturaConvertida;
                    alturaM = alturaCm / 100;
                }
                else
                {
                    MessageBox.Show("Digite um valor numérico válido para a altura em cm.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (alturaM <= 0)
            {
                MessageBox.Show("Digite uma altura válida antes de calcular.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (checkBoxMasculino.Checked)
            {
                pesoIdeal = ((decimal)homem * alturaM) - 58;
                txtPesoIdeal.Text = pesoIdeal.ToString("F2", CultureInfo.InvariantCulture);
            }
            else if (checkBoxFeminino.Checked)
            {
                pesoIdeal = ((decimal)mulher * alturaM) - (decimal)correcaoMulher;
                txtPesoIdeal.Text = pesoIdeal.ToString("F2", CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Você precisa escolher um gênero para calcular o peso ideal.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
