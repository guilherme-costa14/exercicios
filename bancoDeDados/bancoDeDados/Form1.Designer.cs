namespace bancoDeDados
{
    partial class formCadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtCaixaDePesquisa = new System.Windows.Forms.TextBox();
            this.dgvInformacoes = new System.Windows.Forms.DataGridView();
            this.btnCadastrarNovosDados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Green;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Location = new System.Drawing.Point(20, 20);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(129, 26);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // txtCaixaDePesquisa
            // 
            this.txtCaixaDePesquisa.Location = new System.Drawing.Point(155, 24);
            this.txtCaixaDePesquisa.Name = "txtCaixaDePesquisa";
            this.txtCaixaDePesquisa.Size = new System.Drawing.Size(194, 20);
            this.txtCaixaDePesquisa.TabIndex = 1;
            this.txtCaixaDePesquisa.TextChanged += new System.EventHandler(this.txtCaixaDePesquisa_TextChanged);
            // 
            // dgvInformacoes
            // 
            this.dgvInformacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformacoes.Location = new System.Drawing.Point(20, 64);
            this.dgvInformacoes.Name = "dgvInformacoes";
            this.dgvInformacoes.Size = new System.Drawing.Size(649, 193);
            this.dgvInformacoes.TabIndex = 2;
            this.dgvInformacoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInformacoes_CellContentClick);
            // 
            // btnCadastrarNovosDados
            // 
            this.btnCadastrarNovosDados.BackColor = System.Drawing.Color.Green;
            this.btnCadastrarNovosDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarNovosDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarNovosDados.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastrarNovosDados.Location = new System.Drawing.Point(502, 272);
            this.btnCadastrarNovosDados.Name = "btnCadastrarNovosDados";
            this.btnCadastrarNovosDados.Size = new System.Drawing.Size(167, 29);
            this.btnCadastrarNovosDados.TabIndex = 3;
            this.btnCadastrarNovosDados.Text = "Cadastrar Novos Dados";
            this.btnCadastrarNovosDados.UseVisualStyleBackColor = false;
            this.btnCadastrarNovosDados.Click += new System.EventHandler(this.btnCadastrarNovosDados_Click);
            // 
            // formCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 349);
            this.Controls.Add(this.btnCadastrarNovosDados);
            this.Controls.Add(this.dgvInformacoes);
            this.Controls.Add(this.txtCaixaDePesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.Name = "formCadastro";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtCaixaDePesquisa;
        private System.Windows.Forms.DataGridView dgvInformacoes;
        private System.Windows.Forms.Button btnCadastrarNovosDados;
    }
}

