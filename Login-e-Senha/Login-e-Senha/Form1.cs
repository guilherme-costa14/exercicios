using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //adicionando a biblioteca do bd

namespace Login_e_Senha
{
    public partial class FormBD : Form
    {
        private MySqlConnection conexao;
        private string datasource;

        public FormBD()
        {
            InitializeComponent();

            listContato.View = View.Details;
            listContato.LabelEdit = true;
            listContato.AllowColumnReorder = true;
            listContato.FullRowSelect = true;
            listContato.GridLines = true;
            listContato.Columns.Add("ID", 40, HorizontalAlignment.Left);
            listContato.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            listContato.Columns.Add("Senha", 150, HorizontalAlignment.Left);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //vamos utilizar o TryCathc para executar uma ação
            //e checar se houve ou não ação de conexão com nosso banco
            if(txtLogin.Text == "" && txtSenha.Text == "")
            {
                MessageBox.Show("Por favor preencher nome de usuário e senha!");
                txtLogin.Focus();
                txtSenha.Focus();
            }

            try
            {
                String datasource = "datasource=localhost; username=root; password=; database=db_usuario";
                //vamos conectar com o banco

                conexao = new MySqlConnection(datasource); //até aqui criamos a conexão com o banco

                //vamos inserir dentro do banco - insert
                string sql = "INSERT INTO tb_loginsenha (usuario, senha)" + "Values ('" + txtLogin.Text + " ','" + txtSenha.Text + " ' )";
                //vamos criar um objeto chamado MySQL Comand para armazenar
                MySqlCommand comando = new MySqlCommand(sql, conexao); //esse cara irá armazenar e executar o comando e qual conexão - porém não executa!
                conexao.Open(); //vamos abrir a conexão para inserção de dados lá na tabela

                comando.ExecuteReader();

                //falando para o usuário que deu certo a inserção de dados
                MessageBox.Show("Inserção de dados bem sucedida!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);//msg de erro pré definida da syntaxe com o BD;
                                            //MessageBox.Show("mensagem de erro não conectando"); opcional
            }
            finally
            {
                conexao.Close(); //vamos fechar a conexão
                txtLogin.Text = "";
                txtSenha.Text = "";
                txtLogin.Focus();
                txtSenha.Focus();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                string Selecao = "'%" + txtLogin.Text + "%'";
                conexao = new MySqlConnection(datasource); //até aqui criamos a conexão com o banco
                //vamos fazer a seleção
                string sql = "SELECT * FROM tb_loginsenha WHERE usuario LIKE " + Selecao;
                conexao.Open(); //vamos abrir a conexão para garantir a seleção lá na tabela
                //vamos criar um objeto chamado MySQL Comand para armazenar e retornar a seleção
                MySqlCommand comando = new MySqlCommand(sql, conexao);//esse cara irá armazenar e executar o comando e qual conexão
                                                                      //esse comando vai retornar um valor recuperando informações lá do banco

                MySqlDataReader LER = comando.ExecuteReader();
                listContato.Items.Clear();//limpar o list view

                while (LER.Read())
                {
                    String[] row =
                    {
                        LER.GetString(0),
                        LER.GetString(1),
                        LER.GetString(2),
                    };
                    var Linha_ListaContatos = new ListViewItem(row);

                    listContato.Items.Add(Linha_ListaContatos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//msg de erro pré definida da syntaxe com o BD;
                                            //MessageBox.Show("mensagem de erro não conectando"); opcional
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
