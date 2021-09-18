using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//adicionado nova threading para chamar/utilizar novas telas
using System.Threading;


namespace DeliveryBebidas
{
    public partial class Form2 : Form
    {
        //nova thread chamada nt (nova tela)
        Thread nt;
        public Form2()
        {
            InitializeComponent();
        }

        private void cadastroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoForm()
        {
            //chama a inicialização do form3
            Application.Run(new Form3());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //apos clicar em cadastro ciente o sistema abre o form3 para cadastro de cliente
            nt = new Thread(novoForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //apos clicar em cadastro ciente o sistema abre o form4 para mostrar o pedido finalizado
            nt = new Thread(novoForm1);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoForm1()
        {

            //chama a inicialização do form3
            Application.Run(new Form4());
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void relatórioDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // para o usuário realizar o logout
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void cadastroMercToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //apos clicar em Cadastro Merc. o sistema abre o form6 para cadastro de mercadorias
            nt = new Thread(novoForm3);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoForm3()
        {
            //chama a inicialização do form6
            Application.Run(new Form6());
        }

        private void relPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //apos clicar em Rel. Pedidos o sistema abre o form7 para efetua a busca dos pedidos por período
            nt = new Thread(novoForm4);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoForm4()
        {
            //chama a inicialização do form7
            Application.Run(new Form6());
        }
    }
}
