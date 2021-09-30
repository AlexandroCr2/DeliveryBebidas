
namespace DeliveryBebidas
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNomeCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbValorPedido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPagamento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumPedido = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbbDataPedido = new System.Windows.Forms.MaskedTextBox();
            this.tbTelCliente = new System.Windows.Forms.MaskedTextBox();
            this.rtbItens = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbEndCliente = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Itens do Pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome do Cliente";
            // 
            // tbNomeCliente
            // 
            this.tbNomeCliente.Enabled = false;
            this.tbNomeCliente.Location = new System.Drawing.Point(12, 273);
            this.tbNomeCliente.Name = "tbNomeCliente";
            this.tbNomeCliente.Size = new System.Drawing.Size(247, 20);
            this.tbNomeCliente.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor do Pedido";
            // 
            // tbValorPedido
            // 
            this.tbValorPedido.Enabled = false;
            this.tbValorPedido.Location = new System.Drawing.Point(96, 154);
            this.tbValorPedido.Name = "tbValorPedido";
            this.tbValorPedido.Size = new System.Drawing.Size(160, 20);
            this.tbValorPedido.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Forma de Pagamento";
            // 
            // tbPagamento
            // 
            this.tbPagamento.Enabled = false;
            this.tbPagamento.Location = new System.Drawing.Point(123, 189);
            this.tbPagamento.Name = "tbPagamento";
            this.tbPagamento.Size = new System.Drawing.Size(136, 20);
            this.tbPagamento.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telefone do Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido Número";
            // 
            // tbNumPedido
            // 
            this.tbNumPedido.Enabled = false;
            this.tbNumPedido.Location = new System.Drawing.Point(99, 10);
            this.tbNumPedido.Name = "tbNumPedido";
            this.tbNumPedido.Size = new System.Drawing.Size(120, 20);
            this.tbNumPedido.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Data do Pedido";
            // 
            // tbbDataPedido
            // 
            this.tbbDataPedido.Enabled = false;
            this.tbbDataPedido.Location = new System.Drawing.Point(96, 222);
            this.tbbDataPedido.Mask = "00/00/0000";
            this.tbbDataPedido.Name = "tbbDataPedido";
            this.tbbDataPedido.Size = new System.Drawing.Size(74, 20);
            this.tbbDataPedido.TabIndex = 16;
            this.tbbDataPedido.ValidatingType = typeof(System.DateTime);
            // 
            // tbTelCliente
            // 
            this.tbTelCliente.Enabled = false;
            this.tbTelCliente.Location = new System.Drawing.Point(114, 298);
            this.tbTelCliente.Mask = "(99) 0 0000-0000";
            this.tbTelCliente.Name = "tbTelCliente";
            this.tbTelCliente.Size = new System.Drawing.Size(113, 20);
            this.tbTelCliente.TabIndex = 17;
            // 
            // rtbItens
            // 
            this.rtbItens.Enabled = false;
            this.rtbItens.Location = new System.Drawing.Point(12, 61);
            this.rtbItens.Name = "rtbItens";
            this.rtbItens.Size = new System.Drawing.Size(247, 87);
            this.rtbItens.TabIndex = 18;
            this.rtbItens.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Endereço do Cliente";
            // 
            // rtbEndCliente
            // 
            this.rtbEndCliente.Enabled = false;
            this.rtbEndCliente.Location = new System.Drawing.Point(12, 348);
            this.rtbEndCliente.Name = "rtbEndCliente";
            this.rtbEndCliente.Size = new System.Drawing.Size(247, 36);
            this.rtbEndCliente.TabIndex = 19;
            this.rtbEndCliente.Text = "";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 396);
            this.Controls.Add(this.rtbEndCliente);
            this.Controls.Add(this.rtbItens);
            this.Controls.Add(this.tbTelCliente);
            this.Controls.Add(this.tbbDataPedido);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPagamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbValorPedido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNomeCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNumPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido Finalizado";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNomeCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbValorPedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPagamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumPedido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox tbbDataPedido;
        private System.Windows.Forms.MaskedTextBox tbTelCliente;
        private System.Windows.Forms.RichTextBox rtbItens;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbEndCliente;
    }
}