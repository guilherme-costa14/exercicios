using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // permite usar o mysql

namespace bancoDeDados
{
    public partial class formCadastro : Form
    {
        public formCadastro()
        {
            InitializeComponent();
        }

        private void dgvInformacoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server = localhost; user = root; database = informacoes; password =;");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_dados", conn);

            //DataTable = armazena o resultado da consulta
            DataTable dt = new DataTable();
            conn.Open();

            //MySqlDataAdapter = preenche o DataTable com o resultado da consulta
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();

            //Vincula o DataTable ao DataGridView para exibir os dados na grade
            dgvInformacoes.DataSource = dt;
        }

        private void txtCaixaDePesquisa_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtCaixaDePesquisa.Text;
            MySqlConnection conn = new MySqlConnection("server = localhost; user = root; database = informacoes; password =;");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_dados where Nome like '%"+pesquisa+"%'", conn);

            //DataTable = armazena o resultado da consulta
            DataTable dt = new DataTable();
            conn.Open();

            //MySqlDataAdapter = preenche o DataTable com o resultado da consulta
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();

            //Vincula o DataTable ao DataGridView para exibir os dados na grade
            dgvInformacoes.DataSource = dt;
        }

        private void btnCadastrarNovosDados_Click(object sender, EventArgs e)
        {
            Form formCadastro = new Form2();
            formCadastro.Show();
        }
    }
}
