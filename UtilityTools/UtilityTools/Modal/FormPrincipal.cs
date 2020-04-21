using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Algorithmia;

using MySql.Data.MySqlClient;

namespace UtilityTools.Modal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection();

        MySqlConnection objCon = new MySqlConnection("server=localhost; port=3309; User Id=root; database=utilitysi; password=usbw");



        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void rbtnLocal_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rbtnLocal.Checked)
            {
                btnArquivoUp.Enabled = true;
            }
            else
            {
                btnArquivoUp.Enabled = false;
            }
        }

        private void btnArquivoUp_Click(object sender, EventArgs e)
        {
            OpenFileDialog arquivoup = new OpenFileDialog();

            if(arquivoup.ShowDialog() == DialogResult.OK)
            {
                // StreamReader readarq = new StreamReader(arquivoup.FileName, Encoding.Default);
                // readarq.Close();

                txtEnderecoCarro.Text = arquivoup.FileName;

            }


        }

        private void btnCarregarCarro_Click(object sender, EventArgs e)
        {
            var input = txtEnderecoCarro.Text;
            var client = new Client("simGui+0ItIawILfndtvMe8Bbsd1");
            var algorithm = client.algo("LgoBE/CarMakeandModelRecognition/0.4.7");
            algorithm.setOptions(timeout: 300); // optional
            var response = algorithm.pipe<object>(input);

            Console.WriteLine(response.result);

            //txtOutCarro.Text = ;
        }
    }
}
