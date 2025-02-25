namespace escolharUmaOpcaoParaCalcular
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.txtValorB = new System.Windows.Forms.TextBox();
            this.btnAdicao = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblValorA = new System.Windows.Forms.Label();
            this.lblSinalOperacao = new System.Windows.Forms.Label();
            this.lblValorB = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnRecalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(572, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 63);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Escreva um programa que exiba as seguintes opções e realize os que se pede em cad" +
    "a uma delas: 1 – Adição 2 – Subtração 3 – Multiplicação 4 – Divisão ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informe os valores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor B:";
            // 
            // txtValorA
            // 
            this.txtValorA.Location = new System.Drawing.Point(83, 53);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(100, 20);
            this.txtValorA.TabIndex = 4;
            this.txtValorA.TextChanged += new System.EventHandler(this.txtValorA_TextChanged);
            // 
            // txtValorB
            // 
            this.txtValorB.Location = new System.Drawing.Point(82, 86);
            this.txtValorB.Name = "txtValorB";
            this.txtValorB.Size = new System.Drawing.Size(101, 20);
            this.txtValorB.TabIndex = 5;
            // 
            // btnAdicao
            // 
            this.btnAdicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicao.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdicao.Location = new System.Drawing.Point(21, 112);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(75, 31);
            this.btnAdicao.TabIndex = 6;
            this.btnAdicao.Text = "Adição";
            this.btnAdicao.UseVisualStyleBackColor = false;
            this.btnAdicao.Click += new System.EventHandler(this.btnAdicao_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSubtracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtracao.ForeColor = System.Drawing.Color.Transparent;
            this.btnSubtracao.Location = new System.Drawing.Point(102, 112);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(120, 31);
            this.btnSubtracao.TabIndex = 7;
            this.btnSubtracao.Text = "Subtração";
            this.btnSubtracao.UseVisualStyleBackColor = false;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMultiplicacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacao.ForeColor = System.Drawing.Color.Transparent;
            this.btnMultiplicacao.Location = new System.Drawing.Point(228, 112);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(125, 31);
            this.btnMultiplicacao.TabIndex = 8;
            this.btnMultiplicacao.Text = "Multiplicação";
            this.btnMultiplicacao.UseVisualStyleBackColor = false;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDivisao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisao.ForeColor = System.Drawing.Color.Transparent;
            this.btnDivisao.Location = new System.Drawing.Point(359, 112);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(75, 31);
            this.btnDivisao.TabIndex = 9;
            this.btnDivisao.Text = "Divisão";
            this.btnDivisao.UseVisualStyleBackColor = false;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Resultado";
            // 
            // lblValorA
            // 
            this.lblValorA.AutoSize = true;
            this.lblValorA.BackColor = System.Drawing.Color.Transparent;
            this.lblValorA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorA.Location = new System.Drawing.Point(225, 57);
            this.lblValorA.Name = "lblValorA";
            this.lblValorA.Size = new System.Drawing.Size(0, 16);
            this.lblValorA.TabIndex = 11;
            // 
            // lblSinalOperacao
            // 
            this.lblSinalOperacao.AutoSize = true;
            this.lblSinalOperacao.BackColor = System.Drawing.Color.Transparent;
            this.lblSinalOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinalOperacao.Location = new System.Drawing.Point(275, 57);
            this.lblSinalOperacao.Name = "lblSinalOperacao";
            this.lblSinalOperacao.Size = new System.Drawing.Size(0, 16);
            this.lblSinalOperacao.TabIndex = 12;
            // 
            // lblValorB
            // 
            this.lblValorB.AutoSize = true;
            this.lblValorB.BackColor = System.Drawing.Color.Transparent;
            this.lblValorB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorB.Location = new System.Drawing.Point(325, 57);
            this.lblValorB.Name = "lblValorB";
            this.lblValorB.Size = new System.Drawing.Size(0, 16);
            this.lblValorB.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(375, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "=";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(395, 57);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 16);
            this.lblResultado.TabIndex = 15;
            // 
            // btnRecalcular
            // 
            this.btnRecalcular.BackColor = System.Drawing.Color.Red;
            this.btnRecalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecalcular.ForeColor = System.Drawing.Color.Transparent;
            this.btnRecalcular.Location = new System.Drawing.Point(440, 112);
            this.btnRecalcular.Name = "btnRecalcular";
            this.btnRecalcular.Size = new System.Drawing.Size(94, 31);
            this.btnRecalcular.TabIndex = 16;
            this.btnRecalcular.Text = "Recalcular";
            this.btnRecalcular.UseVisualStyleBackColor = false;
            this.btnRecalcular.Click += new System.EventHandler(this.btnRecalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 282);
            this.Controls.Add(this.btnRecalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblValorB);
            this.Controls.Add(this.lblSinalOperacao);
            this.Controls.Add(this.lblValorA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnAdicao);
            this.Controls.Add(this.txtValorB);
            this.Controls.Add(this.txtValorA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorA;
        private System.Windows.Forms.TextBox txtValorB;
        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblValorA;
        private System.Windows.Forms.Label lblSinalOperacao;
        private System.Windows.Forms.Label lblValorB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnRecalcular;
    }
}

