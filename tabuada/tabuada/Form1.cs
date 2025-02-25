using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtValor.Text, out int numero))
            {
                MessageBox.Show("Digite um valor válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Clear();
                txtValor.Focus();
                return;
            }
            
            for(int contador = 1; contador <= 10; contador++)
            {
                txtTabuada.AppendText($"{numero} * {contador} = {numero * contador}{Environment.NewLine}");
            }
        }

        private void btnRecalcular_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            txtTabuada.Text = "";

            txtValor.Focus();
        }
    }
}
