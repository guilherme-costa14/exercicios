using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            string nome = txt_nome.Text;
            
            switch (Convert.ToInt32(cbb_numeros.SelectedItem))
            {
                case 1:
                    lbl_mes.Text = "Olá " + txt_nome.Text + " você nasceu em janeiro";
                break;

                case 2:
                    lbl_mes.Text = "Olá " + txt_nome.Text + " você nasceu em fevereiro";
                    break;

                case 3:
                    lbl_mes.Text = "Olá " + txt_nome.Text + " você nasceu em março";
                    break;

                case 4:
                    lbl_mes.Text = "Olá " + txt_nome.Text + " você nasceu em abril";
                    break;

                case 5:
                    lbl_mes.Text = "Olá " + txt_nome.Text + " você nasceu em maio";
                    break;

                case 6:
                    lbl_mes.Text = "Olá " + txt_nome.Text + " você nasceu em junho";
                    break;

                default:
                    lbl_mes.Text = "Escolha um número.";
                    break;
            }
        }
    }
}
