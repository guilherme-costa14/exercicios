namespace textbox
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
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_abrir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_multi = new System.Windows.Forms.TextBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(222, 108);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(249, 20);
            this.txt_nome.TabIndex = 0;
            // 
            // btn_inserir
            // 
            this.btn_inserir.BackColor = System.Drawing.SystemColors.Control;
            this.btn_inserir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_inserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_inserir.Location = new System.Drawing.Point(477, 105);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(90, 25);
            this.btn_inserir.TabIndex = 1;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = false;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(222, 299);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(346, 32);
            this.btn_limpar.TabIndex = 2;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_abrir
            // 
            this.btn_abrir.Location = new System.Drawing.Point(222, 346);
            this.btn_abrir.Name = "btn_abrir";
            this.btn_abrir.Size = new System.Drawing.Size(162, 32);
            this.btn_abrir.TabIndex = 3;
            this.btn_abrir.Text = "Abrir segundo formulário";
            this.btn_abrir.UseVisualStyleBackColor = true;
            this.btn_abrir.Click += new System.EventHandler(this.btn_abrir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite o nome de seus convidados!!!";
            // 
            // txt_multi
            // 
            this.txt_multi.Location = new System.Drawing.Point(222, 134);
            this.txt_multi.Multiline = true;
            this.txt_multi.Name = "txt_multi";
            this.txt_multi.Size = new System.Drawing.Size(345, 149);
            this.txt_multi.TabIndex = 5;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(410, 346);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(156, 31);
            this.btn_fechar.TabIndex = 6;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.txt_multi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_abrir);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.txt_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_abrir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_multi;
        private System.Windows.Forms.Button btn_fechar;
    }
}

