using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace bancoDeDados
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server = localhost; user = root; database = informacoes; password=;");
            MySqlCommand cmd = new MySqlCommand("INSERT INTO tb_dados (Nome, Sobrenome, Cidade, Estado) VALUES (@Nome, @Sobrenome, @Cidade, @Estado)", conn);

            //Inserção no Banco de Dados
            cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@Sobrenome", txtSobrenome.Text);
            cmd.Parameters.AddWithValue("@Cidade", txtCidade.Text);
            cmd.Parameters.AddWithValue("@Estado", txtEstado.Text);

            //Abrindo Conexão
            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();

            //Validando a inserção de dados
            if(rowsAffected > 0)
            {
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao inserir dados.");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
