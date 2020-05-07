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

namespace UtilityTools.Modal
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection();

        string login, password;

        MySqlConnection objCon = new MySqlConnection("server=localhost; port=3309; User Id=root; database=utilitysi; password=usbw");


        private void FormRegister_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100,0,0,0);
            panel2.BackColor = Color.FromArgb(100, 0, 0, 3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtCpassword.Text == txtPassword.Text)
                {
                    objCon.Open();

                    MySqlCommand objCmd = new MySqlCommand("INSERT INTO `utilitysi`.`cadastros` (`Nome`, `CPF`, `Email`, `Senha`)" +
                        " VALUES " +
                        "('"+txtName.Text+"', '"+mtxtcpf.Text+"', '"+txtEmail.Text+"', '"+txtCpassword.Text+"');", objCon);

                    objCmd.ExecuteNonQuery();

                    objCon.Close();

                    MessageBox.Show("Usuario Cadastrado!", "OK");
                }
                else
                {
                    MessageBox.Show("Erro: Senhas Não concidem!");
                }



            }catch (Exception a)
            {
                MessageBox.Show(a.Message, "ERROR tec.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                MessageBox.Show("ERROR. Contate o Desenvolvedor Para Mais Informações", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
