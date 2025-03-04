﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calendario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelecionarData_Click(object sender, EventArgs e)
        {
            txtDataInicial.Text = monthCalendar.SelectionStart.ToShortDateString();
            txtDataFinal.Text = monthCalendar.SelectionEnd.ToShortDateString();
            txtDataAtual.Text = monthCalendar.TodayDate.ToShortDateString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtDataInicialAuto.Text = monthCalendar.SelectionStart.ToShortDateString();
            txtDataFinalAuto.Text = monthCalendar.SelectionEnd.ToShortDateString();
            txtDataAtualAuto.Text = monthCalendar.TodayDate.ToShortDateString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
           
        }

        private void Itens_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.ToString() == "Fechar")
            {
                this.Close();
            }
            else if (e.ClickedItem.Name.ToString() == "Restaurar")
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (e.ClickedItem.Name.ToString() == "Mensagem")
            {
                MessageBox.Show("Você está lendo essa mensagem!");
            }
        }
    }
}
