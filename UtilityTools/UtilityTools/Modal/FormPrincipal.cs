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

        public double numb1, numb2, total;


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

        private void btnQRGerar_Click(object sender, EventArgs e)
        {
            if (txtTextoQR.Text == string.Empty || txtLarguraQR.Text == string.Empty && txtAlturaQR.Text == string.Empty)
            {
                MessageBox.Show("Informações inválidas. Complete as informações para gerar o QRCode...");
                txtTextoQR.Focus();
                return;
            }

            try
            {
                int largura = Convert.ToInt32(txtLarguraQR.Text);
                int altura = Convert.ToInt32(txtAlturaQR.Text);
                picQRCode.Image = GerarQRCode(largura, altura, txtTextoQR.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static Bitmap GerarQRCode(int width, int height, string text)
        {
            try
            {
                var bw = new ZXing.BarcodeWriter();
                var encOptions = new ZXing.Common.EncodingOptions()
                {
                    Width = width,
                    Height = height,
                    Margin = 0
                };
                bw.Options = encOptions;
                bw.Format = ZXing.BarcodeFormat.QR_CODE;
                var resultado = new Bitmap(bw.Write(text));
                return resultado;
            }
            catch
            {
                throw;
            }
        }

        private void txtTextoQR_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTextoQR.Text))
            {
                btnQRGerar.Enabled = true;
            }
        }


        private void btn0_Click(object sender, EventArgs e)
        {
            txtValor.Text = txtValor.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtValor.Text = txtValor.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtValor.Text = txtValor.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtValor.Text = txtValor.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtValor.Text = txtValor.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtValor.Text = txtValor.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtValor.Text = txtValor.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtValor.Text = txtValor.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtValor.Text = txtValor.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtValor.Text = txtValor.Text + "9";
        }


        private void btnVirgula_Click(object sender, EventArgs e)
        {
            txtValor.Text = txtValor.Text + ",";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {

            //lblConta.Text = lblConta.Text + btnResult.Text;
            //numb2 = Convert.ToDouble(txtValor.Text);



            txtValor.Text = "";

            total = numb1 / numb2;
            txtValor.Text = total.ToString();
            total = numb1 % numb2;

            txtRest.Text = "Resto: " + total.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            numb1 = Convert.ToDouble(txtValor.Text);
            //lblConta.Text = Convert.ToString(numb1) + "/";


            txtValor.Text += txtRest.Text;

            txtRest.Text = "";

        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            lblConta.Text = "";
            txtRest.Text = "";
        }
    }
}
