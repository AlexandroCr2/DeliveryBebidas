//CONTATAR O SERVIDOR
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
//adicionado nova threading para chamar/utilizar novas telas
using System.Threading;
using System.Windows.Forms;


namespace DeliveryBebidas
{
    public partial class Form2 : Form
    {
        //nova thread chamada nt (nova tela)
        Thread nt;
        public Form2()
        {
            InitializeComponent();
            cboItem();
        }

        // nova conexão com o banco de dados 
        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "delivery";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }

        void cboItem()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();
                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM bebidas WHERE ativoBebida = 1";
                DataSet ds = new DataSet();
                MySqlDataAdapter adpt = new MySqlDataAdapter(comandoMySql);
                adpt.Fill(ds);
                cbItem.DataSource = ds.Tables[0];
                cbItem.DisplayMember = "nomeBebida";
                cbValorItem.DataSource = ds.Tables[0];
                cbValorItem.DisplayMember = "valorBebida";

                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                Console.WriteLine(ex.Message);
            }
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
            limparCampos();
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
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {

                var itens = string.Join(",", lbItens.Items.Cast<string>());
                var valores = string.Join(",", lbValores.Items.Cast<string>());

                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                comandoMySql.CommandText = "INSERT INTO `pedidos`(`cpfPedido`, `clientePedido`, `telPedido`, `endPedido`, `pagamentoPedido`, `itensPedido`, `totalPedido`)" +
                    "VALUES ('" + tbCPF.Text + "','" + tbNomeCliente.Text + "','" + tbTelCliente.Text + "','" + tbEndCliente.Text + "','" + cbPagamento.Text + "','" + itens + "','" + tbTotal
                    .Text + "')";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Pedido realizado com sucesso!");

                limparCampos();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        
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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // para o usuário realizar o logout
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand consultar = new MySqlCommand("SELECT * FROM `clientes` WHERE cpfCliente = ?", realizaConexacoBD);
                consultar.Parameters.Clear();
                consultar.Parameters.Add("@cpfCliente", MySqlDbType.VarChar).Value = tbCPF.Text;

                consultar.CommandType = CommandType.Text;

                MySqlDataReader recepcao;
                recepcao = consultar.ExecuteReader();
                recepcao.Read();

                tbNomeCliente.Text = recepcao.GetString(1);
                tbTelCliente.Text = recepcao.GetString(4);
                tbEndCliente.Text = recepcao.GetString(5);

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cliente não encontrado, gentieza realizar o cadastro! ");
                
            }
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
            nt = new Thread(novoForm7);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoForm7()
        {
            //chama a inicialização do form7
            Application.Run(new Form7());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbItens.Items.Add(cbItem.Text);
            lbValores.Items.Add(cbValorItem.Text);
            decimal total = 0.0m;
            foreach (string s in lbValores.Items)
            {
                total += decimal.Parse(s);
            }
            tbTotal.Text = total.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void limparCampos()
        {
            lbItens.Items.Clear();
            lbValores.Items.Clear();
            tbTotal.Text = "";
            tbCPF.Text = "";
            tbEndCliente.Text = "";
            tbNomeCliente.Text = "";
            tbTelCliente.Text = "";
            cbPagamento.Text = "";
            cbItem.Text = "";
            cbValorItem.Text = "";
        }
    }
}
