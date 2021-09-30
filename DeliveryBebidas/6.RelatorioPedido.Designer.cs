
namespace DeliveryBebidas
{
    partial class Form7
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbInicial = new System.Windows.Forms.MaskedTextBox();
            this.tbFinal = new System.Windows.Forms.MaskedTextBox();
            this.dgPedidos = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Final";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Gerar Relatório";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(490, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbInicial
            // 
            this.tbInicial.Location = new System.Drawing.Point(79, 19);
            this.tbInicial.Mask = "00-00-0000";
            this.tbInicial.Name = "tbInicial";
            this.tbInicial.Size = new System.Drawing.Size(100, 20);
            this.tbInicial.TabIndex = 6;
            this.tbInicial.ValidatingType = typeof(System.DateTime);
            this.tbInicial.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // tbFinal
            // 
            this.tbFinal.Location = new System.Drawing.Point(257, 19);
            this.tbFinal.Mask = "00-00-0000";
            this.tbFinal.Name = "tbFinal";
            this.tbFinal.Size = new System.Drawing.Size(100, 20);
            this.tbFinal.TabIndex = 7;
            this.tbFinal.ValidatingType = typeof(System.DateTime);
            // 
            // dgPedidos
            // 
            this.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colCPF,
            this.colCliente,
            this.colTelefone,
            this.colEndereco,
            this.colPagamento,
            this.colItens,
            this.colTotal,
            this.colData});
            this.dgPedidos.Location = new System.Drawing.Point(16, 55);
            this.dgPedidos.Name = "dgPedidos";
            this.dgPedidos.Size = new System.Drawing.Size(781, 273);
            this.dgPedidos.TabIndex = 8;
            // 
            // colID
            // 
            this.colID.Frozen = true;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Width = 30;
            // 
            // colCPF
            // 
            this.colCPF.Frozen = true;
            this.colCPF.HeaderText = "CPF";
            this.colCPF.Name = "colCPF";
            this.colCPF.Width = 80;
            // 
            // colCliente
            // 
            this.colCliente.Frozen = true;
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            // 
            // colTelefone
            // 
            this.colTelefone.Frozen = true;
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.Width = 80;
            // 
            // colEndereco
            // 
            this.colEndereco.Frozen = true;
            this.colEndereco.HeaderText = "Endereço";
            this.colEndereco.Name = "colEndereco";
            // 
            // colPagamento
            // 
            this.colPagamento.Frozen = true;
            this.colPagamento.HeaderText = "Pagamento";
            this.colPagamento.Name = "colPagamento";
            this.colPagamento.Width = 70;
            // 
            // colItens
            // 
            this.colItens.Frozen = true;
            this.colItens.HeaderText = "Itens";
            this.colItens.Name = "colItens";
            // 
            // colTotal
            // 
            this.colTotal.Frozen = true;
            this.colTotal.HeaderText = "Total Pedido";
            this.colTotal.Name = "colTotal";
            this.colTotal.Width = 50;
            // 
            // colData
            // 
            this.colData.Frozen = true;
            this.colData.HeaderText = "Data do Pedido";
            this.colData.Name = "colData";
            this.colData.Width = 115;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 340);
            this.Controls.Add(this.dgPedidos);
            this.Controls.Add(this.tbFinal);
            this.Controls.Add(this.tbInicial);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Pedidos";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox tbInicial;
        private System.Windows.Forms.MaskedTextBox tbFinal;
        private System.Windows.Forms.DataGridView dgPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
    }
}