namespace calendario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataInicial = new System.Windows.Forms.TextBox();
            this.txtDataFinal = new System.Windows.Forms.TextBox();
            this.txtDataAtual = new System.Windows.Forms.TextBox();
            this.btnSelecionarData = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDataInicialAuto = new System.Windows.Forms.TextBox();
            this.txtDataFinalAuto = new System.Windows.Forms.TextBox();
            this.txtDataAtualAuto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Itens = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Restaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.Mensagem = new System.Windows.Forms.ToolStripMenuItem();
            this.Fechar = new System.Windows.Forms.ToolStripMenuItem();
            this.Itens.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(92, 47);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.monthCalendar.MaxSelectionCount = 30;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(334, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data final:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(334, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data atual:";
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.Location = new System.Drawing.Point(429, 59);
            this.txtDataInicial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Size = new System.Drawing.Size(96, 20);
            this.txtDataInicial.TabIndex = 4;
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Location = new System.Drawing.Point(429, 97);
            this.txtDataFinal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(96, 20);
            this.txtDataFinal.TabIndex = 5;
            // 
            // txtDataAtual
            // 
            this.txtDataAtual.Location = new System.Drawing.Point(429, 130);
            this.txtDataAtual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDataAtual.Name = "txtDataAtual";
            this.txtDataAtual.Size = new System.Drawing.Size(96, 20);
            this.txtDataAtual.TabIndex = 6;
            // 
            // btnSelecionarData
            // 
            this.btnSelecionarData.AllowDrop = true;
            this.btnSelecionarData.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSelecionarData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSelecionarData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarData.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSelecionarData.FlatAppearance.BorderSize = 0;
            this.btnSelecionarData.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarData.Location = new System.Drawing.Point(338, 175);
            this.btnSelecionarData.Name = "btnSelecionarData";
            this.btnSelecionarData.Size = new System.Drawing.Size(115, 34);
            this.btnSelecionarData.TabIndex = 7;
            this.btnSelecionarData.Text = "Selecionar Data";
            this.btnSelecionarData.UseVisualStyleBackColor = false;
            this.btnSelecionarData.Click += new System.EventHandler(this.btnSelecionarData_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(104, 328);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data atual:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(104, 295);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data final:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 259);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Data inicial:";
            // 
            // txtDataInicialAuto
            // 
            this.txtDataInicialAuto.Location = new System.Drawing.Point(198, 259);
            this.txtDataInicialAuto.Name = "txtDataInicialAuto";
            this.txtDataInicialAuto.Size = new System.Drawing.Size(106, 20);
            this.txtDataInicialAuto.TabIndex = 11;
            // 
            // txtDataFinalAuto
            // 
            this.txtDataFinalAuto.Location = new System.Drawing.Point(198, 294);
            this.txtDataFinalAuto.Name = "txtDataFinalAuto";
            this.txtDataFinalAuto.Size = new System.Drawing.Size(106, 20);
            this.txtDataFinalAuto.TabIndex = 12;
            // 
            // txtDataAtualAuto
            // 
            this.txtDataAtualAuto.Location = new System.Drawing.Point(198, 327);
            this.txtDataAtualAuto.Name = "txtDataAtualAuto";
            this.txtDataAtualAuto.Size = new System.Drawing.Size(106, 20);
            this.txtDataAtualAuto.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(130, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Seleção automática";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.btnSair.Location = new System.Drawing.Point(459, 175);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(66, 34);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.Itens;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Calendário";
            this.notifyIcon.Visible = true;
            // 
            // Itens
            // 
            this.Itens.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Restaurar,
            this.Mensagem,
            this.Fechar});
            this.Itens.Name = "contextMenuStrip1";
            this.Itens.Size = new System.Drawing.Size(134, 70);
            this.Itens.Text = "Itens";
            this.Itens.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Itens_ItemClicked);
            // 
            // Restaurar
            // 
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(133, 22);
            this.Restaurar.Text = "Restaurar";
            // 
            // Mensagem
            // 
            this.Mensagem.Name = "Mensagem";
            this.Mensagem.Size = new System.Drawing.Size(133, 22);
            this.Mensagem.Text = "Mensagem";
            // 
            // Fechar
            // 
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(133, 22);
            this.Fechar.Text = "Fechar";
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 397);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDataAtualAuto);
            this.Controls.Add(this.txtDataFinalAuto);
            this.Controls.Add(this.txtDataInicialAuto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSelecionarData);
            this.Controls.Add(this.txtDataAtual);
            this.Controls.Add(this.txtDataFinal);
            this.Controls.Add(this.txtDataInicial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Calendário";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Itens.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDataInicial;
        private System.Windows.Forms.TextBox txtDataFinal;
        private System.Windows.Forms.TextBox txtDataAtual;
        private System.Windows.Forms.Button btnSelecionarData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDataInicialAuto;
        private System.Windows.Forms.TextBox txtDataFinalAuto;
        private System.Windows.Forms.TextBox txtDataAtualAuto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip Itens;
        private System.Windows.Forms.ToolStripMenuItem Restaurar;
        private System.Windows.Forms.ToolStripMenuItem Mensagem;
        private System.Windows.Forms.ToolStripMenuItem Fechar;
    }
}

