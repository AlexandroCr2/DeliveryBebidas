using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DeliveryBebidas
{
    public partial class Form7 : Form
    {
        public Form7()
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

        private void button2_Click(object sender, EventArgs e)
        {
            // fecha a tela de relatório de pedidos 
            this.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Data1 = System.String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(tbInicial.Text));

            string Data2 = System.String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(tbFinal.Text));

            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM pedidos WHERE dataPedido BETWEEN '" + (Data1 + "?") + "' and '" + (Data2 + "?") + "'";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dgPedidos.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgPedidos.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//CPF
                    row.Cells[2].Value = reader.GetString(2);//CLIENTE
                    row.Cells[3].Value = reader.GetString(3);//TELEFONE
                    row.Cells[4].Value = reader.GetString(4);//ENDEREÇO
                    row.Cells[5].Value = reader.GetString(5);//PAGAMENTO
                    row.Cells[6].Value = reader.GetString(6);//ITENS
                    row.Cells[7].Value = reader.GetString(7);//TOTAL
                    row.Cells[8].Value = reader.GetDateTime(8);//DATA
                    dgPedidos.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                Console.WriteLine(ex.Message);
            }
        }
}
}
