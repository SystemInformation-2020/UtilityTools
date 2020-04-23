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
            if (this.rbtnLocal.Checked)
            {
                btnArquivoUp.Enabled = true;

                btnCarregarCarro.Enabled = true;
            }
            else
            {
                btnArquivoUp.Enabled = false;
            }
        }

        private void btnArquivoUp_Click(object sender, EventArgs e)
        {
            OpenFileDialog arquivoup = new OpenFileDialog();

            if (arquivoup.ShowDialog() == DialogResult.OK)
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

            var resultado = algorithm.pipe<object>(input);

            Console.WriteLine(response.result);

            Console.WriteLine("----------");

            

            //txtOutCarro.Text = response.result.ToString();


            txtOutCarro.Text = resultado.result.ToString();

            pbCarroOut.ImageLocation = txtEnderecoCarro.Text;


            pbCarroOut.BackgroundImageLayout = ImageLayout.Stretch;


            txtOutCarro.Text = txtOutCarro.Text.Replace("[", "");
            txtOutCarro.Text = txtOutCarro.Text.Replace("]", "");

            //txtOutCarro.Text = txtOutCarro.Text.Replace("{", "");//NAO CONTEM*

            txtOutCarro.Text = txtOutCarro.Text.Replace("},", "\n----------");

            txtOutCarro.Text = txtOutCarro.Text.Replace("\"", "");

            txtOutCarro.Text = txtOutCarro.Text.Replace("{", "");

            //PALAVRAS

            txtOutCarro.Text = txtOutCarro.Text.Replace("body_style:", "Estilo de Corpo:");

            txtOutCarro.Text = txtOutCarro.Text.Replace("confidence:", "Chance (%*100):");

            txtOutCarro.Text = txtOutCarro.Text.Replace("make:", "Marca:");

            txtOutCarro.Text = txtOutCarro.Text.Replace("model:", "Modelo:");

            txtOutCarro.Text = txtOutCarro.Text.Replace("model_year:", "Ano:");


        }

        private void rbtnLink_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rbtnLink.Checked)
            {
                btnCarregarCarro.Enabled = true;
            }
        }

        private void btnGoImageColor_Click(object sender, EventArgs e)
        {
            var input = txtEnderecoImagemColor.Text ;


            var client = new Client("simGui+0ItIawILfndtvMe8Bbsd1");
            var algorithm = client.algo("deeplearning/ColorfulImageColorization/1.1.13");


            algorithm.setOptions(timeout: 300); // optional
            var response = algorithm.pipeJson<object>(input);
            
            
            Console.WriteLine(response.result);// RESULTADO



            //pboxImagemColor.ImageLocation = txtEnderecoCarro.Text;



        }

        private void rbtnLinkColor_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rbtnLinkColor.Checked)
            {
                btnGoImageColor.Enabled = true;
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(4);
        }
    }
}
