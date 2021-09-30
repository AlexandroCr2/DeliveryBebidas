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
    public partial class TelaLogin : Form
    {
        //nova thread chamada nt (nova tela)
        Thread nt;
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //após clicar no botão 1 o sistema compara "se" os conteúdos das textBox1 e textBox2
            //são iguais os predefinidos
            //caso sim, exibe uma mensagem, fechha a aplicação Form1 e abre a aplicação Form2
            if (textBox1.Text == "Admin" && textBox2.Text == "12345")
            {
                MessageBox.Show("Login realizado com sucesso!");
                this.Close();
                nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }

        else
            {
                MessageBox.Show("Usuário ou senha incorretos");
            }

        }

        private void novoForm()
        {
            //chama a inicialização do form2
            Application.Run(new Form2());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // caso o usuário cancele o login através do botão cancelar o sistema é fechado
            this.Close();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
