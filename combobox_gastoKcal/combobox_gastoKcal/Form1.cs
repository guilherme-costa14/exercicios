using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox_gastoKcal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (cbb_atividadeFisica.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Insira uma opção válida de atividade física!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_resultado.Clear();
                cbb_atividadeFisica.Focus();
            }
            else if (txt_peso.Text == "")
            {
                MessageBox.Show("Por favor, insira seu PESO", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_resultado.Clear();
                txt_peso.Focus();
            }
            else if (Convert.ToInt32(txt_peso.Text) < 1 || Convert.ToInt32(txt_peso.Text) > 200)
            {
                MessageBox.Show("PESO deve estar entre 1Kg e 200Kg", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_resultado.Clear();
                txt_peso.Focus();
            }
            else
            {
                switch (cbb_atividadeFisica.SelectedItem)
                {
                    case "Musculação":
                        txt_resultado.Text = (Convert.ToDecimal(txt_peso.Text) * numericdropdownTempo.Value * 2).ToString();
                        break;

                    case "Cardío":
                        txt_resultado.Text = (Convert.ToDecimal(txt_peso.Text) * numericdropdownTempo.Value * 1).ToString();
                        break;

                    case "Natação":
                        txt_resultado.Text = (Convert.ToDecimal(txt_peso.Text) * numericdropdownTempo.Value * 1).ToString();
                        break;

                    case "Caminhada":
                        txt_resultado.Text = (Convert.ToDecimal(txt_peso.Text) * numericdropdownTempo.Value * 2).ToString();
                        break;

                    case "Corrida":
                        txt_resultado.Text = (Convert.ToDecimal(txt_peso.Text) * numericdropdownTempo.Value * 3).ToString();
                        break;

                    case "Maratona":
                        txt_resultado.Text = (Convert.ToDecimal(txt_peso.Text) * numericdropdownTempo.Value * 5).ToString();
                        break;

                    default:
                        MessageBox.Show("Escolha uma opção válida", "Atenção!");
                        break;
                }
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_peso.Clear();
            txt_resultado.Clear();
            cbb_atividadeFisica.SelectedItem = null;
            numericdropdownTempo.Value = 1;
            cbb_atividadeFisica.Focus();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbb_atividadeFisica_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_resultado.Clear();
        }

        private void txt_peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
