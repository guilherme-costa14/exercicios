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

namespace calculadora
{
    public partial class Form1 : Form
    {
        double valor1 = 0, valor2 = 0;
        string operacao = "";
        double resultado = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "8";
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            if(txtVisor.Text != "")
            {
                valor1 = double.Parse(txtVisor.Text, CultureInfo.InvariantCulture);
                txtVisor.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Digite um valor para efetuar a soma!", "Atenção");
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                valor1 = double.Parse(txtVisor.Text, CultureInfo.InvariantCulture);
                txtVisor.Text = "";
                operacao = "SUB";
                lblOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Digite um valor para efetuar a subtração!", "Atenção");
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                valor1 = double.Parse(txtVisor.Text, CultureInfo.InvariantCulture);
                txtVisor.Text = "";
                operacao = "MULT";
                lblOperacao.Text = "*";
            }
            else
            {
                MessageBox.Show("Digite um valor para efetuar a multiplicação!", "Atenção");
            }
        }

        private void btnBarra_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                valor1 = double.Parse(txtVisor.Text, CultureInfo.InvariantCulture);
                txtVisor.Text = "";
                operacao = "DIV";
                lblOperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Digite um valor para efetuar a divisão!", "Atenção");
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(txtVisor.Text,CultureInfo.InvariantCulture);
            if (operacao == "SOMA")
            {
                txtVisor.Text = Convert.ToString(valor1 + valor2);
            }
            else if(operacao == "SUB")
            {
                txtVisor.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                txtVisor.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIV")
            {
                txtVisor.Text = Convert.ToString(valor1 / valor2);
            }
            else if (operacao == "PORCENT")
            {
                txtVisor.Text = Convert.ToString((valor1 / 100) * valor2);
            }
            else if(operacao == "MOD")
            {
                txtVisor.Text = Convert.ToString(valor1 % valor2);
            }
            else
            {
                txtVisor.Text = Convert.ToString(Math.Pow(valor1, valor2));
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
            lblOperacao.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                valor1 = double.Parse(txtVisor.Text, CultureInfo.InvariantCulture);
                txtVisor.Text = "";
                operacao = "PORCENT";
                lblOperacao.Text = "%";
            }
            else
            {
                MessageBox.Show("Digite um valor para efetuar a porcentagem!", "Atenção");
            }
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if(!txtVisor.Text.Contains("."))
            {
                txtVisor.Text += ".";
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                valor1 = double.Parse(txtVisor.Text, CultureInfo.InvariantCulture);
                txtVisor.Text = "";
                operacao = "MOD";
                lblOperacao.Text = "%";
            }
            else
            {
                MessageBox.Show("Digite um valor para efetuar a módulo!", "Atenção");
            }
        }

        private void btnExponenciacao_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                valor1 = double.Parse(txtVisor.Text, CultureInfo.InvariantCulture);
                txtVisor.Text = "";
                operacao = "x²";
                lblOperacao.Text = "x²";
            }
            else
            {
                MessageBox.Show("Digite um valor para efetuar a exponenciação!", "Atenção");
            }
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                valor1 = double.Parse(txtVisor.Text, CultureInfo.InvariantCulture);
                txtVisor.Text = Convert.ToString(Math.Sqrt(valor1));
                operacao = "Raiz²";
                lblOperacao.Text = "Raiz²";
            }
            else
            {
                MessageBox.Show("Digite um valor para efetuar a raiz quadrada!", "Atenção");
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "9";
        }

    }
}
