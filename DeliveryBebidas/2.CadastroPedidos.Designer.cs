
namespace DeliveryBebidas
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPagamento = new System.Windows.Forms.ComboBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroMercToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbCPF = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbValorItem = new System.Windows.Forms.ComboBox();
            this.lbItens = new System.Windows.Forms.ListBox();
            this.lbValores = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNomeCliente = new System.Windows.Forms.TextBox();
            this.tbEndCliente = new System.Windows.Forms.TextBox();
            this.tbTelCliente = new System.Windows.Forms.TextBox();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbItem
            // 
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Location = new System.Drawing.Point(98, 46);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(141, 21);
            this.cbItem.TabIndex = 1;
            this.cbItem.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Confirmar Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecionar Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total a pagar";
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(330, 160);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(108, 20);
            this.tbTotal.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Finalizar Pedido";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "CPF Cliente";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(33, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Pesquisar Cliente";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Dados do Cliente";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(139, 134);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Cadastrar Cliente";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Forma de Pagamento";
            // 
            // cbPagamento
            // 
            this.cbPagamento.FormattingEnabled = true;
            this.cbPagamento.Items.AddRange(new object[] {
            "Crédito",
            "Dinheiro"});
            this.cbPagamento.Location = new System.Drawing.Point(118, 281);
            this.cbPagamento.Name = "cbPagamento";
            this.cbPagamento.Size = new System.Drawing.Size(110, 21);
            this.cbPagamento.TabIndex = 17;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.cadastroMercToolStripMenuItem,
            this.relPedidosToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(456, 24);
            this.menuStrip2.TabIndex = 19;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // cadastroMercToolStripMenuItem
            // 
            this.cadastroMercToolStripMenuItem.Name = "cadastroMercToolStripMenuItem";
            this.cadastroMercToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.cadastroMercToolStripMenuItem.Text = "Cadastro Merc.";
            this.cadastroMercToolStripMenuItem.Click += new System.EventHandler(this.cadastroMercToolStripMenuItem_Click);
            // 
            // relPedidosToolStripMenuItem
            // 
            this.relPedidosToolStripMenuItem.Name = "relPedidosToolStripMenuItem";
            this.relPedidosToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.relPedidosToolStripMenuItem.Text = "Rel. Pedidos";
            this.relPedidosToolStripMenuItem.Click += new System.EventHandler(this.relPedidosToolStripMenuItem_Click);
            // 
            // tbCPF
            // 
            this.tbCPF.Location = new System.Drawing.Point(98, 102);
            this.tbCPF.Mask = "000.000.000-00";
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(84, 20);
            this.tbCPF.TabIndex = 23;
            this.tbCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Valor Item";
            // 
            // cbValorItem
            // 
            this.cbValorItem.FormattingEnabled = true;
            this.cbValorItem.Location = new System.Drawing.Point(98, 75);
            this.cbValorItem.Name = "cbValorItem";
            this.cbValorItem.Size = new System.Drawing.Size(51, 21);
            this.cbValorItem.TabIndex = 25;
            // 
            // lbItens
            // 
            this.lbItens.FormattingEnabled = true;
            this.lbItens.Location = new System.Drawing.Point(257, 46);
            this.lbItens.Name = "lbItens";
            this.lbItens.Size = new System.Drawing.Size(126, 108);
            this.lbItens.TabIndex = 26;
            // 
            // lbValores
            // 
            this.lbValores.FormattingEnabled = true;
            this.lbValores.Location = new System.Drawing.Point(389, 46);
            this.lbValores.Name = "lbValores";
            this.lbValores.Size = new System.Drawing.Size(49, 108);
            this.lbValores.TabIndex = 27;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(340, 279);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 23);
            this.button6.TabIndex = 28;
            this.button6.Text = "Limpar Campos";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Telefone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Endereço";
            // 
            // tbNomeCliente
            // 
            this.tbNomeCliente.Location = new System.Drawing.Point(68, 197);
            this.tbNomeCliente.Name = "tbNomeCliente";
            this.tbNomeCliente.Size = new System.Drawing.Size(256, 20);
            this.tbNomeCliente.TabIndex = 32;
            // 
            // tbEndCliente
            // 
            this.tbEndCliente.Location = new System.Drawing.Point(68, 249);
            this.tbEndCliente.Name = "tbEndCliente";
            this.tbEndCliente.Size = new System.Drawing.Size(370, 20);
            this.tbEndCliente.TabIndex = 34;
            // 
            // tbTelCliente
            // 
            this.tbTelCliente.Location = new System.Drawing.Point(68, 223);
            this.tbTelCliente.Name = "tbTelCliente";
            this.tbTelCliente.Size = new System.Drawing.Size(100, 20);
            this.tbTelCliente.TabIndex = 33;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(456, 314);
            this.Controls.Add(this.tbEndCliente);
            this.Controls.Add(this.tbTelCliente);
            this.Controls.Add(this.tbNomeCliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.lbValores);
            this.Controls.Add(this.lbItens);
            this.Controls.Add(this.cbValorItem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbCPF);
            this.Controls.Add(this.cbPagamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbItem);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pedido";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPagamento;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroMercToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relPedidosToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox tbCPF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbValorItem;
        private System.Windows.Forms.ListBox lbItens;
        private System.Windows.Forms.ListBox lbValores;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbNomeCliente;
        private System.Windows.Forms.TextBox tbEndCliente;
        private System.Windows.Forms.TextBox tbTelCliente;
    }
}