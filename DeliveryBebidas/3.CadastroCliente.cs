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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
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

        private void Form3_Load(object sender, EventArgs e)
        {
            atualizarGrid();
            dgCliente.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 10);
        }

        private void atualizarGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM clientes WHERE ativoCliente = 1";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dgCliente.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgCliente.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetString(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//NASCIMENTO
                    row.Cells[3].Value = reader.GetString(3);//CPF
                    row.Cells[4].Value = reader.GetString(4);//TELEFONE
                    row.Cells[5].Value = reader.GetString(5);//ENDEREÇO
                    dgCliente.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                comandoMySql.CommandText = "INSERT INTO clientes (nomeCliente,nascCliente,cpfCliente,telCliente,endCliente) " +
                    "VALUES('" + tbNome.Text + "', '" + tbNascimento.Text + "', '" + tbCPF.Text + "', '" + tbTelefone.Text + "', '" + tbEndereco.Text + "')";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Inserido com sucesso");
                atualizarGrid();
                limparCampos();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
                limparCampos();
        }

        private void limparCampos()
        {
            tbNome.Clear();
            tbID.Clear();
            tbNascimento.Clear();
            tbCPF.Clear();
            tbTelefone.Clear();
            tbEndereco.Clear();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "UPDATE clientes SET nomeCliente = '" + tbNome.Text + "'," +
                    "nascCliente = '" + tbNascimento.Text + "', " +
                    "cpfCliente = '" + tbCPF.Text + "', " +
                    "telCliente = '" + tbTelefone.Text + "', " +
                    "endCliente = '" + tbEndereco.Text + "'" +
                    " WHERE idCliente = " + tbID.Text + "";

                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Atualizado com sucesso"); //Exibo mensagem de aviso
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void dgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCliente.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgCliente.CurrentRow.Selected = true;
                //preenche os textbox com as células da linha selecionada
                tbID.Text = dgCliente.Rows[e.RowIndex].Cells["colID"].FormattedValue.ToString();
                tbNome.Text = dgCliente.Rows[e.RowIndex].Cells["colNome"].FormattedValue.ToString();
                tbNascimento.Text = dgCliente.Rows[e.RowIndex].Cells["colNascimento"].FormattedValue.ToString();
                tbCPF.Text = dgCliente.Rows[e.RowIndex].Cells["colCPF"].FormattedValue.ToString();
                tbTelefone.Text = dgCliente.Rows[e.RowIndex].Cells["colTelefone"].FormattedValue.ToString();
                tbEndereco.Text = dgCliente.Rows[e.RowIndex].Cells["colEndereco"].FormattedValue.ToString();
            }
        }
    }
}
