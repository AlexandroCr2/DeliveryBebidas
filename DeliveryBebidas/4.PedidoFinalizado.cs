using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DeliveryBebidas
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

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

        private void Form4_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand consultar = new MySqlCommand("SELECT * FROM pedidos ORDER BY idPedido DESC LIMIT 1", realizaConexacoBD);



                consultar.CommandType = CommandType.Text;

                MySqlDataReader recepcao;
                recepcao = consultar.ExecuteReader();
                recepcao.Read();

                tbNumPedido.Text = recepcao.GetString(0);
                rtbItens.Text = recepcao.GetString(6);
                tbValorPedido.Text = recepcao.GetString(7);
                tbPagamento.Text = recepcao.GetString(5);
                tbbDataPedido.Text = recepcao.GetString(8);
                tbNomeCliente.Text = recepcao.GetString(2);
                tbTelCliente.Text = recepcao.GetString(3);
                rtbEndCliente.Text = recepcao.GetString(4);

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
            }
            catch (Exception ex)
            {

            }
        }

        private object reader(string listBox)
        {
            throw new NotImplementedException();
        }
    }
}
