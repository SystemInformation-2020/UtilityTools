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

namespace UtilityTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection();

        string login, password;

        MySqlConnection objCon = new MySqlConnection("server=localhost; port=3309; User Id=root; database=utilitysi; password=usbw");



        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Modal.FormRegister f2 = new Modal.FormRegister();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidaUsuario(txtEmail.Text, txtPassword.Text))
            {
                this.DialogResult = DialogResult.OK;

                this.Hide();

                Modal.FormPrincipal formhome = new Modal.FormPrincipal();
                formhome.ShowDialog();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }


        private bool ValidaUsuario(string usuario, string senha)
        {
            //variável que será testada para
            //informar o retorno
            int retorno = -1;

            //comando sql que dá um count 
            //na tabela se existirem usuario e senha
            //com os dados informados
            string comando = "SELECT COUNT(*) FROM cadastros WHERE Email=@Email AND Senha=@Senha";
            //instância do comando
            MySqlCommand cmd = new MySqlCommand(comando, objCon);
            //preenchimento dos parâmetros
            cmd.Parameters.AddWithValue("@Email", usuario);
            cmd.Parameters.AddWithValue("@Senha", senha);
            //abro conexão
            objCon.Open();
            //retorno recebe o resultado do execute scalar
            retorno = Convert.ToInt32(cmd.ExecuteScalar());
            //fecho conexão
            objCon.Close();
            //retorno true se retorno for maior que zero
            return retorno > 0;

        }

    }
}
