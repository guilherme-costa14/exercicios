namespace combobox
{
    partial class Form1
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
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.cbb_numeros = new System.Windows.Forms.ComboBox();
            this.lbl_escolher = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.lbl_mes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(485, 195);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(191, 41);
            this.btn_confirmar.TabIndex = 0;
            this.btn_confirmar.Text = "Escolha um número e clique aqui!";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // cbb_numeros
            // 
            this.cbb_numeros.FormattingEnabled = true;
            this.cbb_numeros.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbb_numeros.Location = new System.Drawing.Point(268, 206);
            this.cbb_numeros.Name = "cbb_numeros";
            this.cbb_numeros.Size = new System.Drawing.Size(179, 21);
            this.cbb_numeros.TabIndex = 1;
            // 
            // lbl_escolher
            // 
            this.lbl_escolher.AutoSize = true;
            this.lbl_escolher.Location = new System.Drawing.Point(95, 209);
            this.lbl_escolher.Name = "lbl_escolher";
            this.lbl_escolher.Size = new System.Drawing.Size(151, 13);
            this.lbl_escolher.TabIndex = 2;
            this.lbl_escolher.Text = "Escolha um número de 1 a 12:";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(485, 279);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(190, 41);
            this.btn_voltar.TabIndex = 3;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            // 
            // lbl_mes
            // 
            this.lbl_mes.AutoSize = true;
            this.lbl_mes.Location = new System.Drawing.Point(265, 293);
            this.lbl_mes.Name = "lbl_mes";
            this.lbl_mes.Size = new System.Drawing.Size(0, 13);
            this.lbl_mes.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite o seu nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(268, 161);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(179, 20);
            this.txt_nome.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 464);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_mes);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.lbl_escolher);
            this.Controls.Add(this.cbb_numeros);
            this.Controls.Add(this.btn_confirmar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.ComboBox cbb_numeros;
        private System.Windows.Forms.Label lbl_escolher;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label lbl_mes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
    }
}

