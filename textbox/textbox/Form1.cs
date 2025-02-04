using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == "")
            {
                MessageBox.Show("Por favor insira um nome no campo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nome.Focus();
                return;
            }
            //else é opcional por causa do return.

            txt_multi.Text += txt_nome.Text + ", ";
            txt_nome.Clear();
            txt_nome.Focus();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_multi.Clear();
            txt_nome.Focus();
        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            Form2 form2= new Form2(txt_multi.Text);
            form2.ShowDialog();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
