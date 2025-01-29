namespace combobox_gastoKcal
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_atividadeFisica = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericdropdownTempo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericdropdownTempo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(145, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o tipo de atividade física:";
            // 
            // cbb_atividadeFisica
            // 
            this.cbb_atividadeFisica.FormattingEnabled = true;
            this.cbb_atividadeFisica.Items.AddRange(new object[] {
            "Musculação",
            "Cardío",
            "Natação",
            "Caminhada",
            "Corrida",
            "Maratona",
            "Andar de bicicleta",
            "Andar de patins"});
            this.cbb_atividadeFisica.Location = new System.Drawing.Point(402, 84);
            this.cbb_atividadeFisica.Name = "cbb_atividadeFisica";
            this.cbb_atividadeFisica.Size = new System.Drawing.Size(178, 21);
            this.cbb_atividadeFisica.TabIndex = 1;
            this.cbb_atividadeFisica.SelectedIndexChanged += new System.EventHandler(this.cbb_atividadeFisica_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(219, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Informe seu PESO em KG:";
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(402, 132);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(66, 20);
            this.txt_peso.TabIndex = 3;
            this.txt_peso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_peso_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(117, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quanto tempo você irá fazer o exercício:";
            // 
            // numericdropdownTempo
            // 
            this.numericdropdownTempo.Location = new System.Drawing.Point(402, 173);
            this.numericdropdownTempo.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericdropdownTempo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericdropdownTempo.Name = "numericdropdownTempo";
            this.numericdropdownTempo.Size = new System.Drawing.Size(34, 20);
            this.numericdropdownTempo.TabIndex = 6;
            this.numericdropdownTempo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(228, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "O valor Kcal gasto é de:";
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(402, 215);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(66, 20);
            this.txt_resultado.TabIndex = 8;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(120, 264);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(118, 31);
            this.btn_calcular.TabIndex = 9;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(290, 264);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(118, 31);
            this.btn_limpar.TabIndex = 10;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(462, 264);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(118, 31);
            this.btn_sair.TabIndex = 11;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::combobox_gastoKcal.Properties.Resources.img_fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(703, 416);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericdropdownTempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_atividadeFisica);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericdropdownTempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_atividadeFisica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericdropdownTempo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_sair;
    }
}

