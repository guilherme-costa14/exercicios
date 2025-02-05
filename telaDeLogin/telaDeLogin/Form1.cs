using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; //libera mais espaço na memória

namespace telaDeLogin
{
    public partial class Form1 : Form
    {
        Thread nt; //criação da Thread como "se fosse uma variável"
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == Properties.Resources.Login && txtSenha.Text == Properties.Resources.Senha)
            {
                //MessageBox.Show("Bem vindo ao sistema", "Acesso os Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                nt = new Thread(novoform);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else
            {
                MessageBox.Show("Acesso negado", "Acesso negado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void novoform()
        {
            Application.Run(new FormLogin()); //chamar apenas o novo formulário (FormLogin).
            //throw new NotImplementedException();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
