using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox_elementos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbb_selecionar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbb_listar.SelectedItem = 0;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (txt_nome.TextLength == 0) 
            {
                    MessageBox.Show("Por favor, digite algo!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txt_nome.Focus();

                cbb_listar.Items.Add(txt_nome.Text);
                txt_nome.Clear();
                txt_nome.Focus();
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            if (cbb_listar.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor, digite algo!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cbb_listar.Items.Remove(cbb_listar.SelectedItem);
                cbb_listar.SelectedIndex = 0;
            }

        }
    }
}
